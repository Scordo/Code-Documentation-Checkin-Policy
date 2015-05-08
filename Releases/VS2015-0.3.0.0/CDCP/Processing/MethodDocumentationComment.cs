using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace CDCP.Processing
{
	/// <summary>
	/// A documentation comment derived from either source text or metadata.
	/// </summary>
	internal sealed class MethodDocumentationComment
	{
		/// <summary>
		/// An empty comment.
		/// </summary>
		public static readonly MethodDocumentationComment Empty = new MethodDocumentationComment();
		private readonly Dictionary<string, string> parameterTexts = new Dictionary<string, string>();
		private readonly Dictionary<string, string> typeParameterTexts = new Dictionary<string, string>();

		/// <summary>
		/// True if an error occurred when parsing.
		/// </summary>
		public bool HadXmlParseError { get; internal set; }

		/// <summary>
		/// The full XML text of this tag.
		/// </summary>
		public string FullXmlFragmentOpt { get; private set; }

		/// <summary>
		/// The text in the &lt;example&gt; tag. Null if no tag existed.
		/// </summary>
		public string ExampleTextOpt { get; private set; }

		/// <summary>
		/// The text in the &lt;summary&gt; tag. Null if no tag existed.
		/// </summary>
		public string SummaryTextOpt { get; private set; }

		/// <summary>
		/// The text in the &lt;returns&gt; tag. Null if no tag existed.
		/// 
		/// </summary>
		public string ReturnsTextOpt { get; private set; }
		
		/// <summary>
		/// Parses and constructs a DocumentationComment from the given fragment of XML.
		/// 
		/// </summary>
		/// <param name="xml">The fragment of XML to parse.</param>
		/// <returns>
		/// A DocumentionComment instance.
		/// </returns>
		/// <exception cref="T:System.ArgumentException">If the XML fragment was unable to be successfully
		///             parsed.</exception>
		public static MethodDocumentationComment FromXmlFragment(string xml)
		{
			try
			{
				XmlReader xmlReader = XmlReader.Create(new StringReader(xml), new XmlReaderSettings
				{
					ConformanceLevel = ConformanceLevel.Fragment
				});
				MethodDocumentationComment documentationComment = new MethodDocumentationComment { FullXmlFragmentOpt = xml };
				while (xmlReader.IsStartElement())
				{
					if (xmlReader.LocalName == "example" && documentationComment.ExampleTextOpt == null)
						documentationComment.ExampleTextOpt = xmlReader.ReadInnerXml().Trim();
					else if (xmlReader.LocalName == "summary" && documentationComment.SummaryTextOpt == null)
						documentationComment.SummaryTextOpt = xmlReader.ReadInnerXml().Trim();
					else if (xmlReader.LocalName == "returns" && documentationComment.ReturnsTextOpt == null)
						documentationComment.ReturnsTextOpt = xmlReader.ReadInnerXml().Trim();
					else if (xmlReader.LocalName == "param")
					{
						string attribute = xmlReader.GetAttribute("name");
						string innerXml = xmlReader.ReadInnerXml().Trim();
						if (!documentationComment.parameterTexts.ContainsKey(attribute))
							documentationComment.parameterTexts.Add(attribute, innerXml);
					}
					else if (xmlReader.LocalName == "typeparam")
					{
						string attribute = xmlReader.GetAttribute("name");
						if (!documentationComment.typeParameterTexts.ContainsKey(attribute))
							documentationComment.typeParameterTexts.Add(attribute, xmlReader.ReadInnerXml().Trim());
					}
					else
						xmlReader.Read();
				}
				return documentationComment;
			}
			catch (XmlException)
			{
				return new MethodDocumentationComment
				{
					FullXmlFragmentOpt = xml,
					HadXmlParseError = true
				};
			}
		}

		/// <summary>
		/// Returns the text for a given parameter, or null if no documentation was given for the parameter.
		/// </summary>
		public string GetParameterText(string parameterName)
		{
			string result;
			parameterTexts.TryGetValue(parameterName, out result);
			return result;
		}

		/// <summary>
		/// Returns the text for a given type parameter, or null if no documentation was given for the type parameter.
		/// </summary>
		/// <param name="typeParameterName"/>
		/// <returns/>
		public string GetTypeParameterText(string typeParameterName)
		{
			string result;
			typeParameterTexts.TryGetValue(typeParameterName, out result);
			return result;
		}
	}
}

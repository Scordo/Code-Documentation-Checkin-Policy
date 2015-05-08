using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
    public static class ISymbolExtensions
    {
        public static IDocumentationComment GetDocumentationComment(this ISymbol symbol, CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            string xmlText = symbol.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            return string.IsNullOrEmpty(xmlText) ? new DocumentationComment() : DocumentationComment.FromXmlFragment(xmlText);
        }

        /// <summary>
        /// A documentation comment derived from either source text or metadata.
        /// </summary>
        private sealed class DocumentationComment : IDocumentationComment
        {
            #region Fields

            private readonly object _documentationCommentInstance;
            private static readonly MethodInfo _fromXmlFragmentMethodInfo;
            private static readonly PropertyInfo _summaryTextProperty;
            private static readonly PropertyInfo _exampleTextProperty;
            private static readonly PropertyInfo _remarksTextProperty;
            private static readonly PropertyInfo _returnsTextProperty;
            private static readonly PropertyInfo _exceptionTypesProperty;
            private static readonly PropertyInfo _fullXmlFragmentProperty;
            private static readonly PropertyInfo _hadXmlParseErrorProperty;
            private static readonly PropertyInfo _parameterNamesProperty;
            private static readonly PropertyInfo _typeParameterNamesProperty;
            private static readonly FieldInfo _emptyField;
            private static readonly MethodInfo _getParameterTextMethod;
            private static readonly MethodInfo _getTypeParameterTextMethod;
            private static readonly MethodInfo _getExceptionTextsMethod;

            #endregion

            #region Properties

            /// <summary>
            /// True if an error occurred when parsing.
            /// </summary>
            public bool HadXmlParseError { get { return (bool) _hadXmlParseErrorProperty.GetValue(_documentationCommentInstance); }}

            /// <summary>
            /// The full XML text of this tag.
            /// </summary>
            public string FullXmlFragment { get { return (string) _fullXmlFragmentProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The text in the &lt;example&gt; tag. Null if no tag existed.
            /// </summary>
            public string ExampleText { get { return (string) _exampleTextProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The text in the &lt;summary&gt; tag. Null if no tag existed.
            /// </summary>
            public string SummaryText { get { return (string) _summaryTextProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The text in the &lt;returns&gt; tag. Null if no tag existed.
            /// </summary>
            public string ReturnsText { get { return (string) _returnsTextProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The text in the &lt;remarks&gt; tag. Null if no tag existed.
            /// </summary>
            public string RemarksText { get { return (string) _remarksTextProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The names of items in &lt;param&gt; tags.
            /// </summary>
            public ImmutableArray<string> ParameterNames { get { return (ImmutableArray<string>) _parameterNamesProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The names of items in &lt;typeparam&gt; tags.
            /// </summary>
            public ImmutableArray<string> TypeParameterNames { get { return (ImmutableArray<string>) _typeParameterNamesProperty.GetValue(_documentationCommentInstance); } }

            /// <summary>
            /// The types of items in &lt;exception&gt; tags.
            /// </summary>
            public ImmutableArray<string> ExceptionTypes { get { return (ImmutableArray<string>) _exceptionTypesProperty.GetValue(_documentationCommentInstance); } }

            #endregion

            #region Constructors

            static DocumentationComment()
            {
                Type documentationCommentType = typeof (Project).Assembly.GetType("Microsoft.CodeAnalysis.Shared.Utilities.DocumentationComment");
                _fromXmlFragmentMethodInfo = documentationCommentType.GetMethod("FromXmlFragment",BindingFlags.Public | BindingFlags.Static);

                _summaryTextProperty = documentationCommentType.GetProperty("SummaryText");
                _exampleTextProperty = documentationCommentType.GetProperty("ExampleText");
                _remarksTextProperty = documentationCommentType.GetProperty("RemarksText");
                _returnsTextProperty = documentationCommentType.GetProperty("ReturnsText");
                _exceptionTypesProperty = documentationCommentType.GetProperty("ExceptionTypes");
                _fullXmlFragmentProperty = documentationCommentType.GetProperty("FullXmlFragment");
                _hadXmlParseErrorProperty = documentationCommentType.GetProperty("HadXmlParseError");
                _parameterNamesProperty = documentationCommentType.GetProperty("ParameterNames");
                _typeParameterNamesProperty = documentationCommentType.GetProperty("TypeParameterNames");
                _emptyField = documentationCommentType.GetField("Empty", BindingFlags.Public | BindingFlags.Static);
                _getParameterTextMethod = documentationCommentType.GetMethod("GetParameterText");
                _getTypeParameterTextMethod = documentationCommentType.GetMethod("GetTypeParameterText");
                _getExceptionTextsMethod = documentationCommentType.GetMethod("GetExceptionTexts");
                 
            }

            public DocumentationComment() : this(_emptyField.GetValue(null))
            {

            }

            protected DocumentationComment(object documentationCommentInstance)
            {
                _documentationCommentInstance = documentationCommentInstance;
            }

            #endregion

            #region Methods

            /// <summary>
            /// Parses and constructs a <see cref="DocumentationComment" /> from the given fragment of XML.
            /// </summary>
            /// <param name="xml">The fragment of XML to parse.</param>
            /// <returns>A DocumentationComment instance.</returns>
            public static IDocumentationComment FromXmlFragment(string xml)
            {
                return new DocumentationComment(_fromXmlFragmentMethodInfo.Invoke(null, new object[] {xml}));
            }

            /// <summary>
            /// Returns the text for a given parameter, or null if no documentation was given for the parameter.
            /// </summary>
            public string GetParameterText(string parameterName)
            {
                return (string) _getParameterTextMethod.Invoke(_documentationCommentInstance, new object[] {parameterName});
            }

            /// <summary>
            /// Returns the text for a given type parameter, or null if no documentation was given for the type parameter.
            /// </summary>
            /// <param name="typeParameterName"></param>
            /// <returns></returns>
            public string GetTypeParameterText(string typeParameterName)
            {
                return (string)_getTypeParameterTextMethod.Invoke(_documentationCommentInstance, new object[] { typeParameterName });
            }

            /// <summary>
            /// Returns the texts for a given exception, or an empty <see cref="ImmutableArray"/> if no documentation was given for the exception.
            /// </summary>
            public ImmutableArray<string> GetExceptionTexts(string exceptionName)
            {
                return (ImmutableArray<string>) _getExceptionTextsMethod.Invoke(_documentationCommentInstance, new object[] { exceptionName });
            }

            #endregion
        }
    }
}
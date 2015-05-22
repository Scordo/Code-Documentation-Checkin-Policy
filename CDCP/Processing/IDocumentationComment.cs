using System.Collections.Immutable;

namespace CDCP.Processing
{
  public interface IDocumentationComment
  {
    /// <summary>
    /// True if an error occurred when parsing.
    /// </summary>
    bool HadXmlParseError { get; }

    /// <summary>
    /// The full XML text of this tag.
    /// </summary>
    string FullXmlFragment { get; }

    /// <summary>
    /// The text in the &lt;example&gt; tag. Null if no tag existed.
    /// </summary>
    string ExampleText { get; }

    /// <summary>
    /// The text in the &lt;summary&gt; tag. Null if no tag existed.
    /// </summary>
    string SummaryText { get; }

    /// <summary>
    /// The text in the &lt;returns&gt; tag. Null if no tag existed.
    /// </summary>
    string ReturnsText { get; }

    /// <summary>
    /// The text in the &lt;remarks&gt; tag. Null if no tag existed.
    /// </summary>
    string RemarksText { get; }

    /// <summary>
    /// The names of items in &lt;param&gt; tags.
    /// </summary>
    ImmutableArray<string> ParameterNames { get; }

    /// <summary>
    /// The names of items in &lt;typeparam&gt; tags.
    /// </summary>
    ImmutableArray<string> TypeParameterNames { get; }

    /// <summary>
    /// The types of items in &lt;exception&gt; tags.
    /// </summary>
    ImmutableArray<string> ExceptionTypes { get; }

    /// <summary>
    /// Returns the text for a given parameter, or null if no documentation was given for the parameter.
    /// </summary>
    string GetParameterText(string parameterName);

    /// <summary>
    /// Returns the text for a given type parameter, or null if no documentation was given for the type parameter.
    /// </summary>
    /// <param name="typeParameterName"></param>
    /// <returns></returns>
    string GetTypeParameterText(string typeParameterName);

    /// <summary>
    /// Returns the texts for a given exception, or an empty <see cref="ImmutableArray"/> if no documentation was given for the exception.
    /// </summary>
    ImmutableArray<string> GetExceptionTexts(string exceptionName);
  }
}
using System.Linq;

public static class Bob
{
    /// <summary>
    /// Takes in a statement and returns what bob
    /// will respond to it based on the statement's
    /// properties (silence, yelling, questions)
    /// </summary>
    /// <param name="statement"></param>
    /// <returns>response</returns>
    public static string Response(string statement) => statement switch
    {
        _ when statement.Trim().IsSilence() => "Fine. Be that way!",
        _ when statement.Trim().IsQuestion() && statement.Trim().IsYell() => "Calm down, I know what I'm doing!",
        _ when statement.Trim().IsQuestion() => "Sure.",
        _ when statement.Trim().IsYell() => "Whoa, chill out!",
        _ => "Whatever.",
    };

    /// <summary>
    /// Checks if a statement is a question
    /// </summary>
    /// <param name="statement"></param>
    /// <returns>isQuestion</returns>
    public static bool IsQuestion(this string statement) => statement.EndsWith('?');
    
    /// <summary>
    /// Checks if a statement is being yelled.
    /// </summary>
    /// <param name="statement"></param>
    /// <returns>isYell</returns>
    public static bool IsYell(this string statement) => statement.Any(char.IsLetter) && statement.ToUpper() == statement;
    
    /// <summary>
    /// Checks if a statement is silent.
    /// </summary>
    /// <param name="statement"></param>
    /// <returns>isSilence</returns>
    public static bool IsSilence(this string statement) => string.IsNullOrWhiteSpace(statement);
}
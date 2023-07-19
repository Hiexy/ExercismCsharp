using System.Linq;

public static class Bob
{
    public static string Response(string statement) => statement switch
    {
        _ when statement.Trim().IsSilence() => "Fine. Be that way!",
        _ when statement.Trim().IsQuestion() && statement.Trim().IsYell() => "Calm down, I know what I'm doing!",
        _ when statement.Trim().IsQuestion() => "Sure.",
        _ when statement.Trim().IsYell() => "Whoa, chill out!",
        _ => "Whatever.",
    };
    public static bool IsQuestion(this string statement) => statement.EndsWith('?');
    public static bool IsYell(this string statement) => statement.Any(char.IsLetter) && statement.ToUpper() == statement;
    public static bool IsSilence(this string statement) => string.IsNullOrWhiteSpace(statement);
}
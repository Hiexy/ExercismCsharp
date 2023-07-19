using System.Data;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (statement.IsSilence())
        {
            return "Fine. Be that way!";
        }

        if (statement.IsQuestion() && statement.IsYell())
        {
            return "Calm down, I know what I'm doing!";
        }

        if (statement.IsQuestion())
        {
            return "Sure.";
        }

        if (statement.IsYell())
        {
            return "Whoa, chill out!";
        }


        return "Whatever.";
    }

    public static bool IsQuestion(this string statement) => statement.EndsWith('?');
    public static bool IsYell(this string statement) => statement.Any(char.IsLetter) && statement.ToUpper() == statement;
    public static bool IsSilence(this string statement) => string.IsNullOrWhiteSpace(statement);
}
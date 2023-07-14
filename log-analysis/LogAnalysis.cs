using System;

public static class LogAnalysis
{

	/// <summary>
	/// Returns the substring after the first 
	/// instance of the delimiter provided.
	/// </summary>
	/// <param name="str"></param>
	/// <param name="delimiter"></param>
	/// <returns>substringAfter</returns>
	public static string SubstringAfter(this string str, string delimiter)
	{
		int startingIndex = str.IndexOf(delimiter) + delimiter.Length;
		return str.Substring(startingIndex);
	}

	/// <summary>
	/// Returns the substring between start
    /// and end strings.   
	/// </summary>
	/// <param name="str"></param>
	/// <param name="startStr"></param>
	/// <param name="endStr"></param>
	/// <returns>substringBetween</returns>
	public static string SubstringBetween(this string str, string startStr, string endStr)
	{
		int startingIndex = str.IndexOf(startStr) + startStr.Length;
		int endingIndex = str.IndexOf(endStr) - startingIndex;

		return str.Substring(startingIndex, endingIndex);

	}

	/// <summary>
	/// Returns the message part of the 
    /// log line.
	/// </summary>
	/// <param name="str"></param>
	/// <returns>logMessage</returns>
	public static string Message(this string str) => str.SubstringAfter(": ");

	/// <summary>
	/// Returns the log level part of 
    /// the log line.
	/// </summary>
	/// <param name="str"></param>
	/// <returns>logLevel</returns>
	public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}
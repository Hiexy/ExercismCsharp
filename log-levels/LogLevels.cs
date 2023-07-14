using System;
static class LogLine
{
	/// <summary>
	/// Returns the message content of the 
	/// Log Line.
	/// </summary>
	/// <param name="logLine"></param>
	/// <returns>logMessage</returns>
	public static string Message(string logLine)
	{
		var logLineArray = logLine.Split(':');
		if (logLineArray.Length >= 2)
		{
			return logLineArray[1].Trim();
		}
		return null;
	}
	/// <summary>
	/// Returns the lowercase log level
	/// of the Log Line.
	/// </summary>
	/// <param name="logLine"></param>
	/// <returns>logLevel</returns>
	public static string LogLevel(string logLine)
	{
		var logLineArray = logLine.Split(':');
		if (logLineArray.Length >= 2)
		{
			return logLineArray[0].Replace("[", string.Empty).Replace("]", string.Empty).ToLower();
		}
		return null;
	}
	/// <summary>
	/// Returns a new format of the Log Line.
	/// </summary>
	/// <param name="logLine"></param>
	/// <returns>newLogLine</returns>
	public static string Reformat(string logLine)
	{
		var logLineArray = logLine.Split(':');
        string message = null;
        string logLevel = null;
        if (logLineArray.Length >= 2)
		{
			message = logLineArray[1].Trim();
		    logLevel = logLineArray[0].Replace("[", string.Empty).Replace("]", string.Empty).ToLower();
		}
		return $"{message} ({logLevel})";
	}
}

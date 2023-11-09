using System;

public static class Gigasecond
{
    /// <summary>
    /// Add 1,000,000,000 seconds (1 Gigasecond) to the given moment.
    /// </summary>
    /// <param name="moment"></param>
    /// <returns>A new DateTime with 1,000,000,000 seconds added.</returns>
    public static DateTime Add(DateTime moment) => moment.AddSeconds(1e9);
}

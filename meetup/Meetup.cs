using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int _month;
    private int _year;

    public Meetup(int month, int year)
    {
        this._month = month;
        this._year = year;
    }

    /// <summary>
    /// Finds the first occurrence of a specific day of the week within a given range of days in the current month and year.
    /// </summary>
    /// <param name="dayOfWeek">The day of the week to find.</param>
    /// <param name="start">The start day of the range.</param>
    /// <param name="end">The end day of the range.</param>
    /// <returns>A DateTime representing the first occurrence of the specified day of the week within the range, or DateTime.MinValue if not found.</returns>
    private DateTime FindDay(DayOfWeek dayOfWeek, int start, int end)
    {
        DateTime result = DateTime.MinValue;

        for (var i = start; i <= end; i++) {
            var date = new DateTime(this._year, this._month, i);
            if (date.DayOfWeek == dayOfWeek) {
                result = date;
                break;
            }
        }

        return result;
    }

    /// <summary>
    /// Finds the date of a specific day of the week according to a given schedule in the current month and year.
    /// </summary>
    /// <param name="dayOfWeek">The day of the week to find.</param>
    /// <param name="schedule">The schedule (e.g., first, second, teenth, etc.) to use when finding the day.</param>
    /// <returns>A DateTime representing the date found according to the schedule, or throws an ArgumentException if the schedule is invalid.</returns>
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule) => schedule switch
    {
        Schedule.Teenth => FindDay(dayOfWeek, 13, 19),
        Schedule.First => FindDay(dayOfWeek, 1, 7),
        Schedule.Second => FindDay(dayOfWeek, 8, 14),
        Schedule.Third => FindDay(dayOfWeek, 15, 21),
        Schedule.Fourth => FindDay(dayOfWeek, 22, 28),
        Schedule.Last => FindDay(dayOfWeek, DateTime.DaysInMonth(_year, _month) - 6, DateTime.DaysInMonth(_year, _month)),
        _ => throw new ArgumentException()
    };
}

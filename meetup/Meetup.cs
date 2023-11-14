using System;

using Microsoft.VisualBasic;

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
    /// Calculates the date of a specific day of the week based on a given schedule within the current month and year.
    /// </summary>
    /// <param name="dayOfWeek">The day of the week to find.</param>
    /// <param name="schedule">The schedule (e.g., first, second, teenth, etc.) to use when finding the day.</param>
    /// <returns>A DateTime representing the date found according to the schedule.</returns>
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfWeek = new DateTime(this._year, this._month, schedule == Schedule.Teenth ? 13 :
                                                               schedule == Schedule.First ? 1 :
                                                               schedule == Schedule.Second ? 8 :
                                                               schedule == Schedule.Third ? 15 :
                                                               schedule == Schedule.Fourth ? 22 :
                                                               schedule == Schedule.Last ? DateTime.DaysInMonth(_year, _month) - 6 : 0);

        return firstDayOfWeek.AddDays((dayOfWeek - firstDayOfWeek.DayOfWeek + 7) % 7);
    }
}

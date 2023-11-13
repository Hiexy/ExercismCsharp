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

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime result = DateTime.MinValue;

        if (schedule == Schedule.First) {
            for (var i = 1; i <= 7; i++) {
                var date = new DateTime(this._year, this._month, i);
                if (date.DayOfWeek == dayOfWeek) {
                    result = date;
                    break;
                }
            }
        }

        if (schedule == Schedule.Second) {
            for (var i = 8; i <= 14; i++) {
                var date = new DateTime(this._year, this._month, i);
                if (date.DayOfWeek == dayOfWeek) {
                    result = date;
                    break;
                }
            }
        }

        if (schedule == Schedule.Third) {
            for (var i = 15; i <= 21; i++) {
                var date = new DateTime(this._year, this._month, i);
                if (date.DayOfWeek == dayOfWeek) {
                    result = date;
                    break;
                }
            }
        }

        if (schedule == Schedule.Fourth) {
            for (var i = 22; i <= 28; i++) {
                var date = new DateTime(this._year, this._month, i);
                if (date.DayOfWeek == dayOfWeek) {
                    result = date;
                    break;
                }
            }
        }

        if (schedule == Schedule.Last) {
            for (var i = DateTime.DaysInMonth(this._year, this._month); i >= 1; i--) {
                var date = new DateTime(this._year, this._month, i);
                if (date.DayOfWeek == dayOfWeek) {
                    result = date;
                    break;
                }
            }
        }

        if (schedule == Schedule.Teenth) {
            for (var i = 13; i <= 19; i++) {
                var date = new DateTime(this._year, this._month, i);
                if (date.DayOfWeek == dayOfWeek) {
                    result = date;
                    break;
                }
            }
        }

        return result;
    }
}

using System;
using System.Linq;
class BirdCount
{
    private int[] birdsPerDay;

    /// <summary>
    /// Initializes a new instance of the BirdCount class.
    /// </summary>
    /// <param name="birdsPerDay">An array of integers representing the count of birds per day.</param>
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    /// <summary>
    /// Returns an array representing the bird count for the last week.
    /// </summary>
    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    /// <summary>
    /// Returns the bird count for today.
    /// </summary>
    public int Today() => this.birdsPerDay[this.birdsPerDay.Length - 1];

    /// <summary>
    /// Increments the bird count for today.
    /// </summary>
    public void IncrementTodaysCount() => this.birdsPerDay[this.birdsPerDay.Length - 1]++;

    /// <summary>
    /// Checks if there is a day without birds.
    /// </summary>
    /// <returns>True if there is a day without birds, false otherwise.</returns>
    public bool HasDayWithoutBirds() => this.birdsPerDay.Any(birds => birds == 0);

    /// <summary>
    /// Returns the total bird count for the first n days.
    /// </summary>
    /// <param name="numberOfDays">The number of days to count.</param>
    /// <returns>The total bird count for the first n days.</returns>
    public int CountForFirstDays(int numberOfDays) => this.birdsPerDay.Take(numberOfDays).Sum();

    /// <summary>
    /// Returns the number of busy days (days with 5 or more birds).
    /// </summary>
    /// <returns>The number of busy days.</returns>
    public int BusyDays() => this.birdsPerDay.Count(birdsPerDay => birdsPerDay >= 5);
}

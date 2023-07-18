using System;

static class AssemblyLine
{
    private const int CarsProducedInOneHour = 221;

    /// <summary>
    /// Takes in the speed of the assembly line,
    /// and returns the success rate of creating 
    /// cars based on speed of the assembly line.
    /// </summary>
    /// <param name="speed"></param>
    /// <returns>successRate</returns>
    public static double SuccessRate(int speed) => speed switch {
        (10) => 0.77,
        (9) => 0.8,
        (<= 8) and (>= 5) => 0.9,
        (<= 4) and (>= 1) => 1.0,
        (0) => 0.0
    };

    /// <summary>
    /// Takes in the speed of the assembly line,
    /// and calculates the amount of cars produced in
    /// and hour.
    /// </summary>
    /// <param name="speed"></param>
    /// <returns>productionRatePerHour</returns>
    public static double ProductionRatePerHour(int speed) => speed * SuccessRate(speed) * CarsProducedInOneHour;

    /// <summary>
    /// Takes in the speed of the assembly line,
    /// and returns how many working cars are produced
    /// per minute.
    /// </summary>
    /// <param name="speed"></param>
    /// <returns>workingItemsPerMinute</returns>
    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}

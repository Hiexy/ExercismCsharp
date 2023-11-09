using System;

public class Player
{
    /// <summary>
    /// Rolls a six-sided die and returns the result.
    /// </summary>
    /// <returns>An integer between 1 and 18.</returns>
    public int RollDie()
    {
        Random random = new Random();
        return random.Next(1, 19);
    }

    /// <summary>
    /// Generates a random spell strength value.
    /// </summary>
    /// <returns>A double between 0 and 100.</returns>
    public double GenerateSpellStrength()
    {
        Random random = new Random();
        return random.NextDouble() * 100;
    }
}

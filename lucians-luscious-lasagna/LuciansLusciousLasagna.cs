class Lasagna
{
	private const int MINUTES_IN_OVEN = 40;
	private const int PREPARATION_MINUTES_PER_LAYER = 2;

	/// <summary>
	/// A method that returns the expected amount of
	/// minutes a lasagna is in the oven
	/// </summary>
	/// <returns>minutesInOven</returns>
	public int ExpectedMinutesInOven() =>  MINUTES_IN_OVEN;

	/// <summary>
	/// Takes in the amount of the minutes that a lasagna
	/// has spent in the oven, and return the remaining minutes
	/// needed for the lasagna based on the expected minutes
	/// in the oven value.
	/// </summary>
	/// <param name="minutesInOven"></param>
	/// <returns>remainingMinutes</returns>
	public int RemainingMinutesInOven(int minutesInOven) => this.ExpectedMinutesInOven() - minutesInOven;
	
    /// <summary>
    /// Takes in the amount of lasagna layers to be prepared
    /// and returns the total amount of time needed to prepare
    /// all lasagna layers
    /// </summary>
    /// <param name="amountOfLasagnaLayers"></param>
    /// <returns>totalPreperationTime</returns>
    public int PreparationTimeInMinutes(int amountOfLasagnaLayers) => amountOfLasagnaLayers * PREPARATION_MINUTES_PER_LAYER;

	/// <summary>
	/// Returns the total amount of time working on the lasagna
    /// based on the amount of lasagna layers and minutes spent cooking
	/// </summary>
	/// <param name="amountOfLasagnaLayers"></param>
	/// <param name="minutesInOven"></param>
	/// <returns>totalPreperationTime</returns>
    public int ElapsedTimeInMinutes(int amountOfLasagnaLayers, int minutesInOven) => this.PreparationTimeInMinutes(amountOfLasagnaLayers) + minutesInOven;
}

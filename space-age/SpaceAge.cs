using System;

public class SpaceAge
{
    int _seconds;
    const int EarthYearInSeconds = 31557600;
    const double MercuryYearInSeconds = 0.2408467 * EarthYearInSeconds;
    const double VenusYearInSeconds = 0.61519726 * EarthYearInSeconds;
    const double MarsYearInSeconds = 1.8808158 * EarthYearInSeconds;
    const double JupiterYearInSeconds = 11.862615 * EarthYearInSeconds;
    const double SaturnYearInSeconds = 29.447498 * EarthYearInSeconds;
    const double UranusYearInSeconds = 84.016846 * EarthYearInSeconds;
    const double NeptuneYearInSeconds = 164.79132 * EarthYearInSeconds;
    public SpaceAge(int seconds)
    {
        this._seconds = seconds;
    }

    public double OnEarth() => this._seconds / (double)EarthYearInSeconds;

    public double OnMercury() => this._seconds / MercuryYearInSeconds;

    public double OnVenus() => this._seconds / VenusYearInSeconds;

    public double OnMars() => this._seconds / MarsYearInSeconds;

    public double OnJupiter() => this._seconds / JupiterYearInSeconds;

    public double OnSaturn() => this._seconds / SaturnYearInSeconds;

    public double OnUranus() => this._seconds / UranusYearInSeconds;

    public double OnNeptune() => this._seconds / NeptuneYearInSeconds;
}

using System;

class RemoteControlCar
{
    private const int DriveDistance = 20;
    private const int BatteryDrain = 1;
    private const int EmptyBattery = 0;

    private int _distance = 0;
    private int _battery = 100;

    
    /// <summary>
    /// Factory method to create a new instance of RemoteControlCar.
    /// </summary>
    public static RemoteControlCar Buy() => new RemoteControlCar();


    /// <summary>
    /// Returns distance driven by the car.
    /// </summary>
    public string DistanceDisplay() => $"Driven {_distance} meters";

    /// <summary>
    /// Returns the battery level of the car.
    /// </summary>
    public string BatteryDisplay() => _battery == EmptyBattery ? "Battery empty" : $"Battery at {_battery}%";

    /// <summary>
    /// Drives the car, increasing the distance and decreasing the battery level.
    /// </summary>
    public void Drive()
    {
        if (_battery > EmptyBattery)
        {
            _distance += DriveDistance;
            _battery -= BatteryDrain;
        }
    }
}

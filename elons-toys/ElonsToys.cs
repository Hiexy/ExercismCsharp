using System;

class RemoteControlCar
{
    private const int DriveDistance = 20;
    private const int BatteryDrain = 1;
    private const int EmptyBattery = 0;

    private int _distance = 0;
    private int _battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distance} meters";

    public string BatteryDisplay() => _battery == EmptyBattery ? "Battery empty" : $"Battery at {_battery}%";

    public void Drive()
    {
        if (_battery > EmptyBattery)
        {
            _distance += DriveDistance;
            _battery -= BatteryDrain;
        }
    }
}

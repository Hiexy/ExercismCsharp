using System.Globalization;
using System;

class RemoteControlCar
{
    int _speed;
    int _batteryDrain;
    int _batteryLife;
    int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._distanceDriven = 0;
        this._batteryLife = 100;
    }

    public bool BatteryDrained() => this._batteryLife < this._batteryDrain;

    public int DistanceDriven() => this._distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained() && this._batteryLife >= this._batteryDrain)
        {
            this._distanceDriven += this._speed;
        }
        this._batteryLife -= this._batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    int _distance;

    public RaceTrack(int distance) => this._distance = distance; 

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() < this._distance)
        {
            car.Drive();
        }

        return car.DistanceDriven() >= this._distance;
    }
}


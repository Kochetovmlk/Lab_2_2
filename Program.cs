using System;

class Vehicle
{
    private double[] coordinates;
    public double[] Coordinates
    {
        get { return coordinates; }
        set { coordinates = value; }
    }

    public double Price { get; set; }
    public double Speed { get; set; }
    public int Year { get; set; }

    public Vehicle(double[] coordinates, double price, double speed, int year)
    {
        Coordinates = coordinates;
        Price = price;
        Speed = speed;
        Year = year;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Vehicle Information:");
        Console.WriteLine($"Coordinates: ({Coordinates[0]}, {Coordinates[1]})");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Speed: {Speed} km/h");
        Console.WriteLine($"Year: {Year}");
    }
}

class Plane : Vehicle
{
    public double Altitude { get; set; }
    public int Passengers { get; set; }

    public Plane(double[] coordinates, double price, double speed, int year, double altitude, int passengers)
        : base(coordinates, price, speed, year)
    {
        Altitude = altitude;
        Passengers = passengers;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Altitude: {Altitude} meters");
        Console.WriteLine($"Passenger Capacity: {Passengers} passengers");
    }
}

class Car : Vehicle
{
    public int Doors { get; set; }

    public Car(double[] coordinates, double price, double speed, int year, int doors)
        : base(coordinates, price, speed, year)
    {
        Doors = doors;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Number of Doors: {Doors}");
    }
}

class Ship : Vehicle
{
    public int Passengers { get; set; }
    public string PortOfRegistry { get; set; }

    public Ship(double[] coordinates, double price, double speed, int year, int passengers, string portOfRegistry)
        : base(coordinates, price, speed, year)
    {
        Passengers = passengers;
        PortOfRegistry = portOfRegistry;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Passenger Capacity: {Passengers} passengers");
        Console.WriteLine($"Port of Registry: {PortOfRegistry}");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle(new double[] { 0, 0 }, 20000, 120, 2022);
        Plane plane = new Plane(new double[] { 10, 20 }, 5000000, 900, 2020, 11000, 250);
        Car car = new Car(new double[] { -5, 15 }, 30000, 180, 2021, 4);
        Ship ship = new Ship(new double[] { 30, 50 }, 10000000, 40, 2019, 1000, "New York");

        vehicle1.ShowInfo();
        Console.WriteLine();
        plane.ShowInfo();
        Console.WriteLine();
        car.ShowInfo();
        Console.WriteLine();
        ship.ShowInfo();
    }
}
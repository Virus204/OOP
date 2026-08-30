using System.Reflection.Metadata.Ecma335;

Car car1 = new Car("Ford", "Mustang", 2022, "red");
Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
car1.drive();
car2.drive();
car1.MakeHornSound(); 
car1.Accelerate(20); 
car1.ShowCurrentSpeed(); 
System.Console.WriteLine(Car.NumberOfCars);
Car.StartRace();


public abstract class Vehicle
{
    protected int speed = 0;

    public void go()
    {
        System.Console.WriteLine("This Vehicle is moving !!");
    }
    public abstract void MakeHornSound();
}
class Car : Vehicle
{
    string make;
    string model;
    int year;
    string color;
    public static int NumberOfCars;

    public Car (string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
        NumberOfCars++;
    }
    public void drive()
    {
        System.Console.WriteLine($"you drive the {make} {model}");
    }
    public static void StartRace()
    {
        System.Console.WriteLine("the Race has begun !");
    }
    public void Accelerate(int amount)
    {
        speed += amount; 
        Console.WriteLine($"{make} accelerated by {amount} km/h.");
    }
    public override void MakeHornSound()
    {
        System.Console.WriteLine($"The {make} goes : Beep Beep!");
    }
     public void ShowCurrentSpeed()
    {
        Console.WriteLine($"The current speed of the {model} is {speed} km/h.");
    }
}

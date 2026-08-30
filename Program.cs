Car car1 = new Car("Ford", "Mustang", 2022, "red");
Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
car1.drive();
car2.drive();
System.Console.WriteLine(Car.NumberOfCars);
Car.StartRace();

class Car
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
}

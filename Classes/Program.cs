namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myTruck = new Car();
            myTruck.Make = "Toyota";
            myTruck.Model = "Tacoma";
            myTruck.Year = 2022;
            Console.WriteLine($"Make: {myTruck.Make} \nModel: {myTruck.Model} \nYear: {myTruck.Year}");
        }
    }
}

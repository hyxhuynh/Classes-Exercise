namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car dreamCar = new Car("Lamborghini","Revuelto",2024);

            Console.WriteLine(dreamCar.Make);
            Console.WriteLine(dreamCar.Model);
            Console.WriteLine(dreamCar.Year);

        }
    }
}

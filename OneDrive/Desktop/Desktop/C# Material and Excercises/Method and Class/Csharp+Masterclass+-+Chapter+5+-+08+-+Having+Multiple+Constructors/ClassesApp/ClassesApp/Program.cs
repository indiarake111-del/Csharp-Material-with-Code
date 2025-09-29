namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("FrankTheTank", "Mainstreet 1", "5551234567");
            Console.WriteLine("Name of Customer is " + earl.Name);
            Console.WriteLine("Adress of the Customer is" + frankTheTank.Address);


            Console.ReadKey();
        }
    }
}

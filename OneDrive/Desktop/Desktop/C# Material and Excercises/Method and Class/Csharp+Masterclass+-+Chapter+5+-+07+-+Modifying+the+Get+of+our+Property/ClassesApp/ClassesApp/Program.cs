namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Creating an object of the Class Car
            // Creating an instance of the Class Car
            Car audi = new Car("A3" , "Audi", false);
            Car bmw = new Car("i7", "BMW", true);


            // GETTING BRAND
            Console.WriteLine("Brand is " +  audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);


            Console.ReadKey();
        }
    }
}

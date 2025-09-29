using System.ComponentModel;

namespace ClassesApp
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Car myAudi = new Car("A3", "Audi", true);
            myAudi.Drive();

            Car myBmw = new Car("i7", "BMW", true);
            myBmw.Drive();

            Console.WriteLine();


            Customer rake = new Customer("rake");
            Customer roni = new Customer("roni", "Ratilo", "12345678");
    
            Customer myCustomer = new Customer();
            //Console.WriteLine("Please enter the Customer Name");
            //myCustomer.Name = Console.ReadLine();

            myCustomer.setDetails("rake", "RRR", "13548");
            //Console.WriteLine("Details about the Customer:"+ myCustomer.Name);
            Console.WriteLine("MyCustomer is:" + myCustomer.Name + "and he lives in" + myCustomer.Address); ;
            Console.WriteLine("rake is:" + rake.Name + "and he lives in" + rake.Address);
            Console.ReadKey();
        }
    }
}
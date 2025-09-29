using System.Xml.Linq;

namespace ClassCreate
{
    class Program()
    {
        static void Main(String[] args)
        {
            Car audi = new Car("A7", "White", true);
            audi.Drive();

            Car bmw = new Car("B7", "Black", false);
            bmw.Drive();

            //Console.WriteLine("Please enter the Color Name");

            //Console.WriteLine( "Color is" + audi.Color);
            //Console.WriteLine("Color is" + bmw.Color);


            //Customer rakesh = new Customer("Rakesh", "Bhatabandha", "8458029601");

            //Console.WriteLine("The Customer is" + rakesh.Name + "and their house is in the village of:" 
            //    + rakesh.Address + "and the contact number is:" + rakesh.ContactNumber);


            //audi.Color = "red";
            //Console.WriteLine("The color is" + audi.Color);
            //Console.WriteLine("The brand is" + bmw._brand);
            //Console.WriteLine("The brand is" + audi._color); its inaccessible due to its protection means its private property.



            //Customer rake = new Customer();
            //Console.WriteLine("Please enter the customer Name:");
            //rake.Name = Console.ReadLine();
            //Console.WriteLine("Details of the Customer is" + rake.Name);

            //Customer MyCustomer = new Customer();
            //MyCustomer.setDetails("Roni", "Ratilo", "86987452");

            //Console.WriteLine("My Customer name is"+ MyCustomer.Name + " He lives in" + MyCustomer.Address);

            Console.ReadKey();
        }
    }
}

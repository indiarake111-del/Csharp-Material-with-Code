using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
        
    internal class Car
    {
        private string model="";
        private string brand="";
        private bool isluxury;

        //Property
        public string Model { get => model; set => model = value; }

        public string Brand
        {
            get
               {
                if(isluxury)
                {
                    return brand + "_Luxury Edition";
                }
                else
                {
                    return brand;
                }
            
            }
                
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing");
                    brand = "DefaultValue";
                }
                else
                {
                    brand = value;
                }
            }

        }

        public bool Isluxury { get => isluxury; set => isluxury = value;}
        public Car (string model, string brand, bool isluxury)
        {
            
            this.Model = model;
            this.Brand = brand;
            Console.WriteLine($"The {brand} of the" + $"model {model} Has been created");
            this.Isluxury = isluxury;

           public void Drive()
            {
            Console.WriteLine($"I'm a {Model} and I'm driving {Brand}");
        }

            
        }
    }
       

}

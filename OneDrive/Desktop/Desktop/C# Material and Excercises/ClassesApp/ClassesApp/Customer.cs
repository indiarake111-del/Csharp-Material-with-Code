using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set;}
        public string Address { get; set; }
        public string ContactNumber { get; set; }


        //Default Constructor

        public Customer()
        {
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }
        //Custome constructor
        public Customer (string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            Name = name;
            Address = "Unknown";          
            ContactNumber = "None";
        }

        public void setDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
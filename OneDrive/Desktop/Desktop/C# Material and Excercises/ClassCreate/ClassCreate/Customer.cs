namespace ClassCreate
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set;}



public Customer()
        {
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }

// Custom Customer Constructor
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void setDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
                   
    }
}

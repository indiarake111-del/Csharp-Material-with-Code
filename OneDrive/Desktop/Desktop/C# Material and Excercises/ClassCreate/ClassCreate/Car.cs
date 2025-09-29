namespace ClassCreate
{
    internal class Car
    {
        private string _brand;
        private string _color;
        private bool _isLuxury;

        public string Brand { get => _brand; set => _brand = value; }
        
        public string Color {

            get
            {
                if (_isLuxury)
                {
                    return _color + "Luxury Edition";
                }
                else
                {
                    return _color;
                }
            }
                    set {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("You Entered Nothing");
                        _color = "DEFAULTVALUE";
                    }
                    else
                    {
                        _color = value;
                    }
                }
            }   


        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value;}

        public Car(string brand, string color, bool IsLuxury)
        {
            _brand = brand;
            _color = color;
            Console.WriteLine($"Car of {_brand}" + $"which color is {_color} has been created");
            _isLuxury = IsLuxury;
        }

        public void Drive()
        {
            Console.WriteLine($"I am a {Brand} and I am driving");
        }
        
    }
}

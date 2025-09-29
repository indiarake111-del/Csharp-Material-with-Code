namespace WeatherSimulator
{
    class Weather
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the days you want to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cludy", "Rainy", "Snowy" };
            string[] WeatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                WeatherConditions[i] = conditions[random.Next(conditions.Length)];
                //random.Next(conditions.Length):
                //This returns a random index from 0 to conditions.Length - 1.
                //Since there are 4 elements, conditions.Length is 4, so this gives a number like 0, 1, 2, or 3
                //conditions[random.Next(conditions.Length)]:
                //This uses that random index to pick one value from the conditions array.
                //So if random.Next(4) gives 2, it becomes: conditions[2] => "Rainy"
            }
            double average = CalculateAverage(temperature);
            Console.WriteLine($"Average Temperature: {average}");
        }
            static double CalculateAverage(int[] temperature)
            {
                int sum = 0;
                for (int i=0; i < temperature.Length;i++)
                {
                    sum += temperature[i];
                }
                double average = sum / (double)temperature.Length;
                return average;
            }


        }
    }
namespace WeatherStimulator
{
    class Weather
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            double averageTemp = CalculateAverage(temperature);
            Console.WriteLine($"Average Temperature: {averageTemp}");

            int Mt = MinTemperature(temperature);
            Console.WriteLine($"MinTemperature: {Mt}");
            //Console.WriteLine($"Min Temperature: {temperature.Min()}");

            int Mx = MaxTemperature(temperature);
            Console.WriteLine($"MaxTemperature: {Mx}");
            //Console.WriteLine($"Max Temperature: {temperature.Max()}");

            Console.WriteLine($"Most Common Temperature:{MostCommonCondition(weatherConditions)}");
            Console.ReadKey();
        }

        static double CalculateAverage(int[] temperature)
        {
            int sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }
            double average = sum / (double)temperature.Length;
            return average;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];
            foreach (int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }
        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];
            foreach (int temp in temperature)
            {
                if (temp > max)
                {
                    max = temp;
                }
            }
            return max;
        }
            static string MostCommonCondition(string[] conditions)
            {
                int count = 0;
                string mostCommon = conditions[0];

                for (int i = 0; i < conditions.Length; i++)
                {
                    int tempCount = 0;
                    for (int j = 0; j < conditions.Length; j++)
                    {
                        if (tempCount > count)
                        {
                            count = tempCount;
                            mostCommon = conditions[i];
                        }
                    }

                }
                
            return mostCommon;
                }

        }
    }


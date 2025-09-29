namespace AddFunctionInMethod
{
    class Method
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Write a number from 1 to 10");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int MyResult = AddTwoValues(num1, num2);
            //int MyResult = SubstractTwoValues(num1, num2);

            Console.WriteLine("The Addition result will be:" + MyResult);
            Console.WriteLine("The Substraction result will be:" + MyResult);
        }
        int myResult;
            static int AddTwoValues(int value1, int value2)
            {
                int MyResult = value1 + value2;
                return MyResult;
            }

            static int SubstractTwoValues(int value1, int value2)
            {
                int MyResult = value1 - value2;
                return MyResult;
            }

           
        }
    }


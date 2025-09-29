Random random = new Random();

int secretNumber = random.Next(1, 101); 
int counter = 0;
int Guess = 0;

Console.WriteLine("Guess a Number Between 1 to 100");

while (Guess != secretNumber)
{
    counter++;
    Console.WriteLine("Write your guess:");
    Guess = int.Parse(Console.ReadLine());
    if (Guess < secretNumber)
    {
        Console.WriteLine("This number is too small! try again");
    }
    else if (Guess > secretNumber)
    {
        Console.WriteLine("Too high number:try again");
    }
    else
    {
        Console.WriteLine("Congratulations!You guess the right number! it took you" + counter + "tries!");
    }
}
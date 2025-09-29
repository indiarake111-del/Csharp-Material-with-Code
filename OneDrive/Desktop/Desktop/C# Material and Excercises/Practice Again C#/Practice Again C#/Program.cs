Console.WriteLine("Welcome to the game");
Console.WriteLine("Enter your players name");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type (Warrior, Wizard, Archer");
string playerType = Console.ReadLine();
Console.WriteLine($"you {playerName} enter into the game with the playertype {playerType} and find yourself in a dark forest");
Console.WriteLine("Do you want enter into the forest Enter/Outside of the forest");

string choice1 = Console.ReadLine();
if (choice1.ToLower()== "enter") 
{
    Console.WriteLine("You bravely enter into the forest");
}else
{
    Console.WriteLine("You decide camp out and wait for daylight");
}
bool gameContinues = true;
while (gameContinues)
{
    Console.WriteLine("You come to fork in a road. Go left or right?");
    string direction = Console.ReadLine();
    if(direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasrer cheast");
        gameContinues = false;
    }
    else
    {cw
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine();

        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a treasurer");
                }
            }
            else
            {
                Console.WriteLine("The beast attacked you where you did n't expect it!");
                Console.WriteLine("It rammed it's tusks into your chest and you bleed ");
                gameContinues = false;
            }
            }

        }
    }
Console.WriteLine("Game Over!");
Console.WriteLine("Thank you for playing the game!");

Console.ReadKey();





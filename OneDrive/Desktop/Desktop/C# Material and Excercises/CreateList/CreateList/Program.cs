using System.Drawing;

class ListApp
{
    static void Main(string[] args)
    {
        List<string> colors =
            // This method also worked in List 
            [
                "Red",
                "Maroon",
                "Black",
                "White"
            ];

        //colors.Add("Red");
        //colors.Add("Blue");
        //colors.Add("Green");
        //colors.Add("Red");

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine("Color Remove List");
        bool isDeletingSuccefull = colors.Remove("Red");
        while(isDeletingSuccefull)
        {
            isDeletingSuccefull = colors.Remove("Red");
        }

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
    }
}

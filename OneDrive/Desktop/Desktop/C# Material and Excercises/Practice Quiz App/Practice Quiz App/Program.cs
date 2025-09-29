using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practice_Quiz_App
{
    class Program
    {
        public static void Main(string[] args)
        {

            Question[] questions = new Question[]
            {
                new Question ("What is the capital of India", 
                new string[] {"Delhi", "Cuttack", "Karnataka", "Banglore"},
                0
                ),
                 new Question ("2+2",
                new string[] {"5", "4", "8", "9"},
                1
                )
             };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();

        }

    }
}

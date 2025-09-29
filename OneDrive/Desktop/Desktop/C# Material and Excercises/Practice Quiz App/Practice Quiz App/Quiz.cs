using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Quiz_App
{
    class Quiz
    {
        private Question[] questions;
        private int _score;
  
        public Quiz(Question[] questions)
        {
            this.questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;

            foreach(Question question in questions)
            {
                Console.WriteLine($"Question Number {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if(question.IscorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults();
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            double percentage = (double)_score / questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor();
        }

        public void DisplayQuestion(Question question)
        {
            Console.WriteLine("Question");
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.Write("  ");
                Console.Write(i + 1);
                Console.WriteLine($".{question.Answers[i]}");
            }
            //if (GetUserChoice() == question.CorrectAnswerIndex)
            //{
            //    Console.WriteLine("Correct");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect");
            //}

        }
                private int GetUserChoice()
                {
                    Console.WriteLine("Enter your choice(1-4):");
                    string input = Console.ReadLine();
                    int choice = 0;
                    while (!int.TryParse(input, out choice) || choice > 4 || choice < 1)
                    {
                        Console.WriteLine("Please enter a valid number 1 to 4");
                        input = Console.ReadLine();
                    }
                    return choice - 1;
                }

       }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp_Practice_Again
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;
  
    public Quiz (Question[] questions)
        {
            _questions = questions;
            _score = 0;
         }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz App!");
            int QuestionNumber = 1;
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question: {QuestionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }


            }

        }

        public void DisplayQuestion(Question question)
        {
         Console.WriteLine (question.QuestionText);

        for (int i = 0; i < question.Answers.Length;i++)
            {
                Console.Write("   ");
                Console.Write(i + 1);
                Console.WriteLine($".{question.Answers[i]}");
            }
        }

        public int GetUserChoice()
        {
            Console.WriteLine("Your answer is:");
            string input = Console.ReadLine();
            int choice = 0;

            while  (!int.TryParse (input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                input = Console.ReadLine();
            }
            return choice -1;

        }
    }


}

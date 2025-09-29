namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?",  // Question Text
                    new string[] {"Paris", "Berlin", "London", "Madrid"}, // Answers Array
                    1 // CorrectAnswerIndex
                )
            };


            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion(questions[0]);
            Console.ReadLine();
        }
    }
}

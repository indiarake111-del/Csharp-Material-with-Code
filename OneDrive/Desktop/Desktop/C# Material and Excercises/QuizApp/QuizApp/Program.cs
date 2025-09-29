namespace QuizApp
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Question[] questions = new Question[]
            {
            new Question(
                "What is the capital of India?",
            new string[] { "Delhi", "Cuttack", "UP", "Bombay" },
            0
       ),
             new Question(
                "What is the sum of: 2+ 2?",
            new string[] { "5", "4", "3", "2" },
            1
       ),
             new Question(
                "What is the sum of: 2+ 3?",
            new string[] { "5", "4", "3", "2" },
            0
       ),

            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();


         }   
    }
}

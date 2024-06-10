using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster
{
    public static class Quiz
    {
        public static void StartQuiz()
        {
            //list of questions and answers 
            List<string> questionsAndAnswers = new List<string>
{
    "What is the capital of France?",
    "Paris",
    "What is the largest planet in our solar system?",
    "Jupiter",
    "Who wrote 'To Kill a Mockingbird'?",
    "Harper Lee",
    "What is the chemical symbol for water?",
    "H2O",
    "What year did the first man land on the moon?",//8
    "1969",
    "What is the smallest prime number?",//10
    "2",
    "Who painted the Mona Lisa?",
    "da Vinci",
    "What is the longest river in the world?",
    "Nile",
    "What is the tallest mountain in the world?",
    "Mount Everest",
    "What is the main ingredient in traditional Japanese miso soup?",
    "Miso paste"
};
      //counter to store score
            int count = 0;


            //looping through the questions and answers
            for (int i = 0; i < questionsAndAnswers.Count; i += 2)
            {
                Console.WriteLine(questionsAndAnswers[i]);
                String user_answer = Console.ReadLine();
                String answer = questionsAndAnswers[i + 1];
                if (!String.IsNullOrEmpty(user_answer))
                {
                    if (user_answer.ToLower() == answer.ToLower())
                    {
                        count++;
                        Console.WriteLine("Your answer is correct :) good job!");
                    }

                    else
                    {
                        
                        Console.WriteLine("Wrong Answer :(");
                    }

                }
                else{
                    Console.WriteLine("invalid input :/ please try again!");
                    i -=2;
                }   }
            Console.WriteLine($"You scored {count} out of {questionsAndAnswers.Count}");
        }
    }
}

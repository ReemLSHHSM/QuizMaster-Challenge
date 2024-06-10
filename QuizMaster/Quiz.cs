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
    "What is the capital of Germany?",
    "Berlin",
    "What is the capital of Italy?",
    "Rome",
    "What is the capital of Japan?",
    "Tokyo",
    "What is the capital of Canada?",
    "Ottawa",
    "What is the capital of Australia?",
    "Canberra",
    "What is the capital of Brazil?",
    "Brasilia",
    "What is the capital of India?",
    "New Delhi",
    "What is the capital of Russia?",
    "Moscow",
    "What is the capital of Egypt?",
    "Cairo"
};

            //counter to store score
            int count = 0;

            Console.WriteLine("Welcome to QuizMaster, please answer the questions below. good luck!");
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
                }
                
            }
            Console.WriteLine($"You scored {count} out of {questionsAndAnswers.Count}");

        }
    }
}

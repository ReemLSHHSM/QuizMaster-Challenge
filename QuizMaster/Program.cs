namespace QuizMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Quiz.StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

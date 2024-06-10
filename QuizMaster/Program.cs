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
            finally
            {
                Console.WriteLine("Thanks for using QuizMaster see you next time ;)");
            }


        }
    }
}

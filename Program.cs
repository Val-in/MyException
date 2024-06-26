using static MyException.Program;

namespace MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
                {
                new InvalidOperationException("Invalid operation occurred."),
                new FormatException("Invalid format."),
                new ArgumentOutOfRangeException("Argument out of range."),
                new DriveNotFoundException("Drive not found."),
                new MyException("This is my custom exception.")
                };

            foreach (Exception exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("Finally block executed.");
                }
            }
        }

        public class MyException : Exception
        {
            public MyException(string message) : base(message) { }
        }
    }
}

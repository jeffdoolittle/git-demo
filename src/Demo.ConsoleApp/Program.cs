namespace Demo.ConsoleApp
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Hello World!");
        }
    }
}

namespace Events
{
    using System;
    using System.Text;
    using Contracts;
    using Core;
    using Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var reader = new ConsoleReader();
            bool commandSuccess = Engine.ExecuteNextCommand(reader);

            while (commandSuccess)
            {
                commandSuccess = Engine.ExecuteNextCommand(reader);
            }

            Console.WriteLine(Messages.Output);
        }
    }
}

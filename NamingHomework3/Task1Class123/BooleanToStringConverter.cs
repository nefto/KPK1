namespace Task1Class123
{
    using System;

    public class BooleanToStringDisplayer
    {
        private const int MaxCount = 6;

        public static void DisplayAsString()
        {
            var printer = new BooleanValuePrinter();

            printer.PrintBoolean(true);
        }

        internal class BooleanValuePrinter
        {
            internal void PrintBoolean(bool input)
            {
                string inputAsString = input.ToString();

                Console.WriteLine(inputAsString);
            }
        }
    }
}

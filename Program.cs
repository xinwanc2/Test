using Test;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("Roman Numeral Converter\r");
        Console.WriteLine("------------------------\n");

        while (endApp is false)
        {

            Console.Write("Type a number or roman numeral, and then press Enter: ");
            string inputValue = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(inputValue))
            {
                Console.WriteLine("Please key in valid input");
                endApp = true;
            }

            try
            {
                if (Int32.TryParse(inputValue, out int number1))
                {
                    string result = RomanIntervalConverter.NumToRoman(number1);
                    Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                else
                {
                    int result = RomanIntervalConverter.RomanToNum(inputValue);
                    Console.WriteLine("Your result: {0:0.##}\n", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}

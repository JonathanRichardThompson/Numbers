using NumberingConsoleApp.CheckDigitVerifier;
using NumberingConsoleApp.NumberGenerator;

namespace NumberingConsoleApp
{
    public static class SelectApplicationOptionsMenu
    {

        public static void SelectApplication()
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Enter number to select application from options below and press Enter");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("1: Check Digit Verifier\n2: Number Generator\n");

                string userSelection1 = Console.ReadLine();
                if (userSelection1 == "1")
                {
                    CheckDigitVerifierOptionsMenu.CheckDigitVerifierOptions();
                    break;
                }
                else if (userSelection1 == "2")
                {
                    NumberGeneratorOptionsMenu.NumberGeneratorOptions();
                    break;
                }

                else
                    Console.WriteLine("Invalid selection. Please select from one of the options");
            }
        }
    }
}
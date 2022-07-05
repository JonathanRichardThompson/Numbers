namespace NumberingConsoleApp.CheckDigitVerifier
{
    internal static class EnterNumber
    {
        public static void UserInput(string userSelection1)
        {
            bool exitLoop = false;
            while (!exitLoop)
            {
                Console.WriteLine("Enter number and press Enter");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    Console.WriteLine("Goodbye");
                    exitLoop = true;
                }


                try
                    {
                        int number = Convert.ToInt32(userInput);
                        Console.WriteLine(MOD97Calculator.MOD97Calculation(number));
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to convert new number or Q followed by Enter to quit");
                        string userInput2 = Console.ReadLine();
                        if (userInput2.ToLower() == "q")
                        {
                            Console.WriteLine("Goodbye");
                            exitLoop = true;
                        }
                        else
                        {
                            exitLoop = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Incorrect Number Format, try again.\n  Error {e}\n");
                    }
                
            }

        }
    }
}
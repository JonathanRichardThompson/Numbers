namespace NumberingConsoleApp.CheckDigitVerifier
{
    public static class CheckDigitVerifierOptionsMenu
    {

        public static void CheckDigitVerifierOptions()
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Enter number to select from options below and press Enter");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("1: MOD97 Verifier\n2: MOD10 Verifier\n");

                string userSelection1 = Console.ReadLine();
                try
                {
                    EnterNumber.UserInput(userSelection1);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid selection. Please select from one of the options");
                }
                                  
            }
        }
    }

}
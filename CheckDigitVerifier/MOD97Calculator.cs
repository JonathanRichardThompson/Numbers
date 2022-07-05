namespace NumberingConsoleApp.CheckDigitVerifier
{
    internal static class MOD97Calculator
    {
        public static string MOD97Calculation(int userInput)
        {
            int number = Convert.ToInt32(userInput);
            int remainder = number % 97;
            int divisor = (97 - remainder);
            return divisor.ToString("D2");

        }
    }
}
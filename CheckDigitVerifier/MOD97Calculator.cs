namespace NumberingConsoleApp.CheckDigitVerifier
{
    public static class MOD97Calculator
    {
        public static string MOD97Calculation(int userInput)
        {
            int number = Convert.ToInt32(userInput);
            int remainder = number % 97;
            int divisor = (97 - remainder);
            return remainder.ToString("D2");

        }
    }
}
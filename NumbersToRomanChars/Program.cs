namespace NumbersToRomanChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Numbers to convert to Roman characters
            // you could try to find for various different numbers
            // in the range from 1 to 3999 
            int[] numbers = { 10, 19, 159, 763, 1991, 1979, 1997, 2002 };

            foreach (var num in numbers)
            {
                string toRoman = IntsToRoman(num);
                Console.WriteLine($"{num} to roman character is {toRoman}");
            }
        }
        public static string IntsToRoman(int number)
        {
            string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] romanValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            if (number <= 0 || number > 3999)
            {
                return "Number is not in range";
            }

            int index = 0;
            string roman = "";
            while (number > 0)
            {
                if (number - romanValues[index] >= 0)
                {
                    roman += romanSymbols[index];
                    number -= romanValues[index];
                }
                else
                {
                    index++;
                }
            }
            return roman;
        }
    }
}
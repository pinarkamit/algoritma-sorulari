using System.Text.RegularExpressions;

namespace Odev1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int[] arr = new int[1];
            EnterMultiplePositiveIntegers(ref arr, 1);
            int n = arr[0];
            Console.WriteLine("Enter words " + n + " times: ");
            string[] arrN = new string[n];
            EnterMultipleWords(ref arrN, n);
            for (int i = arrN.Length-1; i >=0 ; i--)
            {
                Console.Write(arrN[i] + " ");
            }
        }

        private static void EnterMultipleWords(ref string[] arr2, int length)
        {
            for (int i = 0; i < length; i++)
            {
                string? str = Console.ReadLine();
                if (!EnteredStringHasOnlyLetters(str))
                {
                    Console.WriteLine("You must enter only letters not numeric values: ");
                    i--;
                    continue;
                }
                arr2[i] = str;
            }
        }

        private static bool EnteredStringHasOnlyLetters(string str)
        {
            //^\p{L}+$ or ^[a-zA-ZiİçÇşŞğĞÜüÖö] both English and Turkish chars
            //@"^[a-zA-Z]+$" only English
            return Regex.IsMatch(str, @"^[a-zA-ZiİçÇşŞğĞÜüÖö]*$");
        }

        private static void EnterMultiplePositiveIntegers(ref int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                int res = EnterInteger();
                if (res <= 0)
                {
                    Console.WriteLine("You must enter positive values: ");
                    i--;
                    continue;
                }
                arr[i] = res;
            }
        }

        private static int EnterInteger()
        {
            int outNumber = 0;
            string? str = Console.ReadLine();
            bool isInteger = Int32.TryParse(str, out outNumber);
            int n = 0;
            if (isInteger)
            {
                n = Convert.ToInt32(str?.Trim());
            }
            return n;
        }
    }
}
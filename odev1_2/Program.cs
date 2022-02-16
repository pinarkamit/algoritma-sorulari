namespace Odev1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two positive numbers: ");
            int[] arr2 = new int[2];
            EnterMultiplePositiveIntegers(ref arr2, 2);
            int n = arr2[0];
            int m = arr2[1];
            Console.WriteLine("Enter positive numbers " + n + " times: ");
            int[] arrN = new int[n];
            EnterMultiplePositiveIntegers(ref arrN, n);
            for (int i = 0; i < arrN.Length; i++)
            {
                if (arrN[i] % m == 0)
                    Console.Write(arrN[i] + " ");
            }
        }

        private static void EnterMultiplePositiveIntegers(ref int[] arr2, int length)
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
                arr2[i] = res;
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
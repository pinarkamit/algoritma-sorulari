namespace Odev1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int n = EnterInteger();
            Console.WriteLine("Enter positive numbers " + n + " times: ");
            int[] arr  = new int[n];
            for(int i = 0; i<n; i++)
            {
                int res = EnterInteger();
                if(res <= 0)
                {
                  Console.WriteLine("You must enter positive values: ");  
                  i--;
                  continue;
                }
                arr[i] = res;
            }
            for(int i = 0; i<arr.Length; i++)
            {  
                if(arr[i] % 2 == 0)           
                    Console.Write(arr[i] + " ");
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
using System.Text.RegularExpressions;

namespace Odev1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string? sentence = Console.ReadLine();
            string[] words = new string[sentence.Length];
            words = sentence.Split(" ");
            Console.WriteLine("Total word count in sentence: " + words.Length);
            string sentenceNonSpace = sentence.Trim().Replace(" ", "");
            Console.WriteLine("Total char coutn in sentence: " +sentenceNonSpace.Length);
        }
    }
}
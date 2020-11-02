using System;
using System.Threading;

namespace JankyDebugOutputRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new Random();

            // log every 1/2 second
            while (true) {
                var message = GetRandomMessage(rng);
                Console.WriteLine($"\t {DateTime.Now.ToLongTimeString()} New log message: " + message);
                Thread.Sleep(500);
            }
        }

        static string GetRandomMessage(Random rng)
        {
            var wordCount = rng.Next(5, 75);
            var message = "";

            for (var i = 0; i < wordCount; i++) message += GetRandomWord(rng) + " ";

            return message;
        }

        static string GetRandomWord(Random rng)
        {
            var charCount = rng.Next(3, 8);
            var word = "";

            for (var i = 0; i < charCount; i++) word += (char) rng.Next(65,90);

            return word;
        }
    }
}

using System;

namespace VociTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> terms = new List<string>()
            {
                "unschuldig",
                "Strafe",
                "Moderator*In",
                "beraten",
                "etw. begehen"
            };
            List<string> definitions = new List<string>()
            {
                "innocent",
                "punishment",
                "presenter",
                "advise",
                "commit"
            };

            int punkte = 0;

            for(int i  = 0; i < terms.Count; i++)
            {
                Console.WriteLine($"Was bedeutet {terms[i]}");
                string input = Console.ReadLine().ToLower().Trim();

                if(input == definitions[i])
                {
                    Console.WriteLine("Korrekt!");
                    punkte++;
                }
                else
                {
                    Console.WriteLine("Leider falsch");
                    Console.WriteLine($"Richtig ist: {definitions[i]}");
                }
            }

            Console.WriteLine($"Du hast {punkte} von {terms.Count} korrekt gelöst");
        }
    }
}
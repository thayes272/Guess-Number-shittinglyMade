using System;

namespace numberGuessingShitttttttttttt
{
    class Program
    {

        static void Main(string[] args)
        {
            // values stuff idk man fuck stop wondering shit
            Random rand = new Random();
            int number = rand.Next(0, 100);
            bool win = false;


            Console.WriteLine("Guess the number you fucking retard!");
            while (win == false)
            {
                Console.WriteLine("Guess number");
                string s = Console.ReadLine();
                int num = int.Parse(s);

                //check if number is equal to random number EDIT: yeah you fucking tard
                if(num > 100)
                {
                    WriteLine("wow your a fucking retard its between 1 - 100 asshole");
                }
                else if (num > number)
                {
                    WriteLine("too high!");
                    WriteLine("(DEBUG) Number is: " + number.ToString());
                }
                else if (num < number)
                {
                    WriteLine("too low!");
                    WriteLine("(DEBUG) Number is: " + number.ToString());
                }
                else
                {
                    WriteLine("woohoo");
                    win = true;
                }
            }
        }

        // so i dont having to fucking write console.clear() FUCICKKCKCKC
        public static void clear()
        {
            Console.Clear(); // <--- fuck this bullshit
        }

        public static void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
        public static void Write(string input)
        {
            Console.Write(input);
        }
    }
}

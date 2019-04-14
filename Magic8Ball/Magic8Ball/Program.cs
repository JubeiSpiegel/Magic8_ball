using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{

    class Program
    {
        static void Main(string[] args)
        {
            //Main method really clear, all taken from class and external methods
            MainApp();
            Console.ReadLine();
        }

        //function created to do the first iteration and trip to the class if positive
        public static void MainApp()
        {
            char charChoice;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************************");
            Console.WriteLine("Welcome to our MAGIC 8 BALL APP");
            Console.WriteLine("********************************");
            Console.WriteLine("");
            Console.Write("Do you want to play? [Y/N]: ");
            charChoice = char.Parse(Console.ReadLine().ToUpper());
            Console.Clear();
            if (charChoice == 'Y')
            {
                Answers.AnswersMethod();
            }
            else if (charChoice == 'N')
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("*************************");
                Console.WriteLine("Thanks for using this app");
                Console.WriteLine("*************************");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Wrong Choice, please select YES or NO");
                Console.ReadLine();

                Console.Clear();
                MainApp();
            }
        }


    }
}

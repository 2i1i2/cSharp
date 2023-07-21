using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Loops
{
    public class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("08_ Loops in C#");
         
            
            // while loop 
            Console.Write("While Loop > ");
            int wn = 1;
            while (wn <= 5)
            {
                Console.Write(" " + wn);
                wn++;
            }


            Console.WriteLine();

            Console.Write("Do - While Loop > ");
            int dw = 1;
            do
            {
                Console.Write(" "+dw);
                dw++;
            } while (dw <= 10);

            Console.WriteLine();
            
            // for loopp
            // task - print number from 1 to 10;
            Console.Write("For Loop > ");
            for (int i = 1; i <= 15; i++)
            {
                Console.Write(" "+i);
            }


            Console.WriteLine();

            Console.Write("Foreach Loop > ");
            int[] oneToTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17,18,19,20 };

            foreach (var num in oneToTen)
            {
                Console.Write(" "+ num);
            }



            /*
             While loop another example                
             */

            // calling mainmenu
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }

                Console.ReadLine();
        }


        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Successfully, Exit");
                return false;
            }
            else
            {
                return true;
            }

            
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers");
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing Game!");
            Console.ReadLine();
        }


    }
}

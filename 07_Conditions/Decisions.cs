using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conditions
{
    public class Decisions
    {
        static void Main(string[] args)
        {

            //// FIRST SAMPLE-> 
            //Console.WriteLine("Nitin's Big Giveway");
            //Console.Write("Choose a door: 1, 2 or 3: ");
            //string userValue = Console.ReadLine();

            //if (userValue == "1")
            //{
            //    string message = "You won a new car!";
            //    Console.WriteLine(message);
            //}
            //else if (userValue == "2")
            //{
            //    string message = "You won a new boat!";
            //    Console.WriteLine(message);
            //}
            //else if(userValue == "3")
            //{
            //    string message = "You won a new train!";
            //    Console.WriteLine(message);
            //}

            //else
            //{
            //    string message = "Sorry! something is wrong!";
            //    Console.WriteLine(message);
            //}

            //// SECOND SAMPLE
            //Console.WriteLine("Look More Smart Cars.");
            //Console.Write("Choose your favourite car. 1 , 2 , 3 or 4: ");
            //string selectCar = Console.ReadLine();
            //string message;
            //if (selectCar == "1")
            //    message = "You won a BMW";
            //else if (selectCar == "2")
            //    message = "You won a new Toyata";
            //else if (selectCar == "3")
            //    message = "You won a new Maruti Suzuki";
            //else if (selectCar == "4")
            //    message = "You won a new sport car";
            //else
            //    message = "please, select your car";

            //Console.WriteLine(message);



            //// THIRD SAMPLE
            Console.WriteLine("Day List");
            Console.Write("Type any day name: ");
            string youSelectDay = Console.ReadLine();
            switch (youSelectDay)
            {
                case "sunday":
                    Console.WriteLine("You entered  Sunday.");
                    break;
                case "monday":
                    Console.WriteLine("You entered Monday");
                    break;
                default:
                    Console.WriteLine("OOp!. not week name! or input example -> sunday ");
                    break;
            }




            Console.ReadLine();
        }
    }
}

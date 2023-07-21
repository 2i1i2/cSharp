using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Strings
{
    public class Strings
    {
        static void Main(string[] args)
        {
            //string myDummyString = "My \"so-called\"life";
            //string myDummyString = "What if I need a\new line?";
            //string myDummyString = "Go to your c:\\ drive";
            //string myDummyString = @"Go to your c:\\ drive root area";
            //string stringFormate = String.Format("{1} = {0}", "First", "Second");
            //string stringFormate = string.Format("{0:C}", 123.34);
            //string stringFormate = string.Format("{0:N}", 123333934);
            //string stringFormate = string.Format("Percentage: {0:P}", .123);
            //string stringFormate = string.Format("Number: {0:(###) ###-####}", 12345678923);

            string myString = " That summer we took threes across the board";


            myString = myString.Substring(5);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Arrays in C#");

            // Array declaration
            int[] array1;
            
            // array declaration with size
            int[] array2 = new int[5];

            // assignint value into the array
            array2[0] = 102;
            array2[1] = 12;
           // array2[2] = 93;
            array2[3] = 24;
            array2[4] = 23;

            Console.Write("Number Type Array: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(" "+array2[i]);
            }


            Console.WriteLine();

            Console.Write("String Type Array: ");
            string[] villagePersonNames = new string[] { "Mohan", "Sourabh", "tina", "Sana Javed" };
            foreach (string str in villagePersonNames)
            {
                Console.Write(" "+str);
            }

            Console.WriteLine();  // for terminat new line

            double[] marks = new double[] { 23.83, 39.90, 23.01, 45.00 };

            Console.Write("Double Type Array");
            foreach (var mark in marks)
            {
                Console.Write(" "+mark);
            }

            Console.WriteLine();

            string zig = "Lorem text use as dumy sytax for fill up the new or dummy text in place of paragrap " +
                          " if you help  enough other poeple get what theyt want.";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (char str in charArray)
            {
                Console.Write(str);
            }

                Console.ReadLine();
        }
    }
}

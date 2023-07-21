using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Opetators
{
    public class Opetators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatos in C# language.");


            // variable declaration
            int x, firstNameLength, y, a, b;

            // Assignment operator
            x = 3;
            firstNameLength = 12;
            y = 5;
            a = 34;
            b = 98;

            // Addition Operator
            x = 3 + 4;

            // Subtraction Operator
            x = 6 - 4;

            // Multiplication Operator
            x = 3 * 4;

            // Division Operator
            x = 10 / 5;

            // Order of operators using paranthesis
            x = (x + y) * (a - b);

          
            // Equality Operator
            if (x == y)
            {

            }

            // Greater than Operator
            if (x > y)
            {

            }

            // if greater than or equal to operator
            if (x >= y)
            {

            }

            // if less than or equal to operator
            if (x <= y)
            {

            }

            // Conditional and operator
            if((a > y) && ( a < y))
            {

            }

            // Conditial or operator
            if ((x < y) || (a > b))
            {

            }

            // In-line conditiona operator or Ternary Operator
            string myAddress = (x == 1) ? "Noida" : "Singapur";









        }
    }
}

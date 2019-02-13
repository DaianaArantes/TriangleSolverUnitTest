/*Assignment2
 * TriangleSolver Class that receives 3 inputs and
 * check if they form a triangle and which one
 * writen By Daiana Arantes
 * Revision History
 * Feb 2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DArantesAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            string result = "";
            if (a + b > c && a + c > b && b + c > a)
            {
                result = "Form a triangle - ";

                if (a == b && b == c)
                {
                    result += "The triangle is equilateral";
                }
                else if (a == b || a == c || b == c)
                {
                    result += "The triangle is isosceles";
                }
                else
                {
                    result += "The triangle is scalene";
                }
            }
            else
            {
                result = "Does not form a triangle";
            }

            return result;
        }

    }
}

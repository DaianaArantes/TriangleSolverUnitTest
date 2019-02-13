/*Assignment2
 *writen By Daiana Arantes
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
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            do
            {
                //Main menu
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                try
                {
                    menuOption = Convert.ToInt16(Console.ReadLine());

                    if (menuOption == 1)
                    {
                        do
                        {
                            //Get first value
                            Console.WriteLine("Please enter first value of the triangle: ");
                            Console.WriteLine();
                            a = GetInput();

                        } while (a < 0 || a == 0);

                        do
                        {
                            //Get second value
                            Console.WriteLine("Please enter second value of the triangle: ");
                            Console.WriteLine();
                            b = GetInput();

                        } while (b < 1 || b == 0);

                        do
                        {
                            //Get third value
                            Console.WriteLine("Please enter Third value of the triangle: ");
                            Console.WriteLine();
                            c = GetInput();

                        } while (c < 0 || c == 0);

                        // Call method that analyze if it forms a triangle and which one it is 
                        Console.WriteLine();
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                        Console.WriteLine();


                    }
                    else if (menuOption == 2)
                    {
                        // Exit the program
                        Environment.Exit(0);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input, please try again!");
                    Console.WriteLine();
                }

            } while (menuOption != 1 || menuOption != 2);
        }

        /// <summary>
        /// Method to get input and check if there are errors
        /// </summary>
        /// <returns>value</returns>
        public static int GetInput()
        {
            int value = 0;
            try
            {
                value = Convert.ToInt16(Console.ReadLine());
                if (value < 0 || value == 0)
                {
                    Console.WriteLine("Please insert only positive numbers greater then zero"); 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please insert only positive numbers greater then zero");
            }

            return value;
        }
    }
}

/*Assignment2
 * Class Test For the TriangleSolver class
 *writen By Daiana Arantes
 * Revision History
 * Feb 2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DArantesAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeTests()
        {
            // Tests if the triangle is isosceles, so 3 inputs with 2 of the same value was given and the result should be a string
            Assert.AreEqual("Form a triangle - The triangle is isosceles", TriangleSolver.Analyze(2, 3, 2));

            // Tests if the triangle is equilateral, so 3 inputs with the same value was given and the result should be a string
            Assert.AreEqual("Form a triangle - The triangle is equilateral", TriangleSolver.Analyze(2, 2, 2));

            // Tests if the triangle is scalene, so 3 inputs with different values was given and the result should be a string
            Assert.AreEqual("Form a triangle - The triangle is scalene", TriangleSolver.Analyze(2, 3, 4));

            // Tests if the input does not form a triangle, so 3 inputs with not possible values was given and the result should be a string
            Assert.AreEqual("Does not form a triangle", TriangleSolver.Analyze(2, 5, 8));

            // Tests if the input does not form a triangle, so 3 inputs with not possible values, different from the previous test, was given and the result should be a string
            Assert.AreEqual("Does not form a triangle", TriangleSolver.Analyze(3, 9, 2));

            // Tests if the input does not form a triangle, so 3 inputs with not possible values, different from the previous test, was given and the result should be a string
            Assert.AreEqual("Does not form a triangle", TriangleSolver.Analyze(1, 7, 6));
        }

    }
}

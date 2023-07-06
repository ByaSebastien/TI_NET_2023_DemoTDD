using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_DemoTDD.Test
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        [DataRow(5, 3, 8)]
        [DataRow(5, 9, 14)]
        [DataRow(-5, 9, 4)]
        [DataRow(-5, 0, -5)]
        [DataRow(5, -9, -4)]
        [DataRow(-5, -9, -14)]
        public void Addition(int nb1, int nb2, int expected)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            int actual = mathService.Addition(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(int.MaxValue, 10)]
        [DataRow(int.MinValue, -10)]
        public void AdditionLimit(int nb1, int nb2)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action / Assert
            Assert.ThrowsException<OutOfRangeMathException>(() => mathService.Addition(nb1, nb2));
        }

        [TestMethod]
        [DataRow(5.5F,3.3F,8.8F)]
        public void AdditionFloat(float nb1, float nb2, float expected)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            float actual = mathService.Addition(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(float.MaxValue, 10F)]
        [DataRow(float.MinValue, -10F)]
        public void AdditionFloatLimit(float nb1, float nb2)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action / Assert
            Assert.ThrowsException<OutOfRangeMathException>(() => mathService.Addition(nb1, nb2));
        }

        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(10, -5, 15)]
        [DataRow(-10, 5, -15)]
        [DataRow(-10, -5, -5)]
        public void Soustraction(int nb1, int nb2, int expected)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            int actual = mathService.Soustraction(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(int.MinValue, 10)]
        [DataRow(int.MaxValue, -10)]
        public void SoustractionLimit(int nb1, int nb2)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action / Assert
            Assert.ThrowsException<OutOfRangeMathException>(() => mathService.Soustraction(nb1, nb2));
        }

        [TestMethod]
        [DataRow(5,5,25)]
        [DataRow(5,-5,-25)]
        [DataRow(-5,5,-25)]
        [DataRow(-5,-5,25)]
        [DataRow(5,0,0)]
        public void Multiplication(int nb1, int nb2,int expected)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            int actual = mathService.Multiplication(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(int.MaxValue,2)]
        [DataRow(int.MaxValue,-2)]
        [DataRow(int.MinValue,2)]
        [DataRow(int.MinValue,-2)]
        public void Multiplication(int nb1, int nb2)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action / Assert
            Assert.ThrowsException<OutOfRangeMathException>(() => mathService.Multiplication(nb1, nb2));
        }

        [TestMethod]
        [DataRow(10,2,5)]
        public void Division(int nb1, int nb2, int expected)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            int actual = mathService.Division(nb1, nb2);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(10,0)]
        public void DivisionParZero(int nb1, int nb2)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action / Assert
            Assert.ThrowsException<DividedByZeroMathException>(() => mathService.Division(nb1, nb2));
        }

        [TestMethod]
        [DataRow(10)]
        public void IsEven(int nb1)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            bool actual = mathService.IsEven(nb1);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(9)]
        public void IsOdd(int nb1)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            bool actual = mathService.IsEven(nb1);

            //Assert
            Assert.IsFalse(actual);
        }
    }
}

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
        [DataRow(5,3,8)]
        [DataRow(5,9,14)]
        [DataRow(-5,9,4)]
        [DataRow(-5,0,-5)]
        [DataRow(5,-9,-4)]
        [DataRow(-5,-9,-14)]
        public void Addition(int nb1,int nb2,int expected)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action
            int actual = mathService.Addition(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(int.MaxValue,10)]
        [DataRow(int.MinValue,-10)]
        public void AdditionLimit(int nb1,int nb2)
        {
            //Arrange
            IMathService mathService = new MathService();

            //Action / Assert
            Assert.ThrowsException<OutOfRangeMathException>(() => mathService.Addition(nb1, nb2));
        }

        [TestMethod]

    }
}

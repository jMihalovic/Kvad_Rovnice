using Microsoft.VisualStudio.TestTools.UnitTesting;
using KvadratickéRovnice;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow(4, 4, 0, -0.5)]
        [DataRow(-2, -15, 289, -8)]
        [DataRow(1, 3, 1, -1)]
        public void VraciTrue_KdyzVyjdePrvniKoren(double a, double b, double d,double expected)
        {
            double i = Program.VypocetKorenuPlus(a,b,d);

            Assert.IsTrue(i == expected);
        }

        [TestMethod]

        [DataRow(4, 4, 0, -0.5)]
        [DataRow(-2, -15, 289, 0.5)]
        [DataRow(1, 3, 1, -2)]
        public void VraciTrue_KdyzVyjdeDruhyKoren(double a, double b, double d, double expected)
        {
            double i = Program.VypocetKorenuMinus(a, b, d);

            Assert.IsTrue(i == expected);
        }

        [TestMethod]

        [DataRow(2, 1, 1)]
        [DataRow(5, 8, 6)]
        [DataRow(8, 5, 10)]
        public void HodiChybu_KdyzJeDiskriminantZaporny(double a, double b, double c)
        {
            double i = Program.VypocetDiskriminantu(a,b,c);

            Assert.IsTrue(i < 0);
        }

        [TestMethod]

        [DataRow(2, -11, 14, 9)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(4, 4, 1, 0)]
        public void VraciTrue_KdyzVychaziDiskriminant(double a, double b, double c, double expected)
        {
            double i = Program.VypocetDiskriminantu(a, b, c);

            Assert.IsTrue(expected == i);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using KvadratickéRovnice;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow(0, 0, 0, 0)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(0, 0, 0, 0)]
        public void VraciTrue_KdyzVyjdeNulaProPrvniVypocet(double a, double b, double d,double expected)
        {
            double i = Program.VypocetKorenuPlus(a,b,d);

            Assert.IsTrue(i == expected);
        }

        [TestMethod]

        [DataRow(0, 0, 0, 0)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(0, 0, 0, 0)]
        public void VraciTrue_KdyzVyjdeNulaProDruhyVypocet(double a, double b, double d, double expected)
        {
            double i = Program.VypocetKorenuMinus(a, b, d);

            Assert.IsTrue(i == expected);
        }

        [TestMethod]

        [DataRow(0, 0, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(0, 0, 0)]
        public void VraciFalse_KdyzJeDiskriminantZaporny(double a, double b, double c)
        {
            double i = Program.VypocetDiskriminantu(a,b,c);

            Assert.IsFalse(i <= 0);
        }
    }
}

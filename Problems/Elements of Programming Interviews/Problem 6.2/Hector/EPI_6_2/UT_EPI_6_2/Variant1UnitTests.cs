using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPI_6_2;

namespace UT_EPI_6_2
{
    [TestClass]
    public class Variant1UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = "231";
            var b = "500";
            var expected = "731";

            var res = Variant1.Solve(a, b);

            StringAssert.Equals(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = "99";
            var b = "1";
            var expected = "731";

            var res = Variant1.Solve(a, b);

            StringAssert.Equals(expected, res);
        }
    }
}

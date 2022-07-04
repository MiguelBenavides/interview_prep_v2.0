using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPI_6_1;

namespace UT_EPI_6_1
{
    [TestClass]
    public class Variant2UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var A = new int[] { 3, 2, 0, 1, 2, 0, 2, 3 };

            var expectedA = new int[] { 0, 0, 1, 2, 2, 2, 3, 3 };

            Variant2.Solve(A);

            CollectionAssert.AreEqual(expectedA, A);
        }
    }
}

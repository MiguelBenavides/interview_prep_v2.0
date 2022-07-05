using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPI_6_2;

namespace UT_EPI_6_2
{
    [TestClass]
    public class MainProblemUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var D = new int[] { 1, 2, 9 };
            var expectedD = new int[] { 1, 3, 0 };

            MainProblem.Solve(D);

            CollectionAssert.AreEqual(expectedD, D);
        }
    }
}

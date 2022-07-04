using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPI_6_1;

namespace UT_EPI_6_1
{
    [TestClass]
    public class MainProblemUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pivotIndex = 4;
            var A = new int[] { 3, 2, 0, 1, 2, 0, 2, 4 };

            var expectedA = new int[] { 0, 1, 0, 2, 2, 2, 4, 3 };

            MainProblem.Solve(A, pivotIndex);

            CollectionAssert.AreEqual(expectedA, A);
        }
    }
}

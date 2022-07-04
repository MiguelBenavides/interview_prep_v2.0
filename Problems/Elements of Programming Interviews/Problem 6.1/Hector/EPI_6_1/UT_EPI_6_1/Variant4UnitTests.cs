using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPI_6_1;

namespace UT_EPI_6_1
{
    [TestClass]
    public class Variant4UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var A = new Variant4.Entry[6];
            A[0] = new Variant4.Entry(true, 1);
            A[1] = new Variant4.Entry(false, 2);
            A[2] = new Variant4.Entry(false, 4);
            A[3] = new Variant4.Entry(true, 2);
            A[4] = new Variant4.Entry(true, 4);
            A[5] = new Variant4.Entry(false, 3);

            var expectedA = new Variant4.Entry[6];
            expectedA[0] = new Variant4.Entry(false, 3);
            expectedA[1] = new Variant4.Entry(false, 2);
            expectedA[2] = new Variant4.Entry(false, 4);
            expectedA[3] = new Variant4.Entry(true, 1);
            expectedA[4] = new Variant4.Entry(true, 2);
            expectedA[5] = new Variant4.Entry(true, 4);

            Variant4.Solve(A);

            for(var i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(expectedA[i].Key, A[i].Key);
                Assert.AreEqual(expectedA[i].Value, A[i].Value);
            }
        }
    }
}

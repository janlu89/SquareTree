using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SquareTree.Tests
{
    [TestClass()]
    public class DecomposeTests
    {
        [TestMethod]
        [DataRow(11, "1, 2, 4, 10")]
        [DataRow(50, "1, 3, 5, 8, 49")]
        [DataRow(12, "1, 2, 3, 7, 9")]
        [DataRow(625, "2, 5, 8, 34, 624")]
        [DataRow(1234567, "2, 8, 32, 1571, 1234566")]
        [DataRow(4, null)]
        [DataRow(6, null)]
        [DataRow(1, "1")]
        [DataRow(0, "")]
        public void decomposeTest(long n, string result)
        {
            Decompose d = new Decompose();
            Assert.AreEqual(result, d.decompose(n));
        }
    }
}
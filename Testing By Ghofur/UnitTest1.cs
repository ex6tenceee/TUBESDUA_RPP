using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing_By_Ghofur
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nama = "yyyyy";
            Assert.AreEqual(nama,ToString);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing_By_Yanuar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string username = "Yapi";
            Assert.AreEqual("username", username);
            string password = "123yapi";
            Assert.IsTrue(string.IsNullOrEmpty(password));

        }
    }
}
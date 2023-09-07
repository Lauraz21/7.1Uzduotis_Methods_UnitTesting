using _7._1Uzduotis_Methods_UnitTesting;

namespace Test7._1Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string email = "Katinas@gmail.com";

            bool actual = Program.IsEmailValid(email);

            Assert.IsTrue(actual);
        }
    }
}
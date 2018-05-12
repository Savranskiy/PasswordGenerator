using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator;

namespace UnitTestPasswordGenerator
{
    [TestClass]
    public class PasswordGeneratorTest
    {
        private Generator passwordGenerator = new Generator();

        [TestMethod]
        public void PasswordLength()
        {
            Assert.AreEqual(6, passwordGenerator.Generate().Length);
            passwordGenerator.Size = 10;
            Assert.AreEqual(10, passwordGenerator.Generate().Length);
        }
    }
}

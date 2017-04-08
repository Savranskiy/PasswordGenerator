using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator;

namespace UnitTestPasswordGenerator
{
    [TestClass]
    public class GeneratorTest
    {
        private Generator passwordGenerator = Generator.GetInstance();

        [TestMethod]
        public void PasswordLength()
        {
            Assert.AreEqual(6, passwordGenerator.Generate().Length);
            passwordGenerator.Size = 10;
            Assert.AreEqual(10, passwordGenerator.Generate().Length);
        }
    }
}

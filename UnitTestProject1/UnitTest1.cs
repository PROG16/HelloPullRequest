using System;
using HelloPullRequest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            var person = new Fredrik();

            // Act
            var result = person.CanSpeak();

            // Assert
            Assert.IsTrue(result, "Fredrik cant speak");
        }
    }
}

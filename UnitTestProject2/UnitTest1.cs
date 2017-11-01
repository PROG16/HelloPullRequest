using System;
using HelloPullRequest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FredrikCanSpeak()
        {
            // Arrange
            var person = new Fredrik();

            // Act
            var result = person.CanSpeak();

            // Assert
            Assert.IsTrue(result, "Fredrik can speak!!!");
        }
    }
}

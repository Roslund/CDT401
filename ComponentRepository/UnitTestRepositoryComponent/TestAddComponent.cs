using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryComponent;
using System.Linq;

namespace RepositoryComponentTest
{
    [TestClass]
    public class TestAddComponent
    {
        [TestMethod]
        public void TestInvalidExtention()
        {
            var repo = new RepositoryService();
            var testComponent = new Component
            {
                Title = "TestComponent",
                FileName = "test.txt",
            };
            var result = repo.AddComponent(testComponent);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TestInvalidDotNETComponent()
        {
            var repo = new RepositoryService();
            var testComponent = new Component
            {
                Title = "TestComponent",
                FileName = "test.dll",
            };
            var result = repo.AddComponent(testComponent);
            Assert.AreEqual(result, false);
        }
    }
}

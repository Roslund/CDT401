using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryComponent;
using System.Linq;
using System.IO;

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
                Title = "TestComponent2",
                ShortDescription = "This is a test component",
                LongDescription = "this component test that the database connection works.",
                FileName = "atl.dll",
                Content = File.ReadAllBytes(@"C:\windows\system32\atl.dll")
            };
            var result = repo.AddComponent(testComponent);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TestValidDotNETComponent()
        {
            var repo = new RepositoryService();
            var testComponent = new Component
            {
                Title = "System.ValueTuple",
                ShortDescription = "This is a test component",
                LongDescription = "this component test that the database connection works.",
                FileName = "System.ValueTuple.dll",
                Content = File.ReadAllBytes(@"C:\Users\Enari\source\repos\cdt401\ComponentRepository\RepositoryComponent\bin\Debug\System.ValueTuple.dll")
            };
            var result = repo.AddComponent(testComponent);
            Assert.AreEqual(result, true);
        }
    }
}

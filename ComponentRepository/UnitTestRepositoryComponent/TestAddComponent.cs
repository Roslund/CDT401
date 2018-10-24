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
                Title = "netComponent",
                ShortDescription = "A .NET parser for reflection",
                LongDescription = "This component implements a .NET parser to extract information about comcomponents and writes this informations into a JSON FILE",
                FileName = "netComponent.dll",
                Content = File.ReadAllBytes(@"C:\Users\Enari\source\repos\cdt401\ComponentRepository\RepositoryComponent\bin\Debug\netComponent.dll")
            };
            var result = repo.AddComponent(testComponent);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestValidDotNETComponentRepositoryComponent()
        {
            var repo = new RepositoryService();
            var testComponent = new Component
            {
                Title = "RepositoryComponent",
                ShortDescription = "This component is the main component.",
                LongDescription = "He provides users’and admin’s interfaces and manages all functionalities of the application. He also managestransactions carried out on the database.",
                FileName = "RepositoryComponent.dll",
                Content = File.ReadAllBytes(@"C:\Users\Enari\source\repos\cdt401\ComponentRepository\RepositoryComponent\bin\Debug\RepositoryComponent.dll")
            };
            var result = repo.AddComponent(testComponent);
            Assert.AreEqual(result, true);
        }
    }
}

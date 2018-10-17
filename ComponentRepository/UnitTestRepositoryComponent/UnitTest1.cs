using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryComponent;
using System.Data.Linq;
using System.Linq;


namespace UnitTestRepositoryComponent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddComponent()
        {
            using (var db = new ComponentContext())
            {

                var testComponent = new Component {
                    Title = "TestComponent",
                    ShortDescription = "This is a test component",
                    LongDescription = "this component test that the database connection works.",
                    Metadata = "this should be json",
                    Content = null
                };
                db.Components.Add(testComponent);
                db.SaveChanges();

            }
        }

        [TestMethod]
        public void TestDeletComponent()
        {
            using (var db = new ComponentContext())
            {
                var testComponent = (from c in db.Components where c.Title == "TestComponent" select c).First();
                Console.WriteLine(testComponent.Title);
                db.Components.Remove(testComponent);
                db.SaveChanges();
            }
        }
    }
}

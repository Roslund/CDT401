using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryComponent;
using System.Data.Linq;
using System.Linq;
using System.IO;


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
                    FileName = "atl.dll",
                    Metadata = @"{
    'classes': [
    ],
    'interfaces': {
        'Collection': [
            'subscript(position: Self.Index) -> Self.Element { get }',
            'mutating func popFirst() -> Self.Element?',
            'mutating func shuffle()',
            'mutating func removeFirst(_ k: Int)',
            'func split(separator: Self.Element, maxSplits: Int = default, omittingEmptySubsequences: Bool = default) -> [Self.SubSequence]'
        ],
        'MutableCollection': [
            'mutating func reverse()',
            'mutating func shuffle()',
            'mutating func sort()'
        ]
    }
}",
                    Content = File.ReadAllBytes("c:/atl.dll")
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

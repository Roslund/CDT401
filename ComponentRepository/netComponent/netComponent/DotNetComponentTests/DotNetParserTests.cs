using Microsoft.VisualStudio.TestTools.UnitTesting;
using netComponent;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace netComponent.Tests
{
    [TestClass()]
    public class DotNetParserTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.IsTrue(1==1,"Test");
        }

        [TestMethod()]
        public void testImplementation()
        {
            IComponentParser parser = new DotNetParser();
            byte[] dllFile = new byte[3];
            try
            {
                Assert.AreNotSame(parser.parseComponentFile(dllFile), "test");
            }catch(BadImageFormatException n)
            {
                Console.WriteLine("Bad byteFile");
            }
        }

        [TestMethod()]
        public void testByteConverter()
        {
            IComponentParser parser = new DotNetParser();
            byte[] dllFile = File.ReadAllBytes("C:\\Users\\milos\\OneDrive\\Desktop\\Mr MDH\\ComponentTechnologies\\Project\\ComponentRepository\\netComponent\\netComponent\\netComponent\\bin\\Debug\\netComponent.dll");
            Console.WriteLine(dllFile.Length);
            Console.WriteLine(dllFile[dllFile.Length-1]);
            Console.WriteLine("test test tesst test test");
            Assert.AreNotSame(parser.parseComponentFile(dllFile), "test");
        }

        [TestMethod()]
        public void testReflection()
        {
            IComponentParser parser = new DotNetParser();
            String rightPathtest = "C:\\Users\\milos\\OneDrive\\Desktop\\Mr MDH\\ComponentTechnologies\\Project\\ComponentRepository\\netComponent\\netComponent\\netComponent\\bin\\Debug\\netComponent.dll";
            String wrongPathtest = "C:\\Users\\milos\\OneDrive\\Desktop\\Mr MDH\\ComponentTechnologies\\Project\\ComponentRepository\\netComponent\\netComponent\\ExecutableProjectTest\\bin\\Debug\\ExecutableProjectTest.exe";
            byte[] dllFile = File.ReadAllBytes(wrongPathtest);
            Assembly assembly = Assembly.ReflectionOnlyLoad(dllFile);
            Console.WriteLine(assembly.ToString());
            String classes = "{ 'classes' : [";
            String interfaces = "'interfaces' : [";

            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass)
                {
                    classes += type.Name + " , ";
                }else if (type.IsInterface)
                {
                    interfaces += type.Name + " , ";
                }
            }
            classes = classes.Substring(0,classes.Length-3) + "],";
            interfaces = interfaces.Substring(0, interfaces.Length - 3) + "]}";
            string json = classes + interfaces;

            Assert.AreNotSame(parser.parseComponentFile(dllFile), "test");
        }

        [TestMethod()]
        public void testParsing()
        {
            IComponentParser parser = new DotNetParser();
            byte[] dllFile = File.ReadAllBytes("C:\\Users\\milos\\OneDrive\\Desktop\\Mr MDH\\ComponentTechnologies\\Project\\ComponentRepository\\netComponent\\netComponent\\netComponent\\bin\\Debug\\netComponent.dll");
            String json = parser.parseComponentFile(dllFile);
            Boolean containsClasses = json.Contains("DotNetParser");
            Boolean containsInterfaces = json.Contains("IComponentParser");

            Assert.IsTrue(containsClasses);
            Assert.IsTrue(containsInterfaces);
        }
    }
}
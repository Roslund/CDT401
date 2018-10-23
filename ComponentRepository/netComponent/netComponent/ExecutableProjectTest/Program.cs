using netComponent;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutableProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponentParser parser = new DotNetParser();
            byte[] dllFile = File.ReadAllBytes("C:\\Users\\milos\\OneDrive\\Desktop\\Mr MDH\\ComponentTechnologies\\Project\\ComponentRepository\\netComponent\\netComponent\\ExecutableProjectTest\\bin\\Debug\\ExecutableProjectTest.xe");
            Console.WriteLine(parser.parseComponentFile(dllFile));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace netComponent
{
    public class DotNetParser : IComponentParser
    {
        public string ParseComponentFile(byte[] file)
        {
            try
            {
                Assembly assembly = Assembly.ReflectionOnlyLoad(file);
                Console.WriteLine(assembly.ToString());
                String classes = "{ 'classes' : {";
                String interfaces = "'interfaces' : {";

                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsClass)
                    {
                        classes += "'" + type.Name + "': [";

                        foreach (var method in type.GetMethods())
                        {
                            classes += "'" + method.ToString() + "',";
                        }
                        classes += "] , ";
                    }
                    else if (type.IsInterface)
                    {
                        interfaces += "'" + type.Name + "': [";
                        foreach (var method in type.GetMethods())
                        {
                            interfaces += "'" + method.ToString() + "',";
                        }
                        interfaces += "] , ";
                    }
                }
                classes = classes.Substring(0, classes.Length - 3) + "},";
                interfaces = interfaces.Substring(0, interfaces.Length - 3) + "}}";
                string jsonTemplate = classes + interfaces;
                return jsonTemplate;
            }
            catch (BadImageFormatException)
            {
                return "{ 'error': 'caused by wrong component format'}";
            }
        }

    }
}

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
                    if (type.IsClass && type.IsPublic)
                    {
                        classes += "'" + type.Name + "': [";

                        foreach (var method in type.GetMethods())
                        {
                            if (method.IsPublic)
                            {
                                classes += "'" + method.ToString() + "',";
                            }
                        }
                        classes += "] , ";
                    }
                    else if (type.IsInterface && type.IsPublic)
                    {
                        interfaces += "'" + type.Name + "': [";

                        foreach (var method in type.GetMethods())
                        {
                            if (method.IsPublic)
                            {
                                interfaces += "'" + method.ToString() + "',";
                            }
                        }
                        interfaces += "] , ";
                    }
                }

                classes += "},";
                interfaces += "}}";

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

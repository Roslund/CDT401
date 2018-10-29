using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace netComponent
{
    public class DotNetParser : IComponentParser
    {
        public string ParseComponentFile(byte[] file)
        {
            try
            {
                Assembly assembly = Assembly.ReflectionOnlyLoad(file);
                JObject output = new JObject();

                var publicTypes = assembly.GetTypes().Where(type => type.IsPublic);
                var publicClasses = publicTypes.Where(type => type.IsClass);
                var publicInterfaces = publicTypes.Where(type => type.IsInterface);

                Dictionary<string, string[]> MakeDictonary(IEnumerable<Type> types)
                {
                    return types.ToDictionary(type => type.Name, 
                        type => type.GetMethods().Select(method => method.ToString()).ToArray());
                }

                output["classes"] = JObject.FromObject(MakeDictonary(publicClasses));
                output["interfaces"] = JObject.FromObject(MakeDictonary(publicInterfaces));

                return output.ToString();
            }
            catch (BadImageFormatException)
            {
                return "{ 'error': 'caused by wrong component format'}";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netComponent;
using Newtonsoft.Json.Linq;
using javacomponent;
using COMParserLib;
using System.IO;

namespace RepositoryComponent
{
    public class RepositoryService : IWeb, IAdministrator
    {
        public bool AddComponent(Component component)
        {

            // Check the file extention and load the apropiate parser
            switch (component.FileName.Split('.').Last())
            {
                case "jar":
                    //throw new NotImplementedException();
                    javacomponent.IComponentParser javaParser = new JavaParser();
                    component.Metadata = javaParser.parseComponent(component.Content);
                    break;
                case "dll":
                    netComponent.IComponentParser dotNetParser = new DotNetParser();
                    component.Metadata = dotNetParser.ParseComponentFile(component.Content);
                    break;
                default:
                    return false;
            }

            // If the parsing failed we retry with the COM Parser
            if (JObject.Parse(component.Metadata)["error"] != null)
            {
                //parser = new COMParser();
                //component.Metadata = parser.parseComponent(component.Content);
                COMParserLib.IParser comParser = new COMParserLib.Parser();
                File.WriteAllBytes("./test.dll", component.Content);
                component.Metadata = comParser.parseComponentFile("./test.dll");

                // Check for errors Again
                if (JObject.Parse(component.Metadata)["error"] != null)
                {
                    return false;
                }
            }

            // Add and save the component
            using (var db = new ComponentContext())
            {
                db.Components.Add(component);
                db.SaveChanges();
            }
            return true;
            
        }

        public (byte[] content, string fileName) DownloadComponent(int id)
        {
            using (var db = new ComponentContext())
            {
                var component = db.Components.Find(id);
                return (component.Content, component.FileName);
            }
        }

        public List<Component> GetComponents()
        {
            using (var db = new ComponentContext())
            {
                return db.Components.ToList();
            }
        }

        public bool RemoveComponent(int componentID)
        {
            using (var db = new ComponentContext())
            {
                var component = db.Components.Find(componentID);
                db.Components.Remove(component);
                db.SaveChanges();
            }

            return true;
        }

        public bool UpdateComponent(Component component)
        {
            using(var db = new ComponentContext())
            {
                var temp = db.Components.Find(component.Id);
                db.Components.Remove(temp);
                db.Components.Add(component);
                db.SaveChanges();
            }

            return true;
        }
    }
}

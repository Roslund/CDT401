using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryComponent
{
    public class RepositoryService : IWeb, IAdministrator
    {
        public bool AddComponent(Component component)
        {
            throw new NotImplementedException();
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
                temp = component;
                db.SaveChanges();
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryComponent
{
    class RepositoryService : IWeb, IAdministrator
    {
        public bool AddComponent(Component component)
        {
            throw new NotImplementedException();
        }

        public byte[] DownloadComponent(int id)
        {
            using (var db = new ComponentContext())
            {
                return db.Components.Find(id).Content;
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
            throw new NotImplementedException();
        }

        public bool UpdateComponent(Component component)
        {
            throw new NotImplementedException();
        }
    }
}

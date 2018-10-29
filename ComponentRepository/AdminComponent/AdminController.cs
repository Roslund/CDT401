using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryComponent;

namespace AdminComponent
{
    public class AdminController
    {
        public List<Component> ComponentsList { get;set; }
        public IAdministrator repo = new RepositoryService();

        public AdminController()
        { 
            ComponentsList = repo.GetComponents();
        }

        public void addComponent(Component componentAdd)
        {
            repo.AddComponent(componentAdd);
        }

        public void removeCompoennt(int id)
        {
            repo.RemoveComponent(id);
        }

        public void editComponent(Component componentEdited)
        {
            repo.UpdateComponent(componentEdited);
        }

        public void getAllComponent()
        {
            this.ComponentsList.Clear();
            ComponentsList = repo.GetComponents(); 
        }

        

    }
}

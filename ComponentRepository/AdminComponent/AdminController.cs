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

        public void addComponent(Component componentAdd)
        {
            // send the new component with : (componentAdd)

            //for test :
            componentAdd.Id = ComponentsList.Count;
            this.ComponentsList.Add(componentAdd);
        }

        public void removeCompoennt(int id)
        {
            //send request to delete with : (id)

            //for test -------------------
            ComponentsList.RemoveAll(Component => Component.Id.Equals(id));
        }

        public void editComponent(Component componentEdited)
        {
            // send the new component with : (componentEdited, componentEdited.Id) 
            

        }

        public void getAllComponent()
        {
            this.ComponentsList.Clear();
            // repository service getComponents 
        }

        public AdminController()
        {
            IAdministrator repo = new RepositoryService();
            ComponentsList = repo.GetComponents();
        }

    }
}

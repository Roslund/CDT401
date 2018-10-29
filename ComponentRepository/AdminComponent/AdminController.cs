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
            // send the new component with : (componentAdd)
            Console.WriteLine("test 1000");
           // repo.AddComponent(componentAdd);
            Console.WriteLine("test 1001");
            //for test :
            componentAdd.Id = ComponentsList.Count;
            this.ComponentsList.Add(componentAdd);
        }

        public void removeCompoennt(int id)
        {
            //send request to delete with : (id)
            repo.RemoveComponent(id);
            //for test -------------------
            //ComponentsList.RemoveAll(Component => Component.Id.Equals(id));
        }

        public void editComponent(Component componentEdited)
        {
            // send the new component with : (componentEdited, componentEdited.Id) 
            repo.UpdateComponent(componentEdited);

        }

        public void getAllComponent()
        {
            this.ComponentsList.Clear();
            ComponentsList = repo.GetComponents();
            // repository service getComponents 
        }

        

    }
}

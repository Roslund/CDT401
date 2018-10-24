using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryComponent;

namespace AdminComponent
{
    class AdminController
    {
        public List<Component> ComponentsList { get;set; }

        public void addComponent()
        {
            
        }

        public void removeCompoennt()
        {

        }

        public void editComponent()
        {

        }

        public void getAllComponent()
        {
            this.ComponentsList.Clear();
            // repository service getComponents 
        }

        public AdminController()
        {
            this.ComponentsList = new List<Component>();

            // for test ---- 
            Component test = new Component();
            test.Id = 0;
            test.LongDescription = "my life is patatos and this is a longggggggggggg descriptionjhsqluyvslhbhjvbhlfshblsdvbhklvsdbjklh";
            test.ShortDescription = "My life is patatos";
            test.Title = "PatatosComponent";
            test.FileName = "patate.xml";

            this.ComponentsList.Add(test);
        }

    }
}

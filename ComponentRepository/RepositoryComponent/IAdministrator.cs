using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryComponent
{
    interface IAdministrator: IWeb
    {
        bool AddComponent(Component component);
        bool UpdateComponent(Component component);
        bool RemoveComponent(int componentID);
    }
}

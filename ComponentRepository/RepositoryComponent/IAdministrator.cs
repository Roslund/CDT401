using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryComponent
{
    public interface IAdministrator: IWeb
    {
        bool AddComponent(Component component);
        bool UpdateComponent(Component component);
        bool RemoveComponent(int componentID);
    }
}

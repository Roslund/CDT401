using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryComponent
{
    interface IWeb
    {
        List<Component> GetComponents();
        byte[] DownloadComponent(int id);
    }
}

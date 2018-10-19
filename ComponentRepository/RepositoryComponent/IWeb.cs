using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryComponent
{
    public interface IWeb
    {
        List<Component> GetComponents();
        byte[] DownloadComponent(int id);
    }
}

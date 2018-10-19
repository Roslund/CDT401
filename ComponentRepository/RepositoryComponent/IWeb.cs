using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryComponent
{
    public interface IWeb
    {
        List<Component> GetComponents();
        (byte[] content, string fileName) DownloadComponent(int id);
    }
}

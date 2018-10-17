using System;
using System.Data.Entity;
using System.Data.Linq;

namespace RepositoryComponent
{
    public class ComponentInformation
    {
        //Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Metadata { get; set; }
    }

    public class Component : ComponentInformation
    {
        //Properties
        public byte[] Content { get; set; }
    }

    public class ComponentContext : DbContext
    {
        public DbSet<Component> Components { get; set; }
    }
}

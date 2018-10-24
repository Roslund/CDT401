using System;
using System.Data.Entity;
using System.Data.Linq;

namespace RepositoryComponent
{

    public class Component
    {
        //Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string FileName { get; set; }
        public string Metadata { get; set; }
        public byte[] Content { get; set; }
    }

    internal class ComponentContext : DbContext
    {
        public DbSet<Component> Components { get; set; }
    }
}

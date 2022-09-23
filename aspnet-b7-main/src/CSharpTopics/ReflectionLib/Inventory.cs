using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public class Inventory : IModule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Inventory()
        {
            Id = Guid.NewGuid();
            Name = "Inventory";
            IsActive = true;
        }

        public void Start()
        {
            Console.WriteLine("Inventory Started");
        }
    }
}

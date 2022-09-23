using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public class HR : IModule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public HR()
        {
            Id = Guid.NewGuid();
            Name = "HR";
            IsActive = true;
        }

        public void Start()
        {
            Console.WriteLine("HR Started");
        }
    }
}

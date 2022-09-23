using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features
{
    public interface IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting");
        }

        void Stop();
    }
}

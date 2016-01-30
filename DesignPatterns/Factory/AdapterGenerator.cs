using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AdapterGenerator : IAdapterGenerator
    {
        public virtual void generateAdapter()
        {
            Console.WriteLine("Generated adapter from adapter base class");
        }
    }
}


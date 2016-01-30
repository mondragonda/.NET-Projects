using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class AdapterSingleton
    {
        public string TypeName { get; set; }
        private static AdapterSingleton adapterSingleton;

        private AdapterSingleton(string typeName)
        {
            TypeName = typeName;
        }

        public static AdapterSingleton getAdapterSingleton(string typeName)
        {
            if(adapterSingleton == null)
            {
                adapterSingleton = new AdapterSingleton(typeName);
            }

            return adapterSingleton;
        }
    }
}

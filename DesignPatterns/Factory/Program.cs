using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapterGenerator adapter = AdapterFactory.getAdapter(Adapter.NAVBAR_ADAPTER);
            adapter.generateAdapter();
            adapter = AdapterFactory.getAdapter(Adapter.SONG_ADAPTER);
            adapter.generateAdapter();
            Console.Read();
          
        }
    }
}

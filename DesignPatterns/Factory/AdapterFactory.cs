using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AdapterFactory
    {
        public static IAdapterGenerator getAdapter(Adapter adapterType)
        {
            switch (adapterType)
            {
                case Adapter.USER_ADAPTER:
                    return new UserAdapter();
                case Adapter.SONG_ADAPTER:
                    return new SongAdapter();
                case Adapter.NAVBAR_ADAPTER:
                    return new NavBarAdapter();
                default:
                    return null;
            }
        }
    }
}

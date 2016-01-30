using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class UserAdapter : AdapterGenerator
    {
        public override void generateAdapter()
        {
            Console.WriteLine("Generated adapter from UserAdapter Class");
        }
    }
}

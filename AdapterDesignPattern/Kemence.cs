using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
   public class Kemence:IMusicEnstrümant
    {
        public void SatisYap()
        {
            Console.WriteLine("Kemnce satisi yapildi.");
        }
    }
}

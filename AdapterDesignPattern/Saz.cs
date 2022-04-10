using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Saz : IMusicEnstrümant
    {
        public void SatisYap()
        {
            Console.WriteLine("Saz satisi yapildi.");
        }
    }
}

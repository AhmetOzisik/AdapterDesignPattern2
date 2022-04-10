using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class KemenceSatis : MagazaSatis
    {
        private IMusicEnstrümant musicEnstrümant;
        public void SatisYap()
        {
            musicEnstrümant = new Kemence();
            musicEnstrümant.SatisYap();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MagazaSatis magazaSatis = new GitarSatis();
            magazaSatis.SatisYap();
            Console.ReadLine();
        }
    }
}

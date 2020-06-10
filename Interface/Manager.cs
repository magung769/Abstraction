using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Manager : IPerusahaan
    {
        public  void Jabatan()
        {
            Console.WriteLine("Manager yang berperan sebagai motor di suatu divisi atau departement.");
            Console.WriteLine("Manager memastikan bahwa sistem mobilisasi yang di terapkan bisa berjalan dengan baik di lapangan.");
        }
    }
}

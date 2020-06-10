using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Karyawan : IPerusahaan
    {
        public  void Jabatan()
        {
            Console.WriteLine("Karyawan menempati posisi di tingkat yang  paling rendah.");
            Console.WriteLine("Pelaku utama untuk menjalankan atau melakukan suatu instruksi pekerjaan di lapangan.");
        }
    }
}

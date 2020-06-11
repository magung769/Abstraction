using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;    // Menggunakan Abstract Class
//using Abstraction.Interface;      // Menggunakan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Perusahaan perusahaan;          // Menggunakan Abstract Class
            perusahaan = new Karyawan();
            perusahaan.Jabatan();

            Console.WriteLine();
            perusahaan = new Leader();
            perusahaan.Jabatan();

            Console.WriteLine();
            perusahaan = new Manager();
            perusahaan.Jabatan();


            /*IPerusahaan perusahaan;       // Menggunakan Abstract Class
            perusahaan = new Karyawan();
            perusahaan.Jabatan();

            Console.WriteLine();
            perusahaan = new Leader();
            perusahaan.Jabatan();

            Console.WriteLine();
            perusahaan = new Manager();
            perusahaan.Jabatan()*/

            Console.ReadKey();
        }
    }
}

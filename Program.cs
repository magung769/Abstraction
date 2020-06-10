using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;
//using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Perusahaan perusahaan;
            perusahaan = new Karyawan();
            perusahaan.Jabatan();

            Console.WriteLine();
            perusahaan = new Leader();
            perusahaan.Jabatan();

            Console.WriteLine();
            perusahaan = new Manager();
            perusahaan.Jabatan();


            /*Perusahaan perusahaan;
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

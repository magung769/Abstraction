﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Leader : Perusahaan
    {
        public override void Jabatan()
        {
            Console.WriteLine("Leader posisi setingkat di atas jabatan operator.");
            Console.WriteLine("Leader adalah seorang operator yang sudah naik level jabatannya karena di anggap sudah cukup mumpuni dalam bidang skill kerja di lapangan.");
        }
    }
}

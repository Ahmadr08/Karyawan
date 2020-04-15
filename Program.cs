using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2913
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek dari class Karyawan
            Karyawan saya = new Karyawan(190302123, "Frank" , 3000000);
            Karyawan saya1 = new Karyawan(190302124, "Nero", 2000000);

            //membuat properties ob

            Console.WriteLine("NIK\t Nama\t\t\t Gaji ");
            saya.Tampil();
            saya1.Tampil();

            Console.WriteLine("Asyik Gaji Naik 10%");

            saya.GajiNaik();
            saya1.GajiNaik();

            Console.ReadKey();
        }
    }
}

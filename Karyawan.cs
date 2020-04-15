using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2913
{
    class Karyawan
    {
        //properties
        public int NIK {get; set;}
        public string Nama {get; set;}
        public int GajiBln {get; set;} 

        //method
        public Karyawan(int NIK, string Nama, int Gaji)
        {
            this.NIK = NIK;
            this.Nama = Nama;

            if(Gaji<0)
                {
                this.GajiBln = 0;
                }
            else
                {
                this.GajiBln = Gaji;
                }
        }
            
        public void Tampil()
            {
            Console.WriteLine("{0}\t{1}\t{2}", NIK, Nama, GajiBln);
            }

        public void GajiNaik()
            {
            double tmp = 0;
            tmp = 0.1 * GajiBln;
            GajiBln += Convert.ToInt32(tmp);
            Console.WriteLine("{0}\t{1}\t{2}", NIK, Nama, GajiBln);
            }
    }
}

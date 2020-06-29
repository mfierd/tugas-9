using System;
using System.Collections.Generic;
using System.Text;

namespace tugas9.Class
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return this.UpahPerJam * this.JumlahJamKerja;
        }
    }
}

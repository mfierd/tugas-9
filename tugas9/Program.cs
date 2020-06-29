using System;
using System.Collections.Generic;
using System.Threading;
using tugas9.Class;

namespace tugas9
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Karyawan> karyawan = new List<Karyawan>();

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "2789";
            karyawanTetap.Nama = "Udin";
            karyawanTetap.GajiBulanan = 1000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "2889";
            karyawanHarian.Nama = "UdinN";
            karyawanHarian.UpahPerJam = 60000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "2989";
            sales.Nama = "UdinS";
            sales.JumlahPenjualan = 15;
            sales.Komisi = 80000;

            karyawan.Add(karyawanTetap);
            karyawan.Add(karyawanHarian);
            karyawan.Add(sales);

            Menu(karyawan);
        }

        static void Menu(List<Karyawan> karyawan)
        {
            bool status = true;

            do
            {
                Console.Clear();
                Console.WriteLine("======= PROGRAM GAJI KARYAWAN =======");
                Console.WriteLine("");

                Console.WriteLine("Silahkan Pilih Menu : ");
                Console.WriteLine("1. Tambah Data\n2. Hapus Data \n3. Tampilkan Data \n4. Keluar");

                Console.WriteLine("");

            InvalidOption:
                string opt;
                Console.Write("Masukkan Pilihan [1-4]: ");
                opt = Console.ReadLine();


                if (opt == "1")
                {
                    TambahData(karyawan);

                }
                else if (opt == "2")
                {
                    HapusData(karyawan);

                }
                else if (opt == "3")
                {
                    TampilkanData(karyawan);

                }
                else if (opt == "4")
                {
                    Console.WriteLine("Menutup program...");
                    Thread.Sleep(2000);
                    status = false;
                }
                else
                {
                    // handle data jika inputan tidak valid
                    Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                    goto InvalidOption;
                }

            } while (status);
        }

        static void TambahData(List<Karyawan> karyawan)
        {
            // menghapus / clear console
            Console.Clear();

            // menampilkan jenis karyawan
            Console.WriteLine("========== TAMBAH KARYAWAN ==========");
            Console.WriteLine("");
            Console.WriteLine("\nSilahkan Pilih Jenis Karyawan: ");
            Console.WriteLine("1. Karyawan Tetap \n2. Karyawan Harian \n3. Sales");

        // input pilihan tambah karyawan
        InvalidOption:
            string opt;
            Console.Write("Masukkan Pilihan [1-3]: ");
            opt = Console.ReadLine();

            Console.WriteLine();

            if (opt == "1")
            {
                KaryawanTetap karyawanTetap = new KaryawanTetap();

                Console.WriteLine("Tambah Karyawan Tetap");
                Console.Write("Masukkan NIK \t\t: ");
                karyawanTetap.NIK = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                karyawanTetap.Nama = Console.ReadLine();

                Console.Write("Masukkan Gaji Bulanan \t: ");
                karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                karyawan.Add(karyawanTetap);

            }
            else if (opt == "2")
            {
                KaryawanHarian karyawanHarian = new KaryawanHarian();

                Console.WriteLine("Tambah Karyawan Harian");
                Console.Write("Masukkan NIK \t\t: ");
                karyawanHarian.NIK = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                karyawanHarian.Nama = Console.ReadLine();

                Console.Write("Masukkan Upah per Jam \t: ");
                karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Jam Kerja \t: ");
                karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                karyawan.Add(karyawanHarian);

            }
            else if (opt == "3")
            {
                Sales sales = new Sales();

                Console.WriteLine("Tambah Karyawan Harian");

                Console.Write("Masukkan NIK \t\t: ");
                sales.NIK = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                sales.Nama = Console.ReadLine();

                Console.Write("Masukkan Jml Penjualan \t: ");
                sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Komisi \t: ");
                sales.Komisi = Convert.ToDouble(Console.ReadLine());

                karyawan.Add(sales);
            }
            else
            {
                Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                goto InvalidOption;
            }
        }

        static void HapusData(List<Karyawan> karyawan)
        {
            Console.Clear();
            Console.WriteLine("======== HAPUS DATA KARYAWAN ========");
            bool found = true;

            string nik;
            Console.Write("\nMasukkan NIK Karyawan: ");
            nik = Console.ReadLine();

            for (int i = 0; i < karyawan.Count; i++)
            {
                if (karyawan[i].NIK == nik)
                {
                    karyawan.Remove(karyawan[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data tidak dengan NIK = {0} tidak ditemukan", nik);
            }
            else
            {
                Console.WriteLine("Data dengan NIK = {0} berhasil dihapus", nik);
            }
        }

        static void TampilkanData(List<Karyawan> karyawan)
        {
            Console.Clear();

            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji\t\t |");
            Console.WriteLine("");
            for (int i = 0; i < karyawan.Count; i++)
            {

                Console.WriteLine(" {0}. | {1} {2} \t\t | {3} \t |", i + 1, karyawan[i].NIK, karyawan[i].Nama, karyawan[i].Gaji());
            }

        }

        static void BalikMenu()
        {
            // Funtion untuk balik ke menu awal
            Console.WriteLine("\nTekan sembarang untuk kembali ke menu awal");
            Console.ReadKey();
        }
    }
}
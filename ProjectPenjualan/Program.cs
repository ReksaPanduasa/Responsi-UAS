using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
        public string Code { get; set; }
        public string Tanggal { get; set; }
        public string Nama { get; set; }
        public string Jenis { get; set; }
        public string Total { get; set; }
    }
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                Console.Clear();
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }
        static void TampilMenu()
        {
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            string Nota, tanggal, Customer, jenis, total;

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota       : ");
            Nota = Console.ReadLine();

            Console.Write("Tanggal    : ");
            tanggal = Console.ReadLine();

            Console.Write("Customer    : ");
            Customer = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            jenis = Console.ReadLine();

            Console.Write("Total Nota : ");
            total = Console.ReadLine();

            if (jenis == "T" || jenis == "t")
            {
                jenis = "Tunai";
            }
            else
            {
                jenis = "Kredit";
            }
            daftarPenjualan.Add(new Penjualan() { Code = Nota, Tanggal = tanggal, Nama = Customer, Jenis = jenis, Total = total });
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");
            int no = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, daftar.Code, daftar.Tanggal, daftar.Nama, daftar.Jenis, daftar.Total);
                no++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rental1> daftarRental = new List<Rental1>();

            void PS3 (string nama, double jam, double biaya, string jenis)
            {
                daftarRental.Add(new PS3 { NAMA = nama, JamMain = jam, Biaya = biaya, JENIS = jenis });
            }

            void PS4(string nama, double jam, double biaya, string jenis)
            {
                daftarRental.Add(new PS4 { NAMA = nama, JamMain = jam, Biaya = biaya, JENIS = jenis });
            }

            Console.Title = "Program Rental PlayStation";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tPilihan Menu :");
                Console.WriteLine("\t1. Masukkan data  ");
                Console.WriteLine("\t2. Hapus Data  ");
                Console.WriteLine("\t3. Tampilkan  ");
                Console.WriteLine("\t4. Keluar  \n");
                Console.Write("\tPillihan Anda [1..4] =  ");
                int pilih = int.Parse(Console.ReadLine());
                Console.Clear();
                if (pilih < 1 || pilih > 4)
                {
                    Console.WriteLine("\tPilihan tidak tersedia");
                }
                else if (pilih == 1)
                {
                    AboutK();
                    Console.WriteLine("\tTambah data pelanggan");
                    Console.WriteLine("\tPilih Playstion yang anda mainkan");
                    Console.WriteLine("\t1. PS3 \t2.PS4");
                    Console.Write("\tPilihan anda [1..2] = ");
                    int pil = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (pil == 1)
                    {
                        Console.Write("\tNama pelanggan : ");
                        string nama = Console.ReadLine();
                        Console.Write("\tLama main : ");
                        double jam = int.Parse(Console.ReadLine());
                        double biaya = 4000;
                        Console.Write("\tJenis : {0}", pil);
                        string jenis = "PS3";
                        double diskon;
                        if (jam > 2) 
                        {
                            diskon = biaya * 0.10;
                        
                        }
                        else 
                        {
                            diskon = 0; 
                        }
                        biaya = biaya - diskon;

                        PS3(nama, jam, biaya, jenis);
                    }
                    else if (pil == 2)
                    {
                        Console.Write("\tNama pelanggan : ");
                        string nama = Console.ReadLine();
                        Console.Write("\tLama main : ");
                        double jam = int.Parse(Console.ReadLine());
                        double biaya = 6000;
                        Console.Write("\tJenis : {0}", pil);
                        string jenis = "PS4";
                        double diskon;
                        if (jam > 2) 
                        {
                            diskon = biaya * 0.20;

                        }
                        else
                        {
                            diskon = 0;
                        }
                        biaya = biaya - diskon;

                        PS4(nama, jam, biaya, jenis);

                    }
                    else
                    {
                        Console.WriteLine("\tPilihan tidak tersedia");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\n\tTekan ENTER untuk kembali ke menu");
                    Console.ReadKey();
                }
                else if (pilih == 2)
                {
                    Hapus();
                }
                else if (pilih == 3)
                {
                    Tampilkan();
                }
                else
                {
                    Console.WriteLine("\tPilihan tidak tersedia");
                }
            }
            void Hapus()
            {
                Console.Clear();
                int x = 0;
                Console.WriteLine("Hapus Data Pelanggan");
                foreach (Rental1 rental in daftarRental)
                {
                    x++;
                    Console.WriteLine("{0}. {1}", x, rental.NAMA);
                }
                int n = -1, del = -1;
                Console.Write("Nama : ");
                string NAMA = Console.ReadLine();
                foreach (Rental1 rental in daftarRental)
                {
                    n++;
                    if (rental.NAMA == NAMA)
                    {
                        del = n;
                    }
                }
                if (del != -1)
                {
                    daftarRental.RemoveAt(del);
                    Console.WriteLine("\tData dihapus");
                }
                else
                {
                    Console.WriteLine("\tTidak ada data");
                }
                Console.WriteLine("\tTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }
            void Tampilkan()
            {
                Console.Clear();
                int no = 0; 
                Console.WriteLine("Data ");
                Console.WriteLine();
                foreach (Rental1 rental in daftarRental)
                {
                    no++;
                    Console.WriteLine(" {0}. Nama : {1}, Jenis : {2}, Lama Main : {3} jam, Jumlah : {4} ", no, rental.NAMA, rental.JENIS, rental.JamMain, rental.JUMLAH());
                }
                if (no < 1)
                {
                    Console.WriteLine("Data Pelanggan Kosong");
                }
                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
            void AboutK()
            {
                Console.Clear();
                Console.WriteLine("\t\t===============Price List==================");
                Console.WriteLine("\t\t||     PS3          |          PS4       ||");
                Console.WriteLine("\t\t|| 1 jam  Rp.4000   | 1 jam Rp.6000      ||");
                Console.WriteLine("\t\t|| 2 jam  Rp.8000   | 2 jam Rp.12000     ||");
                Console.WriteLine("\t\t|| >2 jam  disc 10% | >2 jam disc 20%    ||");
                Console.WriteLine("\t\t===========================================");
                Console.WriteLine("\t\t     Tekan sembarang untuk melanjutkan     ");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}


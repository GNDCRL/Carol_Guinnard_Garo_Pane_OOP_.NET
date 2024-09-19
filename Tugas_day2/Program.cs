using System;
using System.Collections.Generic;

namespace UserManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Customer
            Customer carol = new Customer("Carol");
            Customer rian = new Customer("Rian");

            // Mengatur saldo awal
            carol.AddSaldo(1000000);
            rian.AddSaldo(500000);

            Admin admin = null;
            Customer customer = null;

            while (true)
            {
                // Memilih role
                Console.WriteLine("================================================= ");
                Console.WriteLine("================== SYSTEM DAY 2 ================== ");
                Console.WriteLine("================================================= ");
                Console.WriteLine("Pilih role anda!");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Keluar");
                Console.WriteLine();
                Console.Write("Masukkan pilihan: ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("=== Logout ====");
                    break;
                }

                if (choice == "1")
                {
                    Console.Write("Masukkan nama Admin: ");
                    string namaAdmin = Console.ReadLine();
                    admin = new Admin(namaAdmin);

                    Console.WriteLine("Pilih salah satu customer! ");
                    Console.WriteLine("1. Carol ");
                    Console.WriteLine("2. Rian ");
                    Console.Write("Masukan Nama ->> ");

                    string namaCustomer = Console.ReadLine();

                    if (namaCustomer == "Carol")
                    {
                        customer = carol;
                    }
                    else if (namaCustomer == "Rian")
                    {
                        customer = rian;
                    }
                    else
                    {
                        Console.WriteLine("Nama customer tidak valid.");
                        continue;
                    }

                    Console.WriteLine();
                    Console.Write("Masukkan jumlah saldo yang ingin ditambahkan: Rp. ");
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        try
                        {
                            admin.AddEMoney(customer, amount);
                            Console.WriteLine($"{customer.Nama} memiliki saldo setelah penambahan: Rp. {customer.GetEMoney()}");
                            Console.WriteLine();
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Jumlah saldo tidak valid.");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Pilih salah satu customer: ");
                    Console.WriteLine("1. Carol");
                    Console.WriteLine("2. Rian");
                    Console.Write("Masukkan nama: ");
                    string namaCustomer = Console.ReadLine();

                    if (namaCustomer == "Carol")
                    {
                        customer = carol;
                    }
                    else if (namaCustomer == "Rian")
                    {
                        customer = rian;
                    }
                    else
                    {
                        Console.WriteLine("Nama customer tidak valid.");
                        continue;
                    }

                    // Menampilkan saldo customer
                    Console.WriteLine($"{customer.Nama} memiliki saldo: Rp. {customer.GetEMoney()}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }
            }
        }
    }
}

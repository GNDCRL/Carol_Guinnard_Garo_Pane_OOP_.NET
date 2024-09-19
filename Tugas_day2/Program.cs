using System;
using System.Collections.Generic;

namespace UserManagement
{
    // Kelas User sebagai kelas dasar
    public class User
    {
        // Atribut 
        public string Nama { get; set; }
        public string Role { get; set; }
        protected double eMoney; 

        // Konstruktor untuk inisiasi User
        public User(string nama, string role)
        {
            Nama = nama;
            Role = role;
            eMoney = 0;
        }

        // Method saldo
        public double GetEMoney()
        {
            return eMoney;
        }
    }








    // Kelas Admin 
    public class Admin : User
    {
        // Konstruktor untuk inisiasi Admin
        public Admin(string nama) : base(nama, "Admin")
        {
        }

        // Method untuk menambah saldo customer
        public void AddEMoney(Customer customer, double amount)
        {
            if (amount > 0)
            {
                customer.AddSaldo(amount);
            }
            else
            {
                throw new ArgumentException("Jumlah saldo harus lebih dari 0");
            }
        }
    }



    // Kelas Customer
    public class Customer : User
    {
        // Konstruktor untuk inisiasi Customer
        public Customer(string nama) : base(nama, "Customer")
        {
        }

        // Method untuk jumlah saldo
        internal void AddSaldo(double amount)
        {
            eMoney = eMoney + amount;
        }
    }

 





    class Program
    {
        static void Main(string[] args)
        {
            //objek Admin dan Customer
            Customer carol = new Customer("Carol");
            Customer rian = new Customer("Rian");
            carol.AddSaldo(10000); 
            rian.AddSaldo(5000);   

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
                    Console.WriteLine("Carol ");
                    Console.WriteLine("Rian ");
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
                    Console.Write("Pilih salah satu customer! ");
                    Console.WriteLine("Carol");
                    Console.WriteLine("Rian");
                    Console.Write("MAsukan nama: ");
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

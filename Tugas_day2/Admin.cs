using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_day2;

namespace UserManagement
{
    // Kelas Admin yang merupakan turunan dari kelas User
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
                customer.AddSaldo(amount); // Menambah saldo customer
            }
            else
            {
                throw new ArgumentException("Jumlah saldo harus lebih dari 0");
            }
        }
    }
}

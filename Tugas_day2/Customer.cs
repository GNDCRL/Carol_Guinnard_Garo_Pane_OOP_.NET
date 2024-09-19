using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    // Kelas Customer yang merupakan turunan dari kelas User
    public class Customer : User
    {
        // Konstruktor untuk inisiasi Customer
        public Customer(string nama) : base(nama, "Customer")
        {
        }

        // Method untuk menambah saldo
        internal void AddSaldo(double amount)
        {
            eMoney += amount;
        }
    }
}

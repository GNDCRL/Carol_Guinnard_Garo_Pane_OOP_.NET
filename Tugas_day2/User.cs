using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    // Kelas User sebagai kelas dasar
    public class User
    {
        // Atribut 
        public string Nama { get; set; }
        public string Role { get; set; }
        protected double eMoney; // Saldo eMoney

        // Konstruktor untuk inisiasi User
        public User(string nama, string role)
        {
            Nama = nama;
            Role = role;
            eMoney = 0;
        }

        // Method untuk mendapatkan saldo
        public double GetEMoney()
        {
            return eMoney;
        }
    }
}

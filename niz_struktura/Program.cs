using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niz_struktura
{
    internal class Program
    {
        public struct Ucenik {
            public string ime;
            public double prosek;
            public Ucenik(string ime, double prosek)
            {
                this.ime = ime;
                this.prosek = prosek;
            }
            public void PrikaziPodatke()
            {
                Console.WriteLine($"Ucenik: {ime, -15}, Prosek: {prosek:f2}");
            }

        }

        
        static void Main(string[] args)
        {
            Console.Write("Unesite broj ucenika: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Ucenik[] Odeljenje = new Ucenik[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nUnos za {i + 1}. ucenika: ");
                Console.Write("Ime: ");
                string ime = Console.ReadLine();
                Console.Write("Prosek: ");
                double prosek = Convert.ToDouble(Console.ReadLine());
                Odeljenje[i] = new Ucenik(ime, prosek);
            }

            foreach (Ucenik u in Odeljenje)
            {
                u.PrikaziPodatke();
            }
        }
    }
}

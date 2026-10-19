using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pr_1_konstruktori
{
    internal class Program
    {

        struct Racionalan
        {
            public int brojilac;
            public int imenilac;
            
        }
        //kon sa parametrima
        public Racionalan(int brojilac, int imenilac)
        {
            this.brojilac = brojilac;
            this.imenilac = imenilac;
        }
        // Metoda unutar strukture za jednostavno ispisivanje
        public void Ispisi()
        {
            Console.WriteLine($"{brojilac}/{imenilac}");
        }

        static void Main(string[] args)
        {
            Racionalan r1 = new Racionalan();
            r1.brojilac = 3;
            r1.imenilac = 4;

            Racionalan r2 = new Racionalan(5, 6);

            Racionalan r3 = new Racionalan { brojilac = 2, imenilac = 5 };

            Racionalan r4;
            r4.brojilac = 3;
            r4.imenilac = 4;
            Console.WriteLine("Prikaz razlomaka:");
            Console.WriteLine("r1 = ");
            r1.Ispisi();
            Console.WriteLine("r2 = ");
            r2.Ispisi();
            Console.WriteLine("r3 = ");
            r3.Ispisi();
            Console.WriteLine("r4 = ");
            r4.Ispisi();
            Racionalan r5 = r1;
            Console.WriteLine("r5 = ");
            r5.Ispisi();
            r5.brojilac = 9;
            r5.imenilac = 5;
            Console.WriteLine("Novo r5 = ");

        }
    }
}

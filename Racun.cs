using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    class Racun : IRacun
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public double stanje { get; set; }

        public Racun(string ime, string prezime, double iznos)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.stanje = iznos;
        }

        // metoda iz interfejsa IRacun koja vraca Stanje
        public double Stanje
        {
            get
            {
                return this.stanje;
            }
        }

        // metoda iz interfejsa IRacun koja dodaje iznos
        public void Uplata(double iznos)
        {
            this.stanje += iznos;
        }

        // metoda iz interfejsa IRacun koja oduzima iznos
        public void Isplata(double iznos)
        {
            if(this.stanje - iznos < 0)
            {
                Console.WriteLine("Nedovoljno sredstava na racunu!");
            }
            else
            {
                this.stanje -= iznos;
            }
        }

        // ispis u konzoli
        public void stampaj()
        {
            Console.WriteLine($"Ime: {this.Ime}\nPrezime: {this.Prezime}\nStanje: {this.stanje}");
        }
    }
}

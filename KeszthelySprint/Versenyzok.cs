using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    internal class Versenyzok
    {
        public string Nev { get; set; }
        public int Szuletes { get; set; }
        public int Rajtszám { get; set; }
        public string Kategoria { get; set; }
        public string Eletkor { get; set; }
        public string Nem { get; set; }
        public string ido { get; set; }
        public string ido2 { get; set; }
        public string ido3 { get; set; }
        public string ido4 { get; set; }
        public string ido5 { get; set; }
        

        public Versenyzok(string sor)
        {
            string[] A = sor.Split(';');
            Nev = A[0];
            Szuletes = int.Parse(A[1]);
            Rajtszám = int.Parse(A[2]);
            Kategoria = A[4];
            Nem = A[3];
            Eletkor = (A[5]);
            ido = A[6];
            ido2 = A[7];
            ido3 = A[8];
            ido4 = A[9];
            
        }
    }
}

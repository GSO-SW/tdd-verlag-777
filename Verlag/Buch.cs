using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        public int Auflage
        {
            get { return auflage; }
            set
            {
                auflage = value; if (value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string ISBN
        {
            get { return isbn; }
            set {  isbn = value; }
        }

        public Buch(string autor, string titel, int auflage = 1)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;
            if(auflage < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}

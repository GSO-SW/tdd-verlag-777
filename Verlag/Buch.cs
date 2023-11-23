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
        private string iSBN;

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
                if (value > 0)
                {
                    auflage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner als 1 sein.");
                }
            }
        }
        public string ISBN
        {
            get { return iSBN; }
            set { iSBN = value; }
        }


        public Buch(string autor, string titel, int auflage = 1)
        {
            switch (autor)
            {
                case "#": throw new ArgumentNullException("Unpassender Name");
                    break;
                case "$": throw new ArgumentNullException("Unpassender Name");
                    break;
                case "": throw new ArgumentNullException("Unpassender Name");
                    break;
                case "%": throw new ArgumentNullException("Unpassender Name");
                    break;
                case ";": throw new ArgumentNullException("Unpassender Name");
                    break;
                case null: throw new ArgumentNullException("Unpassender Name");
                    break;

            }
            this.titel = titel;
            this.auflage = auflage;
        }

        public Buch(string iSBN) : this( autor, titel, auflage)
        { 
            this.iSBN = iSBN;
        
        }

      

    }
}

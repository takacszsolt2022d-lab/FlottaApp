using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Jarmu
    {

        public string Rendszam { get; set; }

        protected int alapar { get; set; }

        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value <= 0)
                {
                    alapar=1000000;
                }
                
            }
        }
        private static int osszesJarmuSzama;

        public static int OsszesJarmuSzama { get; }

        public Jarmu(string rendszam,int alapa)
        {
            Rendszam = rendszam;
            alapar = alapa;
            osszesJarmuSzama++;
        }
        public virtual int Adokalkulacio()
        {
            return (alapar/100)*5;
        }

        public override string ToString()
        {
            return $"Jármű {Rendszam} | Alapár: {Alapar} Ft | Adó:{Adokalkulacio()} Ft";
        }


    }
}

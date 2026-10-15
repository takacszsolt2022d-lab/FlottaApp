using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Teherauto : Jarmu
    {
        public double Teherbiras { get; set; }
        public Teherauto(string rendszam,int alapa,double teherbiras) :base(rendszam, alapa)
        {
            Teherbiras = teherbiras;
        }

        public override int Adokalkulacio()
        {
            return (base.Adokalkulacio() + Convert.ToInt32(Teherbiras * 10000));
        }
        public override string ToString()
        {
            return base.ToString() + $"| Teherbírás: {Teherbiras} t" ;
        }
    }
}

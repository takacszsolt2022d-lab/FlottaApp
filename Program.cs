using FlottaApp;
using System.IO;


List<Jarmu> jarmuvek = new List<Jarmu>();
int hibassrorkSzama = 0;



foreach (string sor in File.ReadAllLines("jarmuvek.csv").Skip(1))
{
    if(string.IsNullOrWhiteSpace(sor))
    {
        hibassrorkSzama++;
        continue;

    }
    string[] adatok = sor.Split(';');

    if (adatok.Length != 4)
    {
        hibassrorkSzama++;
        continue;
    }

    string tipus = adatok[0];
    string rendszam = adatok[1];

    if (tipus != "J" || tipus != "T" || string.IsNullOrWhiteSpace(rendszam))
    {
        hibassrorkSzama++;
        continue;
    }
    if(!int.TryParse(adatok[2],out int alapar))
    {
        hibassrorkSzama++;
        continue;
    }
    if(tipus == "J")
    {
        Jarmu jarmu = new Jarmu(rendszam, alapar);
        jarmuvek.Add(jarmu);
    }
    if(tipus == "T")
    {
        Teherauto jarmu = new Teherauto(rendszam, alapar, teherbiras);
        jarmuvek.Add(jarmu);
    }


    Console.WriteLine(hibassrorkSzama);
    Console.WriteLine(jarmuvek);
 }
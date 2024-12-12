using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20241212_eb2022
{
    class Jatekos
    {
        public int gol, kapLov, siker7m, osz7m, kiall, magassag;
        public string nev, poszt, csapat, dateTime;


        public Jatekos(string adat)
        {
            string[] darabok = adat.Split(';');
            nev = darabok[0];
            gol = int.Parse(darabok[1]);
            kapLov = int.Parse(darabok[2]);
            siker7m = int.Parse(darabok[3]);
            osz7m = int.Parse(darabok[4]);
            kiall = int.Parse(darabok[5]);
            poszt = darabok[6];
            dateTime = darabok[7];
            magassag = int.Parse(darabok[8]);
            csapat = darabok[9];
        }
    }
    class Program
    {
        static List<Jatekos> jatekosok = new List<Jatekos>();
        static void Main(string[] args)
        {
            f1();
            f2();
            f3();
            f4();
            f5();
            f6();
            f7();
            f8();
            /*
                        f9();
                        f10();
                        f11();
                        f12();
                        f13();
                        f14();
                        f15();
                        f16();
                        */
            Console.ReadKey();
        }

        static void f1()
        {
            string[] Beolvas = File.ReadAllLines("kezieb.txt");
            foreach (var item in Beolvas)
            {
                jatekosok.Add(new Jatekos(item));
            }
            Console.WriteLine("1. feladat: Az adatok sikeresen belettek olvasva!");
        }

        static void f2()
        {
            Console.WriteLine($"\n2. feladat: \nA magyar csapatban {jatekosok.Count()} mezőnyjátékos szerepelt.");
        }

        static void f3()
        {
            Console.WriteLine("\n3. Feladat: Beállók:");
            foreach (var item in jatekosok)
            {
                if (item.poszt == "beálló")
                {
                    Console.WriteLine($" - {item.nev}");
                }
            }
        }
        static void f4()
        {
            Console.WriteLine("\n4. Feladat: A játékosokat adó csapatok:");
            List<string> csapatok = new List<string>();
            foreach (var item in jatekosok)
            {
                if (!csapatok.Contains(item.csapat))
                {
                    csapatok.Add(item.csapat);
                }
            }
            foreach (var csapat in csapatok)
            {
                Console.WriteLine($" - {csapat}");
            }
        }
        static void f5()
        {
            Console.WriteLine("\n5. Feladat: Öt gólnál többet dobtak:");
            foreach (var item in jatekosok)
            {
                if (item.gol > 5)
                {
                    Console.WriteLine($" - {item.nev}");
                }
            }
        }
        static void f6()
        {
            int OszGol = 0;
            int osz7m = 0;
            foreach (var item in jatekosok)
            {
                OszGol += item.gol;
                osz7m += item.siker7m;
            }
            Console.WriteLine($"\n6. Feladat: \nA magyar csapat összesen {OszGol} gólt lőtt, ebből {osz7m} hétméterest.");
        }
        static void f7()
        {
            int Dob7m = 0;
            foreach (var item in jatekosok)
            {
                if (item.osz7m > 0)
                {
                    Dob7m++;
                }
            }
            Console.WriteLine($"\n7. Feladat: {Dob7m} játékos dobott hétméterest.");
        }
        static void f8()
        {
            int kiall = 0;
            foreach (var item in jatekosok)
            {
                kiall += item.kiall;
            }
            Console.WriteLine($"\n8. feladat: {kiall*2} perc büntetést kapott a csapat.");
        }
    }
}

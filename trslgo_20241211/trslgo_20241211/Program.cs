using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trslgo_20241211
{
    class Tarsalgo
    {
        public int ora, perc, id;
        public string irany;

        public Tarsalgo(string egysor)
        {
            string[] darabok = egysor.Trim().Split(' ');
            ora = int.Parse(darabok[0]);
            perc = int.Parse(darabok[1]);
            id = int.Parse(darabok[2]);
            irany = darabok[3];
        }
    }
    class Program
    {
        static List<Tarsalgo> tarsalgos = new List<Tarsalgo>();
        static void Main(string[] args)
        {
            f1();
            f2();
            Console.ReadKey();
        }

        static void f1()
        {
            string[] beolvas = File.ReadAllLines("ajto.txt", Encoding.Default);
            foreach (var item in beolvas)
            {
                tarsalgos.Add(new Tarsalgo(item));
            }
        }

        static void f2()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace systemIo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();

            //provjera da li direktorij postoji
            if (Directory.Exists(putanja))
            {
                //ako postoji zapisujemo sve u njega
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }

            }
            string putanjaPodDirektorija = putanja + "\\Test";

            if (!Directory.Exists(putanjaPodDirektorija))
            {
                Directory.CreateDirectory(putanjaPodDirektorija);
            }
            else
            {
                Console.WriteLine("Direktorij već postoji");
            }


            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Poddirektoriji: ");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            Directory.Delete(putanjaPodDirektorija);

            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Nakon brisanja: ");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
            Console.ReadKey();
        }
    }
}

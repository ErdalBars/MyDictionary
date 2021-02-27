using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(1, "Ahnet");
            ogrenciler.Add(2, "Ali");
            ogrenciler.Add(3, "Bilal");
            ogrenciler.Add(4, "Naim");
            ogrenciler.Add(5, "Sevinç");

            for (int i = 0; i < ogrenciler.Count(); i++)
            {
                Console.WriteLine(ogrenciler.keys[i] + " " + ogrenciler.values[i]);
            }


            Console.WriteLine("Öğrenci sayısı :" + ogrenciler.Count());



        }
    }
}

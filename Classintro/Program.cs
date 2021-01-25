using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C";
            kurs1.Eğitmen = "Engin Demir";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Berkay Bilgin"
            kurs3.IzlenmeOrani = 80;


            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);


            Kurs[] kurslar = new Kurs[] { lurs1, kurs2, kurs, };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);

            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen {get; set; }
        public string IzlenmeOrani { get; set; }

    }


    }
}

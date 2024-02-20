
using System;
using Business.Concrete;
using Entities.Concrete;


namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Murat");
            SelamVer(isim: "Ali");
            SelamVer(isim: "Ayşe");

            int sonuc = Topla(3, 5);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {

            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Murat";
            person1.LastName = "Öztin";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Engin";




            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };

            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);

            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer(string isim)
        {
            Console.WriteLine("Merhaba" + isim);
        }

        // burada olduğu gibi eğer default değer verirsek, topla fonksiyonunun kullanıldığı
        // yerde değişken girmezse bizim yazdığımız default alınarak işleme devam edilir

        //static int Topla(int sayi1 =20, int sayi2=10)
        //{

        //    int sonuc = sayi1 + sayi2;
        //    Console.WriteLine("Toplam" + sonuc.ToString());
        //    return sonuc;
        //}
        static int Topla(int sayi1, int sayi2)
        {

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam" + sonuc.ToString());
            return sonuc;
        }


        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000;

            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Murat";
            string soyad = "Öztin";
            int dogumyili = 2000;
            long tcno = 12345678910;


            Console.WriteLine(tutar);

            Console.WriteLine(mesaj);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Dogumyili { get; set; }
        public long tcno { get; set; }

    }

}
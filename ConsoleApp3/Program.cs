using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Depo<T>
    {
        List<T> List = new List<T>();

        public void Ekle(T t)
        {
            List.Add(t);
        }
        public void Sil(T t)
        {
            List.Remove(t);
        }
        public List<T> Listele()
        {
            return List;
        }
        
    }
    class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdı { get; set; }
        public double Fiyat { get; set; }
        public override string ToString() //polymorphism***aynı isimli metodun farklı sınıflarda farklı şekillerde çalışmasıydı.
        {
            return UrunID + " " + UrunAdı + " " + Fiyat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Class

            //Soru1:Depo isimli generic bir liste oluşturup ekleme ,listeleme ve cıkarma islemlerini yapan kodu yazınız.
            Depo<Urun> depo = new Depo<Urun>();

            depo.Ekle(new Urun { UrunID = 11, UrunAdı = "Pergel", Fiyat = 55 });
            depo.Ekle(new Urun { UrunID = 15, UrunAdı = "Gönye", Fiyat = 25 });
            depo.Ekle(new Urun { UrunID = 16, UrunAdı = "T-Cetveli", Fiyat = 35 });

            Urun u1 = new Urun { UrunID = 17, UrunAdı = "Cetvel", Fiyat = 15 };

            
            depo.Ekle(u1);

            foreach (Urun urun in depo.Listele())
            {
                Console.WriteLine(urun);
            }

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*");

            depo.Sil(u1);
            foreach (Urun urun in depo.Listele())
            {
                Console.WriteLine(urun);
            }
        }

    }
}

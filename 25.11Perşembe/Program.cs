using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11Perşembe
{
    
    class Program
    {
        static void Yaz(int[] dizi,string[] dizi2,double[] dizi3)
        {
            foreach (int s in dizi)
            {
                Console.WriteLine(s);
            }
            foreach (string s in dizi2)
            {
                Console.WriteLine(s);
            }
            foreach (double s in dizi3)
            {
                Console.WriteLine(s);
            }
        }
        static void Yazdır<T>(T[] dizi)
        {
            foreach (T s in dizi)
                Console.WriteLine(s);
        }
        //static void Yaz(string[] dizi)
        //{
        //    foreach (string s in dizi)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
        //static void Yaz(double[] dizi)
        //{
        //    foreach (double s in dizi)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
        static void Main(string[] args)
        {
            /*
            GENERİC(JENERİK):
            Faydası:performans farkı var,çok hızlı. Tip güvenliği 
            */
            int[] sayilar = { 34, 45, 6, 7, 555 };
            string[] sehirler = { "Adana", "Bursa", "Ankara", "Denizli" };
            double[] fiyatlar = { 22.99, 33.6, 24.25 };

            //Yaz(sayilar,sehirler,fiyatlar);
            //Yaz(sehirler);
            //Yaz(fiyatlar);

            Yazdır(sayilar);
            Yazdır<string>(sehirler);
            Yazdır<double>(fiyatlar);
            
        }
    }
}

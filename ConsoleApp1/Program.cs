using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Performans
            DateTime basla, bitir;
            TimeSpan fark;


            ArrayList liste1 = new ArrayList();
            List<int> liste2 = new List<int>();
           
            basla = DateTime.Now;
            for (int i = 0; i < 99999999; i++)
            {
                liste1.Add(i);
                int sayi = (int)liste1[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine("ArrayList{0}",fark.TotalMilliseconds);


            basla = DateTime.Now;
            for (int i = 0; i < 99999999; i++)
            {
                liste2.Add(i);
                int sayi = liste2[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine("List<T> {0}", fark.TotalMilliseconds);

            //stackte tutulan referans tipli bir değişkenin değer tipli bir değişkene çevrilmesine unboxing,değer tipli bir değişkenin referans tipli bir değişkene çevrilmesine boxing denir.

            //generic ve arraylistin en büyük farkı arraylistin geriye uyumluluğu olduğu için ,arraylistin avantajı obje tipinde her şeyi kabul eder.
        }
    }
}

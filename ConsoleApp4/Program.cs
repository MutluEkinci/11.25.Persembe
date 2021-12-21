using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IKirilabilir
    {
    }
    class Cam : IKirilabilir { }
    class Lastik { }
    class Mudur : Personel
    {
    }
    class Personel
    {
    }
    class Urun
    {
    }
    class Test<T> where T : class
    {
    }
    class Deneme<T> where T : struct
    {
    }
    class PersonelDB<T> where T : Personel
    {
    }
    class Koli<T> where T : IKirilabilir { }
    class Beton
    {
        public Beton(string str)
        {
        }
    }
    class Tugla { }
    class Ev<T> where T : new()
    {
    }
    class Emened<T> where T : class, IKirilabilir, new()
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Generic Kısıtlar
            1-Class olabilir
            2-Struct olabilir.(int,string gibi tipler.)
            3-Miras olabilir.(yani o sınıftan türeyenleri kabul et.)
            4-Interface olabilir.
            5-****new()****(varsayılan ctoru olanlar olabilir.)
            Birden fazla kısıt uygulanabilir.new her zaman en sonda olmalı***
            */
            Test<Urun> t1 = new Test<Urun>();
            Test<Object> t2 = new Test<Object>();
            //Test<int> t3 = new Test<int>();//// HATAAAA!!! sadece class olabilir dedik 
            //Deneme<Urun> d1 = new Deneme<Urun>();
            //Deneme<Object> d2 = new Deneme<object>();//referans tipli değişkenler null olabilir ama structlar null değer alamaz.fakat nullable değişkenlerimiz var,istersek bunları kullanarak structları nullable yapabiliriz.
            Deneme<int> d3 = new Deneme<int>();

            PersonelDB<Mudur> db1 = new PersonelDB<Mudur>();
            //PersonelDB<Urun> db2 = new PersonelDB<Urun>();
            //PersonelDB<Object> db3 = new PersonelDB<object>();

            Koli<Cam> k1 = new Koli<Cam>();
            //Koli<Lastik> k2 = new Koli<Lastik>();

            //Ev<Beton> e1 = new Ev<Beton>();
            Ev<Tugla> e2 = new Ev<Tugla>();


            //value type değişkenler normal şartlar altında null değer alamaz.
            //int sayi = null;
            Nullable<int> sayi = new Nullable<int>();
            sayi = null;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi.GetValueOrDefault()); //stack ram bölgesi null değer kabul etmez.öyleymiş gibi kabul eder.

            int? id = null; // uzun uzun yazmak yerine int'in yanına "?" koy.

            Console.WriteLine(id??10);//"??" getvalueordefault tarzında.nullsa 10 ata demek.

            







        }
    }
}

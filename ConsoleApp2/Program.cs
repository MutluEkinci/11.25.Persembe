using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Tip Güvenliği(Type Safety)c#'ın en önemli konularından biri 

            ArrayList list1 = new ArrayList() { 1, 2, 3, "dort" };
            int toplam = 0;

            foreach (int obj in list1)//yanlıs ama hata mesajı vermiyor.int string toplanamaz.
                toplam += obj;

            Console.WriteLine(toplam);

            //List<int> liste2 = new List<int> { 1, 2, 3, "Dort" };

            //List<string> isimler = new List<string>();
            //isimler.Add()






        }
    }
}

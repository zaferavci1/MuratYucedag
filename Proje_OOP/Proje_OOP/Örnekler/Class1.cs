using Proje_OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OOP.Örnekler
{
    //sınıfların içerisindeki öğelere erişim sağlamak için 
    //sınıftan bir nesne üretilir
    public class Class1
    {
        public void Topla()
        {
            int sayi1 = 5, sayi2 = 8;
            int sonuc = sayi2 + sayi1;
        }
        public  void Carp()
        {
            int s1 = 5, s2 = 8, sonuc;
            sonuc = s1 * s2;
        }
    }
}

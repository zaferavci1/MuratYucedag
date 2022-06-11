using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OOP.Örnekler
{
    public class Sehirler:Bayrak
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Nufus { get; set; }
        public string Ulke { get; set; }
    }
}

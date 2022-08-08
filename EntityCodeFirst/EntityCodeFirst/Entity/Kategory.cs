using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Kategory
    {
        [Key]
        public int KetgoryId { get; set; }
        public string KategoryAd { get; set; }
        public ICollection<Urunler> Urunlers  { get; set; } 
        //1 kategori birden fazla urun alir

    }
}

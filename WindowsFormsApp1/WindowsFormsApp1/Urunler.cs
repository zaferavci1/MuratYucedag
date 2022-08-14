namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Urunler
    {
        [Key]
        public int UrunId { get; set; }

        public string UrunAd { get; set; }

        public string UrunMarka { get; set; }

        public string UrunKategori { get; set; }

        public int UrunStok { get; set; }

        public string Aciklama { get; set; }

        public int? Kategory_KetgoryId { get; set; }

        public virtual Kategory Kategory { get; set; }
    }
}

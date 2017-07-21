using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kuzey.Model.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; } = 0;
        public int KategoriId { get; set; }
        public bool SatistaMi { get; set; } = true;

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();
    }
}
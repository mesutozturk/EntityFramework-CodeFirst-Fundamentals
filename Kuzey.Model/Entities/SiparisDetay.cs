using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kuzey.Model.Entities
{
    [Table("SiparisDetaylari")]
    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }

        public decimal UrunFiyati { get; set; }
        public short Adet { get; set; }
        public double Indirim { get; set; }

        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }

        [ForeignKey("SiparisId")]
        public virtual Siparis Siparis { get; set; }

        public override string ToString()
        {
            return $"{Adet} x {Urun.UrunAdi} - {Adet * Urun.Fiyat * Convert.ToDecimal(1 - Indirim):c2}";
        }
    }
}
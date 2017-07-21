using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kuzey.Model.Entities
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int Id { get; set; }

        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public DateTime IstenenTarih { get; set; }
        public decimal Navlun { get; set; } = 0;

        [Required]
        [MaxLength(250)]
        public string Adres { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();
    }
}
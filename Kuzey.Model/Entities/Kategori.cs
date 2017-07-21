using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kuzey.Model.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        private string _kategoriAdi;

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string KategoriAdi
        {
            get => _kategoriAdi;
            set
            {
                foreach (var c in value)
                    if (char.IsDigit(c))
                        throw new Exception("Kategori Adında Rakam Bulunamaz!");
                _kategoriAdi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Aciklama { get; set; }
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;

        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();
    }
}
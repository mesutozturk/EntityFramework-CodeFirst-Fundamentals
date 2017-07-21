using System;
using System.Collections.Generic;
using System.Linq;
using Kuzey.DAL;
using Kuzey.Model.Entities;

namespace Kuzey.BLL
{
    public class KategoriRepo
    {
        public List<Kategori> TumKategorileriGetir()
        {
            return new MyContext().Kategoriler.ToList();
        }

        public void KategoriEkle(Kategori kategori)
        {
            try
            {
                var db = new MyContext();
                db.Kategoriler.Add(new Kategori
                {
                    KategoriAdi = kategori.KategoriAdi,
                    Aciklama = kategori.Aciklama
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void KategoriSil(Kategori kategori)
        {
            try
            {
                var db = new MyContext();
                var silinecek = db.Kategoriler.Find(kategori.Id);
                if (silinecek != null)
                {
                    db.Kategoriler.Remove(silinecek);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
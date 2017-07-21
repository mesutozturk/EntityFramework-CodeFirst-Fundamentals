using System;
using System.Collections.Generic;
using System.Linq;
using Kuzey.DAL;
using Kuzey.Model.Entities;

namespace Kuzey.BLL
{
    public class UrunRepo
    {
        public List<Urun> TumUrunleriGetir()
        {
            return new MyContext().Urunler.ToList();
        }

        public List<Urun> TumAktifUrunleriGetir()
        {
            return new MyContext().Urunler.Where(x => x.SatistaMi).ToList();
        }

        public List<Urun> KategorininUrunleriniGetir(Kategori kategori)
        {
            var kat = new MyContext().Kategoriler.Find(kategori.Id);
            return kat != null ? kat.Urunler : new List<Urun>();
        }

        public void UrunEkle(Urun urun)
        {
            var db = new MyContext();
            try
            {
                db.Urunler.Add(new Urun
                {
                    UrunAdi = urun.UrunAdi,
                    Fiyat = urun.Fiyat,
                    KategoriId = urun.KategoriId,
                    SatistaMi = urun.SatistaMi
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UrunSil(Urun urun)
        {
            var db = new MyContext();
            try
            {
                var silinecek = db.Urunler.Find(urun.Id);
                if (silinecek == null) return;
                silinecek.SatistaMi = false;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UrunGuncelle(Urun urun)
        {
            var db = new MyContext();
            try
            {
                var guncellenecek = db.Urunler.Find(urun.Id);
                if (guncellenecek == null) return;
                guncellenecek.SatistaMi = urun.SatistaMi;
                guncellenecek.KategoriId = urun.KategoriId;
                guncellenecek.Fiyat = urun.Fiyat;
                guncellenecek.UrunAdi = urun.UrunAdi;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Urun UrunBul(int id)
        {
            var db = new MyContext();
            try
            {
                return db.Urunler.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Urun> UrunBul(string arama)
        {
            var aranacak = arama.ToLower();
            var db = new MyContext();
            try
            {
                return db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(aranacak) ||
                                             x.Kategori.KategoriAdi.ToLower().Contains(aranacak)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
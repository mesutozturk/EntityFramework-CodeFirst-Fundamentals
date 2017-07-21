using System;
using System.Collections.Generic;
using System.Linq;
using Kuzey.DAL;
using Kuzey.Model.Entities;
using Kuzey.Model.ViewModels;

namespace Kuzey.BLL.Repository
{
    public class CategoryRepo : RepositoryBase<Kategori, int>
    {
    }

    public class ProductRepo : RepositoryBase<Urun, int>
    {
        public List<Urun> GetAllByCategory(Kategori kategori)
        {
            dbContext = new MyContext();
            var kat = dbContext.Kategoriler.Find(kategori.Id);
            return kat != null ? kat.Urunler : new List<Urun>();
        }

        public override void Delete(Urun entity)
        {
            dbContext = dbContext ?? new MyContext();
            try
            {
                var silinecek = dbContext.Urunler.Find(entity.Id);
                if (silinecek == null) return;
                silinecek.SatistaMi = false;
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Urun> ProductSearch(string key)
        {
            return GetAll()
                .Where(x => (x.UrunAdi.ToLower().Contains(key.ToLower()) ||
                             x.Kategori.KategoriAdi.ToLower().Contains(key.ToLower())) & x.SatistaMi)
                .ToList();
        }
    }

    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        public bool SiparisOlustur(Siparis yeniSiparis, List<SiparisDetay> sepet)
        {
            using (var db = new MyContext())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Siparisler.Add(yeniSiparis);
                        db.SaveChanges();
                        foreach (var item in sepet)
                        {
                            db.SiparisDetaylar.Add(new SiparisDetay
                            {
                                SiparisId = yeniSiparis.Id,
                                UrunId = item.UrunId,
                                Adet = item.Adet,
                                Indirim = item.Indirim,
                                UrunFiyati = item.UrunFiyati
                            });
                            db.SaveChanges();
                        }
                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }

        /*select s.Id as [SiparisID], k.KategoriAdi, u.UrunAdi, sd.Adet, sd.UrunFiyati, sd.Indirim, sd.Adet* sd.UrunFiyati*(1-sd.Indirim) [Toplam]
        from Urunler u
        join Kategoriler k  on k.Id=u.KategoriId
        join SiparisDetaylari sd on sd.UrunId= u.Id
        join Siparisler s on s.Id= sd.SiparisId
        */
        public List<SiparisRaporuViewModel> SiparisRaporu()
        {
            var db = new MyContext();
            //var siparisdetaylari = db.SiparisDetaylar;
            var rapor = from urun in db.Urunler
                join kategori in db.Kategoriler
                on urun.KategoriId equals kategori.Id
                join siparisdetay in db.SiparisDetaylar
                on urun.Id equals siparisdetay.UrunId
                join siparis in db.Siparisler
                on siparisdetay.SiparisId equals siparis.Id
                select new
                {
                    SiparisID = siparis.Id,
                    kategori.KategoriAdi,
                    urun.UrunAdi,
                    siparisdetay.Adet,
                    Fiyat = siparisdetay.UrunFiyati,
                    Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                    Indirim = 1 - siparisdetay.Indirim
                };
            var raporson = rapor.AsEnumerable().Select(x => new SiparisRaporuViewModel
            {
                SiparisID = x.SiparisID,
                Adet = x.Adet,
                UrunAdi = x.UrunAdi,
                Fiyat = x.Fiyat,
                KategoriAdi = x.KategoriAdi,
                Toplam = x.Toplam * Convert.ToDecimal(x.Indirim)
            });
            return raporson.ToList();
        }
        /*
        select s.Id as [SiparisID],k.KategoriAdi,sum( sd.Adet*sd.UrunFiyati*(1-sd.Indirim)) [Toplam] 
        from Urunler u
        join Kategoriler k  on k.Id=u.KategoriId
        join SiparisDetaylari sd on sd.UrunId=u.Id
        join Siparisler s on s.Id=sd.SiparisId
        group by s.Id,k.KategoriAdi
        order by s.Id
        */

        public List<KategoriSiparisRaporuViewModel> KategoriyeGoreSiparisRaporu()
        {
            var db = new MyContext();
            var rapor = from urun in db.Urunler
                join kategori in db.Kategoriler
                on urun.KategoriId equals kategori.Id
                join siparisdetay in db.SiparisDetaylar
                on urun.Id equals siparisdetay.UrunId
                join siparis in db.Siparisler
                on siparisdetay.SiparisId equals siparis.Id
                select new
                {
                    SiparisID = siparis.Id,
                    kategori.KategoriAdi,
                    urun.UrunAdi,
                    siparisdetay.Adet,
                    Fiyat = siparisdetay.UrunFiyati,
                    Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                    Indirim = 1 - siparisdetay.Indirim
                };

            var raporson = rapor.AsParallel()
                .GroupBy(x => new {x.SiparisID, x.KategoriAdi})
                .Select(x => new KategoriSiparisRaporuViewModel
                {
                    SiparisID = x.Key.SiparisID,
                    KategoriAdi = x.Key.KategoriAdi,
                    Toplam = x.Sum(y => Convert.ToDecimal(y.Indirim) * y.Toplam)
                })
                .OrderBy(x => x.SiparisID)
                .ToList();

            return raporson;
        }
        /*
        select s.Id as [SiparisID],sum( sd.Adet*sd.UrunFiyati*(1-sd.Indirim)) [Toplam] 
        from Urunler u
        join Kategoriler k  on k.Id=u.KategoriId
        join SiparisDetaylari sd on sd.UrunId=u.Id
        join Siparisler s on s.Id=sd.SiparisId
        group by s.Id
        order by s.Id

        */

        public List<SiparisToplamViewModel> SiparisToplamRaporu()
        {
            var db = new MyContext();
            var rapor = from urun in db.Urunler
                join kategori in db.Kategoriler
                on urun.KategoriId equals kategori.Id
                join siparisdetay in db.SiparisDetaylar
                on urun.Id equals siparisdetay.UrunId
                join siparis in db.Siparisler
                on siparisdetay.SiparisId equals siparis.Id
                select new
                {
                    SiparisID = siparis.Id,
                    kategori.KategoriAdi,
                    urun.UrunAdi,
                    siparisdetay.Adet,
                    Fiyat = siparisdetay.UrunFiyati,
                    Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                    Indirim = 1 - siparisdetay.Indirim
                };
            var raporson = rapor.AsParallel()
                .GroupBy(x => new {x.SiparisID})
                .Select(x => new SiparisToplamViewModel
                {
                    SiparisID = x.Key.SiparisID,
                    Toplam = x.Sum(y => Convert.ToDecimal(y.Indirim) * y.Toplam)
                })
                .OrderBy(x => x.SiparisID)
                .ToList();

            return raporson;
        }
    }

    public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int>
    {
    } //!!!!!!!!!!!
}
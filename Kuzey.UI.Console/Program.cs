using System.Threading;
using Kuzey.BLL;

namespace Kuzey.UI.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var kategoriler = new KategoriRepo().TumKategorileriGetir();
                foreach (var kategori in kategoriler)
                {
                    System.Console.WriteLine(
                        $"Kategori Adı: {kategori.KategoriAdi}\n\tAçıklama: {kategori.Aciklama}\n\tÜrün Sayısı: {kategori.Urunler.Count}");
                    //var urunler = new UrunRepo().KategorininUrunleriniGetir(kategori);
                    var urunler = kategori.Urunler;
                    foreach (var urun in urunler)
                    {
                        var durum = urun.SatistaMi ? "Satışta" : "Satışta Değil";
                        System.Console.WriteLine(
                            $"\t\tÜrün Adı: {urun.UrunAdi}\n\t\tFiyat: {urun.Fiyat:0.00}\n\t\tDurum: {durum}");
                    }
                }
                Thread.Sleep(2000);
                System.Console.Clear();
            }

            //System.Console.Read();
        }
    }
}
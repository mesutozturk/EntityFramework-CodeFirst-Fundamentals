namespace Kuzey.Model.ViewModels
{
    public class SiparisRaporuViewModel
    {
        public int SiparisID { get; set; }
        public string KategoriAdi { get; set; }
        public string UrunAdi { get; set; }
        public short Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Toplam { get; set; }
    }
}
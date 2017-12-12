using System;

namespace Binode.Data.Model
{
    public class Icerik
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public string AciklamaNotu { get; set; }
        public Kategori Kategori { get; set; }
        public IcerikTipi Tip { get; set; }
        public string Content { get; set; }
    }

    public enum IcerikTipi
    {
        Metin,
        Pdf,
        Ses,
        Video
    }
}
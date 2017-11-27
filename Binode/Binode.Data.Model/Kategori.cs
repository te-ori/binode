using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binode.Data.Model
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string AciklamaNotu { get; set; }
        public Kategori UstKategori { get; set; }
        public List<Kategori> AltKategori { get; set; }
        public List<Icerik> Icerik { get; set; }
        public int SiraNumarasi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public string Ikon { get; set; }

    }
}

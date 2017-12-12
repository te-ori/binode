using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binode.Data.Model
{
    public static class DemoData
    {
        public static List<Kategori> DemoKategoriGetir()
        {
            var kategori = new List<Kategori>()
            {
                new Kategori {
                    Isim = "Coğrafya",
                    SiraNumarasi = 0,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Coğrafya dersine ait notlar"
                },
                new Kategori {
                    Isim = "Tarih",
                    SiraNumarasi =1,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Tarih dersine ait notlar"
                },
            };


            kategori[0].AltKategori = new List<Kategori>
            {
                new Kategori {
                    Isim = "Yerel Coğrafya",
                    SiraNumarasi = 0,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Yerel Coğrafya dersine ait notlar",
                    UstKategori = kategori[0],
                    AltKategori = new List<Kategori>
                    {
                        new Kategori {
                    Isim = "Doğu Anadolu Coğrafyası",
                    SiraNumarasi = 1,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Doğu Anadolu Coğrafyası dersine ait notlar",
                    UstKategori = kategori[0]
                }
                    }
                },
                new Kategori {
                    Isim = "Kültürel Coğrafya",
                    SiraNumarasi = 1,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Kültürel Coğrafya dersine ait notlar",
                    UstKategori = kategori[0]
                }
            };

            kategori[1].AltKategori = new List<Kategori>
            {
                new Kategori {
                    Isim = "Yerel Tarih",
                    SiraNumarasi = 0,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Yerel Tarih dersine ait notlar",
                    UstKategori = kategori[1]
                },
                new Kategori {
                    Isim = "Tarih Coğrafya",
                    SiraNumarasi = 1,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu ="Kültürel Tarih dersine ait notlar",
                    UstKategori = kategori[1]
                }
            };

            kategori[0].Icerik = new List<Icerik>
                    {
                        new Icerik { Isim= "Coğrafya 01", EklenmeTarihi = DateTime.Now, Kategori = kategori[0]},
                        new Icerik { Isim= "Coğrafya 02", EklenmeTarihi = DateTime.Now, Kategori = kategori[0]},
                        new Icerik { Isim= "Coğrafya 03", EklenmeTarihi = DateTime.Now, Kategori = kategori[0]},
                    };

            kategori[0].AltKategori[0].Icerik = new List<Icerik>
                    {
                        new Icerik { Isim= "Yerel Coğrafya 01", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[0]},
                        new Icerik { Isim= "Yerel Coğrafya 02", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[0]},
                        new Icerik { Isim= "Yerel Coğrafya 03", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[0]},
                    };
            kategori[0].AltKategori[0].AltKategori[0].Icerik = new List<Icerik>
                    {
                        new Icerik { Isim= "Doğu Anadolu Coğrafyası 01", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[0].AltKategori[0]},
                        new Icerik { Isim= "Doğu Anadolu Coğrafyası 02", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[0].AltKategori[0]},
                        new Icerik { Isim= "Doğu Anadolu Coğrafyası 03", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[0].AltKategori[0]},
                    };

            kategori[0].AltKategori[1].Icerik = new List<Icerik>
                    {
                        new Icerik { Isim= "Kültürel Coğrafya 01", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[1]},
                        new Icerik { Isim= "Kültürel Coğrafya 02", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[1]},
                        new Icerik { Isim= "Kültürel Coğrafya 03", EklenmeTarihi = DateTime.Now, Kategori = kategori[0].AltKategori[1]},
                    };

            return kategori;
        }

    }
}

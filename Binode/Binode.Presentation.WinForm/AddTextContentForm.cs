using Binode.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binode.Presentation.WinForm
{
    public partial class AddTextContentForm : Form
    {
        public AddTextContentForm()
        {
            InitializeComponent();
        }

        public Kategori SelectedKategori { get; set; }

        //Add Text Content = Metin içerik ekle
        private void AddTextContent_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedKategori.Icerik.Add(new Icerik
            {
                Isim = txtTitle.Text,
                Content = txtContent.Rtf,
                Kategori = SelectedKategori,
                EklenmeTarihi = DateTime.Now,
                Tip = IcerikTipi.Metin
            });

            this.Close();
        }
    }
}

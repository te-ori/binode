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
    public partial class TextContentViewForm : Form
    {
        public Icerik Icerik { get; set; }

        public TextContentViewForm()
        {
            InitializeComponent();

        }

        private void TextContentViewForm_Load(object sender, EventArgs e)
        {
            label4.Text = Icerik.Kategori.Isim;
            label1.Text = Icerik.Isim;
            richTextBox1.Rtf = Icerik.Content;
        }
    }
}

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
    public partial class VideoContentPlayerForm : Form
    {
        public Icerik Icerik { get; set; }

        public VideoContentPlayerForm()
        {
            InitializeComponent();
        }

        private void VideoContentPlayerForm_Load(object sender, EventArgs e)
        {
            label1.Text = Icerik.Isim;
            label2.Text = Icerik.Kategori.Isim;
            axWindowsMediaPlayer1.URL = Icerik.Content;
        }
    }
}

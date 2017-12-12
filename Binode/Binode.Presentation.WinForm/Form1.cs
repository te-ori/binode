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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var kategoriler = DemoData.DemoKategoriGetir();
            KategoriyiTreeviewAEkle(kategoriler, null);
        }

        private void KategoriyiTreeviewAEkle(List<Kategori> kategoriler, TreeNode node)
        {
            foreach (var kategori in kategoriler)
            {
                if(node is null)
                {
                    var nnode = new TreeNode(kategori.Isim);

                    treeKategori.Nodes.Add(nnode);

                    if(kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, nnode);
                    }
                }
                else
                {
                    node.Nodes.Add(kategori.Isim);

                    if (kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, node.Nodes[node.Nodes.Count-1]);
                    }
                }
            }

        }
    }
}

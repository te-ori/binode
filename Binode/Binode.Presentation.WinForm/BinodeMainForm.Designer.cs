using System;

namespace Binode.Presentation.WinForm
{
    partial class BinodeMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinodeMainForm));
            this.grpKategori = new System.Windows.Forms.GroupBox();
            this.treeKategori = new System.Windows.Forms.TreeView();
            this.grpIcerik = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglContentSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.metinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpKategori.SuspendLayout();
            this.grpIcerik.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKategori
            // 
            this.grpKategori.Controls.Add(this.treeKategori);
            this.grpKategori.Location = new System.Drawing.Point(12, 12);
            this.grpKategori.Name = "grpKategori";
            this.grpKategori.Size = new System.Drawing.Size(200, 430);
            this.grpKategori.TabIndex = 0;
            this.grpKategori.TabStop = false;
            this.grpKategori.Text = "Kategori";
            // 
            // treeKategori
            // 
            this.treeKategori.LabelEdit = true;
            this.treeKategori.Location = new System.Drawing.Point(6, 19);
            this.treeKategori.Name = "treeKategori";
            this.treeKategori.Size = new System.Drawing.Size(188, 405);
            this.treeKategori.TabIndex = 0;
            this.treeKategori.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeKategori_AfterLabelEdit);
            this.treeKategori.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeKategori_AfterSelect);
            this.treeKategori.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeKategori_NodeMouseClick);
            // 
            // grpIcerik
            // 
            this.grpIcerik.Controls.Add(this.listView1);
            this.grpIcerik.Location = new System.Drawing.Point(218, 12);
            this.grpIcerik.Name = "grpIcerik";
            this.grpIcerik.Size = new System.Drawing.Size(566, 430);
            this.grpIcerik.TabIndex = 1;
            this.grpIcerik.TabStop = false;
            this.grpIcerik.Text = "İçerik";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 405);
            this.listView1.SmallImageList = this.imglContentSmallIcons;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            // 
            // imglContentSmallIcons
            // 
            this.imglContentSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglContentSmallIcons.ImageStream")));
            this.imglContentSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglContentSmallIcons.Images.SetKeyName(0, "metin");
            this.imglContentSmallIcons.Images.SetKeyName(1, "pdf");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 114);
            this.contextMenuStrip1.Text = "Yeniden Adlandır";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem1.Text = "Yeniden Adlandır";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem2.Text = "Alt Kategori Ekle...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metinToolStripMenuItem,
            this.pdfToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.sesToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem4.Text = "İçerik Ekle";
            // 
            // metinToolStripMenuItem
            // 
            this.metinToolStripMenuItem.Name = "metinToolStripMenuItem";
            this.metinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.metinToolStripMenuItem.Text = "Metin";
            this.metinToolStripMenuItem.Click += new System.EventHandler(this.metinToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // sesToolStripMenuItem
            // 
            this.sesToolStripMenuItem.Name = "sesToolStripMenuItem";
            this.sesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sesToolStripMenuItem.Text = "Ses";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem3.Text = "Sil";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BinodeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.grpIcerik);
            this.Controls.Add(this.grpKategori);
            this.Name = "BinodeMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKategori.ResumeLayout(false);
            this.grpIcerik.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.GroupBox grpKategori;
        private System.Windows.Forms.TreeView treeKategori;
        private System.Windows.Forms.GroupBox grpIcerik;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem metinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesToolStripMenuItem;
        private System.Windows.Forms.ImageList imglContentSmallIcons;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


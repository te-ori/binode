namespace Binode.Presentation.WinForm
{
    partial class Form1
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
            this.grpKategori = new System.Windows.Forms.GroupBox();
            this.grpIcerik = new System.Windows.Forms.GroupBox();
            this.treeKategori = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpKategori.SuspendLayout();
            this.grpIcerik.SuspendLayout();
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
            // treeKategori
            // 
            this.treeKategori.Location = new System.Drawing.Point(6, 19);
            this.treeKategori.Name = "treeKategori";
            this.treeKategori.Size = new System.Drawing.Size(188, 405);
            this.treeKategori.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 405);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.grpIcerik);
            this.Controls.Add(this.grpKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKategori.ResumeLayout(false);
            this.grpIcerik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKategori;
        private System.Windows.Forms.TreeView treeKategori;
        private System.Windows.Forms.GroupBox grpIcerik;
        private System.Windows.Forms.ListView listView1;
    }
}


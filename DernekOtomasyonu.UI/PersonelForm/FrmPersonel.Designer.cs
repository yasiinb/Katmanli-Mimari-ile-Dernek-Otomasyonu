
namespace DernekOtomasyonu.UI.PersonelForm
{
    partial class FrmPersonel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aidatİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aidatİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mAİLİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.aidatİşlemleriToolStripMenuItem,
            this.aidatİşlemleriToolStripMenuItem1,
            this.mAİLİŞLEMLERİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeİşlemleriToolStripMenuItem_Click);
            // 
            // aidatİşlemleriToolStripMenuItem
            // 
            this.aidatİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aidatİşlemleriToolStripMenuItem.Name = "aidatİşlemleriToolStripMenuItem";
            this.aidatİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.aidatİşlemleriToolStripMenuItem.Text = "Aidat Ödeme İşlemleri";
            this.aidatİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.aidatİşlemleriToolStripMenuItem_Click);
            // 
            // aidatİşlemleriToolStripMenuItem1
            // 
            this.aidatİşlemleriToolStripMenuItem1.Name = "aidatİşlemleriToolStripMenuItem1";
            this.aidatİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(150, 32);
            this.aidatİşlemleriToolStripMenuItem1.Text = "Aidat İşlemleri";
            this.aidatİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.aidatİşlemleriToolStripMenuItem1_Click);
            // 
            // mAİLİŞLEMLERİToolStripMenuItem
            // 
            this.mAİLİŞLEMLERİToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mAİLİŞLEMLERİToolStripMenuItem.Name = "mAİLİŞLEMLERİToolStripMenuItem";
            this.mAİLİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.mAİLİŞLEMLERİToolStripMenuItem.Text = "Mail İşlemleri";
            this.mAİLİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.mAİLİŞLEMLERİToolStripMenuItem_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 704);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPersonel_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aidatİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aidatİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mAİLİŞLEMLERİToolStripMenuItem;
    }
}
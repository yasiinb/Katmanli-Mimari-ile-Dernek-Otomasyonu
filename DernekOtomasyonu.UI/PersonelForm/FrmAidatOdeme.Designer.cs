
namespace DernekOtomasyonu.UI.PersonelForm
{
    partial class FrmAidatOdeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.TCARA = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TümListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OdemeAl = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OdenenListe = new System.Windows.Forms.Button();
            this.OdenmeyenListe = new System.Windows.Forms.Button();
            this.BtnUyeOdemeBilgi = new System.Windows.Forms.Button();
            this.BtnUyeOdenmeme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üye TC:";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTC.Location = new System.Drawing.Point(223, 65);
            this.txtTC.Margin = new System.Windows.Forms.Padding(1);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(162, 27);
            this.txtTC.TabIndex = 2;
            // 
            // TCARA
            // 
            this.TCARA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TCARA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TCARA.Location = new System.Drawing.Point(248, 120);
            this.TCARA.Margin = new System.Windows.Forms.Padding(1);
            this.TCARA.Name = "TCARA";
            this.TCARA.Size = new System.Drawing.Size(105, 52);
            this.TCARA.TabIndex = 36;
            this.TCARA.Text = "TC ARA";
            this.TCARA.UseVisualStyleBackColor = false;
            this.TCARA.Click += new System.EventHandler(this.TCARA_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(572, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(473, 621);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TümListele
            // 
            this.TümListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TümListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TümListele.Location = new System.Drawing.Point(438, 20);
            this.TümListele.Margin = new System.Windows.Forms.Padding(1);
            this.TümListele.Name = "TümListele";
            this.TümListele.Size = new System.Drawing.Size(123, 72);
            this.TümListele.TabIndex = 35;
            this.TümListele.Text = "Tümünü Aidatları Listele";
            this.TümListele.UseVisualStyleBackColor = false;
            this.TümListele.Click += new System.EventHandler(this.TümListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ödenecek Aidat Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Aidat Tutarı:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(223, 365);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 27);
            this.textBox1.TabIndex = 42;
            // 
            // OdemeAl
            // 
            this.OdemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OdemeAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OdemeAl.Location = new System.Drawing.Point(248, 515);
            this.OdemeAl.Margin = new System.Windows.Forms.Padding(1);
            this.OdemeAl.Name = "OdemeAl";
            this.OdemeAl.Size = new System.Drawing.Size(105, 52);
            this.OdemeAl.TabIndex = 43;
            this.OdemeAl.Text = "Ödemeyi Tamamla";
            this.OdemeAl.UseVisualStyleBackColor = false;
            this.OdemeAl.Click += new System.EventHandler(this.OdemeAl_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(223, 425);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 27);
            this.textBox2.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(223, 310);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 27);
            this.textBox3.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Aidat Numarası:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 253);
            this.textBox4.Margin = new System.Windows.Forms.Padding(1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 27);
            this.textBox4.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(79, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Üye TC:";
            // 
            // OdenenListe
            // 
            this.OdenenListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OdenenListe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OdenenListe.Location = new System.Drawing.Point(438, 321);
            this.OdenenListe.Margin = new System.Windows.Forms.Padding(1);
            this.OdenenListe.Name = "OdenenListe";
            this.OdenenListe.Size = new System.Drawing.Size(123, 72);
            this.OdenenListe.TabIndex = 49;
            this.OdenenListe.Text = "Tüm Ödenmiş Aidatları Listele";
            this.OdenenListe.UseVisualStyleBackColor = false;
            this.OdenenListe.Click += new System.EventHandler(this.OdenenListe_Click);
            // 
            // OdenmeyenListe
            // 
            this.OdenmeyenListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OdenmeyenListe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OdenmeyenListe.Location = new System.Drawing.Point(438, 425);
            this.OdenmeyenListe.Margin = new System.Windows.Forms.Padding(1);
            this.OdenmeyenListe.Name = "OdenmeyenListe";
            this.OdenmeyenListe.Size = new System.Drawing.Size(123, 72);
            this.OdenmeyenListe.TabIndex = 50;
            this.OdenmeyenListe.Text = "Tüm Ödenmemiş Aidatları Listele";
            this.OdenmeyenListe.UseVisualStyleBackColor = false;
            this.OdenmeyenListe.Click += new System.EventHandler(this.OdenmeyenListe_Click);
            // 
            // BtnUyeOdemeBilgi
            // 
            this.BtnUyeOdemeBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnUyeOdemeBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUyeOdemeBilgi.Location = new System.Drawing.Point(438, 120);
            this.BtnUyeOdemeBilgi.Margin = new System.Windows.Forms.Padding(1);
            this.BtnUyeOdemeBilgi.Name = "BtnUyeOdemeBilgi";
            this.BtnUyeOdemeBilgi.Size = new System.Drawing.Size(123, 71);
            this.BtnUyeOdemeBilgi.TabIndex = 51;
            this.BtnUyeOdemeBilgi.Text = "Üye İçin Ödenmiş Aidatları Listele";
            this.BtnUyeOdemeBilgi.UseVisualStyleBackColor = false;
            this.BtnUyeOdemeBilgi.Click += new System.EventHandler(this.BtnUyeOdemeBilgi_Click);
            // 
            // BtnUyeOdenmeme
            // 
            this.BtnUyeOdenmeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnUyeOdenmeme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUyeOdenmeme.Location = new System.Drawing.Point(438, 218);
            this.BtnUyeOdenmeme.Margin = new System.Windows.Forms.Padding(1);
            this.BtnUyeOdenmeme.Name = "BtnUyeOdenmeme";
            this.BtnUyeOdenmeme.Size = new System.Drawing.Size(123, 72);
            this.BtnUyeOdenmeme.TabIndex = 52;
            this.BtnUyeOdenmeme.Text = "Üye İçin Ödenmemiş Aidatları Listele";
            this.BtnUyeOdenmeme.UseVisualStyleBackColor = false;
            this.BtnUyeOdenmeme.Click += new System.EventHandler(this.BtnUyeOdenmeme_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(438, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 72);
            this.button1.TabIndex = 53;
            this.button1.Text = "PDF OLARAK KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 624);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // FrmAidatOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1101, 704);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUyeOdenmeme);
            this.Controls.Add(this.BtnUyeOdemeBilgi);
            this.Controls.Add(this.OdenmeyenListe);
            this.Controls.Add(this.OdenenListe);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OdemeAl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TümListele);
            this.Controls.Add(this.TCARA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTC);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmAidatOdeme";
            this.Text = "FrmAidatOdeme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button TCARA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TümListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OdemeAl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OdenenListe;
        private System.Windows.Forms.Button OdenmeyenListe;
        private System.Windows.Forms.Button BtnUyeOdemeBilgi;
        private System.Windows.Forms.Button BtnUyeOdenmeme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}
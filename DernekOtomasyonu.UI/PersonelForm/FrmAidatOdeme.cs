using DernekOtomasyonu.Bussiness.Concrete;
using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iText.Layout.Element;
using Paragraph = iText.Layout.Element.Paragraph;

namespace DernekOtomasyonu.UI.PersonelForm
{
    public partial class FrmAidatOdeme : Form
    {
        OdemelerManager odemeManager = new OdemelerManager();
        AidatManager aidatManager = new AidatManager();
        public FrmAidatOdeme()
        {
            InitializeComponent();
        }

   

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
              

                // Seçilen satırdaki UyeTC'yi al
                string uyeTC = selectedRow.Cells["UyeTC"].Value.ToString();

                // TextBox4'e UyeTC'yi yazdır
                textBox4.Text = uyeTC;
                txtTC.Text = uyeTC;
                // Seçilen satırdaki AidatID'yi al
                int aidatID = Convert.ToInt32(selectedRow.Cells["AidatID"].Value);

                // AidatID'ye göre Aidat bilgilerini getir
                Aidat selectedAidat = aidatManager.GetAidatInfoByAidatID(aidatID);

                // TextBox'lara bilgileri yazdır
                textBox1.Text = selectedAidat?.AidatTarih.ToString() ?? string.Empty;  // Örnek olarak Tarih özelliğini kullanıyorum, gerçek özellik adınıza göre değiştirin
                textBox2.Text = selectedAidat?.AidatMiktar.ToString() ?? string.Empty;
                textBox3.Text = selectedAidat?.AidatID.ToString() ?? string.Empty;// Örnek olarak Miktar özelliğini kullanıyorum, gerçek özellik adınıza göre değiştirin
            }
        }

  

        private void TCARA_Click(object sender, EventArgs e)
        {
            string uyeTC = txtTC.Text;

            if (!string.IsNullOrEmpty(uyeTC))
            {
                // Üyenin ödeme bilgilerini getir
                List<Odemeler> odemeBilgileri = odemeManager.GetByUyeTC(uyeTC);

                // DataGridView'e ödeme bilgilerini bind et
                dataGridView1.DataSource = odemeBilgileri;

         

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir TC numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OdemeAl_Click(object sender, EventArgs e)
        {
            //textboxlardan TC VE Aidat ID çektik
            Odemeler odeme = odemeManager.GetOdemelerByUyeTCAndAidatID(textBox4.Text, Convert.ToInt32(textBox3.Text));

            // Bulunan kaydı güncelle
            if (odeme != null)
            {
                //GÜNCELLEME
                odeme.Durum = true;
                
                odemeManager.Update(odeme);



                //Güncellenen listeyi çağırma işlemi TC ye göre Üye için
                List<Odemeler> odemeBilgileri = odemeManager.GetByUyeTC(textBox4.Text);
                dataGridView1.DataSource = odemeBilgileri;

            }
        }

        private void TümListele_Click(object sender, EventArgs e)
        {
            //Tüm Aidatları Listeleme İşlemi 
            List<Odemeler> odemeBilgileri = odemeManager.GetAll();
            dataGridView1.DataSource = odemeBilgileri;
            label6.Text = "PDF_TÜM_AİDATLAR";
        }

        private void OdenenListe_Click(object sender, EventArgs e)
        {
            //Ödenenleri Listele
            List<Odemeler> trueOdemeler = odemeManager.GetOdemelerByDurum(true);
            dataGridView1.DataSource = trueOdemeler;
            label6.Text = "PDF_TÜM_ÖDENEN_AİDATLAR";
        }

        private void OdenmeyenListe_Click(object sender, EventArgs e)
        {
            //Ödenmeyenleri Listele 
            List<Odemeler> falseOdemeler = odemeManager.GetOdemelerByDurum(false);
            dataGridView1.DataSource = falseOdemeler;
            label6.Text = "PDF_TÜM_ÖDENMEYEN_AİDATLAR";
        }

        private void BtnUyeOdemeBilgi_Click(object sender, EventArgs e)
        {
            string uyeTC = txtTC.Text.Trim();

            if (string.IsNullOrEmpty(uyeTC) || uyeTC.Length != 11)
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Odemeler> trueUyeOdemeler = odemeManager.GetOdemelerByUyeTCDurum(uyeTC, true);
            dataGridView1.DataSource = trueUyeOdemeler;
            label6.Text = "PDF_ÜYE_"+uyeTC+"_ ÖDENEN_AİDATLAR";
        }

        private void BtnUyeOdenmeme_Click(object sender, EventArgs e)
        {
            string uyeTC = txtTC.Text.Trim();

            if (string.IsNullOrEmpty(uyeTC) || uyeTC.Length != 11)
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            List<Odemeler> falseUyeOdemeler = odemeManager.GetOdemelerByUyeTCDurum(uyeTC, false);
            dataGridView1.DataSource = falseUyeOdemeler;
            label6.Text = "PDF_ÜYE_" + uyeTC + "_ ÖDENMEYEN_AİDATLAR";
        }

       
        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = label6.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dataGridView1, saveFileDialog.FileName);
            }
        }

        private void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var writer = new iText.Kernel.Pdf.PdfWriter(filePath))
                {
                    using (var pdf = new iText.Kernel.Pdf.PdfDocument(writer))
                    {
                        using (var document = new iText.Layout.Document(pdf))
                        {
                            // Başlık eklemek için
                            Paragraph title = new Paragraph(label6.Text);
                            document.Add(title);

                            // DataGridView verilerini PDF'e eklemek için
                            iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.Columns.Count);
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                table.AddHeaderCell(new Cell().Add(new Paragraph(dataGridView.Columns[i].HeaderText)));
                            }

                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    if (dataGridView[j, i].Value != null)
                                        table.AddCell(new Cell().Add(new Paragraph(dataGridView[j, i].Value.ToString())));
                                    else
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                }
                            }

                            document.Add(table);
                        }
                    }
                }

                MessageBox.Show("PDF dosyası başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}

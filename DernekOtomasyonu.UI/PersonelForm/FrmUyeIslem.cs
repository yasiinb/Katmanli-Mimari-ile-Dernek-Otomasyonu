
using DernekOtomasyonu.Bussiness.Concrete;
using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekOtomasyonu.UI.PersonelForm
{
    public partial class FrmUyeIslem : Form
    {
        UyeManager uyeManager = new UyeManager();

        public FrmUyeIslem()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)//Kayıt
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) ||
            string.IsNullOrWhiteSpace(txtAd.Text) ||
            string.IsNullOrWhiteSpace(txtSoyad.Text) ||
            string.IsNullOrWhiteSpace(txtSehir.Text) ||
            string.IsNullOrWhiteSpace(cmbKan.Text) ||
        (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemi durdur
            }

            if (uyeManager.Exists(txtTC.Text))
            {
                MessageBox.Show("Bu TC numarasına sahip bir üye zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemi durdur
            }
           
            uyeManager.Add(uyedoldur());
            MessageBox.Show("Üye Başarıyla Kaydedildi...", "Kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();
            Temizle();
            FillSehirComboBox();
        }

        private void FrmUyeIslem_Load(object sender, EventArgs e)
        {
            listele();
            FillSehirComboBox();
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Verileri TextBox, ComboBox, RadioButton ve DateTimePicker'a aktar
                txtTC.Text = row.Cells["UyeTC"].Value.ToString();
                txtAd.Text = row.Cells["UyeAdi"].Value.ToString();
                txtSoyad.Text = row.Cells["UyeSoyadi"].Value.ToString();
                txtTel.Text = row.Cells["UyeTelefonNo"].Value.ToString();
                txtSehir.Text = row.Cells["Sehir"].Value.ToString();
                txtMail.Text = row.Cells["UyeMail"].Value.ToString();

                // Kan grubu ComboBox'u seçili hale getir
                cmbKan.SelectedItem = row.Cells["Kangurubu"].Value.ToString().Substring(0, 2);

                // RadioButton'ları işaretle
                string rhDegeri = row.Cells["Kangurubu"].Value.ToString().Substring(2);
                if (rhDegeri == "Rh+")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (rhDegeri == "Rh-")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["KatilimTarihi"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Güncelleme 
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) ||
           string.IsNullOrWhiteSpace(txtAd.Text) ||
           string.IsNullOrWhiteSpace(txtSoyad.Text) ||
           string.IsNullOrWhiteSpace(txtSehir.Text) ||
           string.IsNullOrWhiteSpace(cmbKan.Text) ||
       (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemi durdur
            }

            

            // UyeManager sınıfındaki Update metodu kullanılarak güncelleme işlemi yapılır
            uyeManager.Update(uyedoldur());
            MessageBox.Show("Üye Başarıyla Güncellendi...", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Question);
            // Listeleme işlemi
            listele();
            Temizle();
            FillSehirComboBox();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

           // DataGridView'da seçili bir satır olup olmadığını kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kullanıcıya onay için bir mesaj göster
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                Uye selectedUye = (Uye)dataGridView1.Rows[selectedRowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show($"TC: {selectedUye.UyeTC}\nSeçili üyeyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Evet'e tıklanırsa silme işlemini gerçekleştir
                    uyeManager.Delete(selectedUye);
                    MessageBox.Show("Üye Başarıyla Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    Temizle();
                    FillSehirComboBox();
                }
                // Hayır'a tıklanırsa işlemi iptal et
              
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi liste üzerinden seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string sehir = cmbSehir.SelectedItem?.ToString();
            bool AktifDurum = checkBox2.Checked;
            string selectedKanGrubu = comboBox1.SelectedItem?.ToString();
            if (selectedKanGrubu == "Tümü")
            {
                // Tüm üyeleri listele
                listele();
            }
            else
            {
                // Seçilen kan grubuna göre üyeleri filtrele
                List<Uye> filteredUyeler = uyeManager.GetByListele(selectedKanGrubu,AktifDurum,sehir);

                // DataGridView'e filtrelenmiş üyeleri at
                dataGridView1.DataSource = filteredUyeler;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//Duruma Göre Listeleme 
        {
            bool AktifDurum = checkBox2.Checked;
            string selectedKanGrubu = comboBox1.SelectedItem?.ToString();
            string sehir = cmbSehir.SelectedItem?.ToString();
            List<Uye> filteredUyeler = uyeManager.GetByListele(selectedKanGrubu,AktifDurum,sehir);
            dataGridView1.DataSource = filteredUyeler;
        }
       
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sehir = cmbSehir.SelectedItem?.ToString();
            bool AktifDurum = checkBox2.Checked;
            string selectedKanGrubu = comboBox1.SelectedItem?.ToString();
           
                // Seçilen kan grubuna göre üyeleri filtrele
                List<Uye> filteredUyeler = uyeManager.GetByListele(selectedKanGrubu, AktifDurum, sehir);

                // DataGridView'e filtrelenmiş üyeleri at
                dataGridView1.DataSource = filteredUyeler;
            
        }
        private void FillSehirComboBox()
        {
            List<string> sehirler = uyeManager.sehirler();
            cmbSehir.Items.Clear();
           
            cmbSehir.Items.AddRange(sehirler.ToArray());
        }
        public Uye uyedoldur()
        {
            string kanGrubu = cmbKan.SelectedItem?.ToString() ?? "Belirsiz";
            string rhDegeri = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "Belirsiz";
            string kangurubu = kanGrubu + rhDegeri;

            // Uye nesnesini güncelle
            Uye uye = new Uye
            {
                UyeTC = txtTC.Text,
                UyeAdi = txtAd.Text,
                UyeSoyadi = txtSoyad.Text,
                Kangurubu = kangurubu,
                UyeTelefonNo = txtTel.Text,
                Sehir = txtSehir.Text,
                UyeMail = txtMail.Text,
                KatilimTarihi = dateTimePicker1.Value,
                AktifDurum = checkBox1.Checked
            };
            return uye;
        }
        private void listele()
        {
            dataGridView1.DataSource = uyeManager.GetAll();
        }
        private void Temizle()
        {
            // TextBox'ları temizle
            txtTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
            txtSehir.Clear();
            txtMail.Clear();

            // ComboBox'ı temizle
            cmbKan.SelectedIndex = -1;

            // RadioButton'ları temizle
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // DateTimePicker'ı günümüz tarihine ayarla
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
            cmbSehir.SelectedIndex = -1;
            cmbSehir.SelectedIndex = -1;
            checkBox2.Checked = true;
        }
    }
}

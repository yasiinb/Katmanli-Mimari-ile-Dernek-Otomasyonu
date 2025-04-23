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
    public partial class FrmAidatTanimla : Form
    {
        AidatManager aidatManager = new AidatManager();
        public FrmAidatTanimla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMiktar.Text))
            {
                MessageBox.Show("Lütfen miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tarihin boş olup olmadığını kontrol et
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Lütfen bugünün tarihinden ileri bir tarih seç", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aidatManager.Add(Kayitaidatdoldur());
            MessageBox.Show("Aidat Başarıyla Kaydedildi...", "Kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();
            Temizle();

        }
        public Aidat Kayitaidatdoldur()
        {

            // Aidat nesnesini güncelle
            Aidat aidat = new Aidat
            {
               
                AidatMiktar = Convert.ToInt32(txtMiktar.Text),
                AidatTarih = dateTimePicker1.Value

            };
            return aidat;
        }
        public Aidat aidatdoldur()
        {
           
            // Aidat nesnesini güncelle
            Aidat aidat = new Aidat
            {
                AidatID= Convert.ToInt32(txtID.Text),
                AidatMiktar=Convert.ToInt32(txtMiktar.Text),
                AidatTarih=dateTimePicker1.Value

            };
            return aidat;
        }
        public void listele()
        {
            dataGridView1.DataSource = aidatManager.GetAll();
        }
        public void Temizle()
        {
            txtMiktar.Clear();
            txtID.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FrmAidatTanimla_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMiktar.Text))
            {
                MessageBox.Show("Lütfen miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tarihin boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Lütfen bir aidat seçiniz seç", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            aidatManager.Update(aidatdoldur());
            MessageBox.Show("Aidat Başarıyla Güncellendi...", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Question);
            // Listeleme işlemi
            listele();
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Verileri TextBox, ComboBox, RadioButton ve DateTimePicker'a aktar
                txtID.Text = row.Cells["AidatID"].Value.ToString();
                txtMiktar.Text = row.Cells["AidatMiktar"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["AidatTarih"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili aidatı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Evet'e tıklanırsa silme işlemini gerçekleştir
                aidatManager.Delete(aidatdoldur());
                MessageBox.Show("Aidat Başarıyla Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                Temizle();
              
            }
            // Hayır'a tıklanırsa işlemi iptal et
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            dataGridView1.DataSource = aidatManager.GetAidatlarAfterDate(dateTimePicker2.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listele();
        }
    }

}

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

namespace DernekOtomasyonu.UI
{
    public partial class FrmGiris : Form
    {
        PersonelManager personelManager = new PersonelManager();
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtAd.Text;
            string sifre = txtSifre.Text;

            Personel girisYapanPersonel = personelManager.GetByYetki(kullaniciAdi, sifre);

            if (girisYapanPersonel != null)
            {
                // Giriş başarılı, yönlendirme işlemleri burada yapılır
                if (girisYapanPersonel.PersonelYetki == 1)
                {
                    PersonelForm.FrmPersonel frmPersonel = new PersonelForm.FrmPersonel();
                    this.Hide();
                    frmPersonel.Show();
                }
         
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = checkBox1.Checked ? '\0' : '*';
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Şifreyi Gizle";
            }
            else
            {
                checkBox1.Text = "Şifreyi Göster";
            }
            

        }
    }
}

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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelForm.FrmPAnasayfa frmanasayfa = new PersonelForm.FrmPAnasayfa();
            frmanasayfa.MdiParent = this; // MDI parent olarak bu formu belirle
            frmanasayfa.Show();
        }

        private void FrmPersonel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelForm.FrmUyeIslem frmUyeIslem = new PersonelForm.FrmUyeIslem();
            frmUyeIslem.MdiParent = this; 
            frmUyeIslem.Show();
        }

        private void aidatİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelForm.FrmAidatOdeme frmAidat = new PersonelForm.FrmAidatOdeme();
            frmAidat.MdiParent = this;
            frmAidat.Show();
        }

        private void aidatİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelForm.FrmAidatTanimla frmAidatTanimla = new FrmAidatTanimla();
            frmAidatTanimla.ShowDialog();

        }

        private void mAİLİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelForm.FrmMail frmmail = new FrmMail();
            frmmail.Show();
        }

       
    }
}

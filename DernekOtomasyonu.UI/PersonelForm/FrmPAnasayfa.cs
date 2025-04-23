using DernekOtomasyonu.Bussiness.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DernekOtomasyonu.UI.PersonelForm
{
    public partial class FrmPAnasayfa : Form
    {
        UyeManager uyeManager = new UyeManager();
        public FrmPAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmPAnasayfa_Load(object sender, EventArgs e)
        {
            var sehirler = uyeManager.GetDistinctSehir();
            var uyeSayilari = uyeManager.GetUyeCountBySehir();

            // ZedGraph kontrolünü oluştur
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Üye Dağılımı";
            myPane.XAxis.Title.Text = "Şehirler";
            myPane.YAxis.Title.Text = "Üye Sayısı";

            // Çubuk grafik oluştur
            BarItem myBar = myPane.AddBar("Üye Sayısı", null, uyeSayilari.Values.Select(x => (double)x).ToArray(), Color.Blue);


            // Eksen etiketleri için şehir isimlerini belirle
            myPane.XAxis.Type = AxisType.Text;
            myPane.XAxis.Scale.TextLabels = sehirler.ToArray();
            myPane.XAxis.Scale.MajorStepAuto = true;

            // Grafik görünümünü güncelle
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}

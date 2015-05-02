using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKoltuklariYerlestir_Click(object sender, EventArgs e)
        {
            int xEkseni, yEkseni;
            xEkseni = Convert.ToInt32(nubXSirasi.Value.ToString());
            yEkseni = Convert.ToInt32(nubYSirasi.Value.ToString());
            //scAnaPanel.Panel2.Controls.Clear();

            for (int x = 0; x < xEkseni; x++)
            {
                for (int y = 0; y < yEkseni; y++)
                {
                    Button btn = new Button();
                    btn.Text = "-";
                    btn.Click += btn_Click;

                    Koltuk koltuk = new Koltuk();
                    koltuk.xKonumu = x;
                    koltuk.yKonumu = y;
                    koltuk.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                    btn.Tag = koltuk;
                    btn.Size = new Size(35, 35);
                    btn.Location = new Point(x * 40 + 10, y * 40 + 10);
                    scAnaPanel.Panel2.Controls.Add(btn);

                }
            }
        }

        enum CinsiyetTipi
        {
            TanimliDegil = 0,
            Erkek = 1,
            Kadin = 2,
            Hiçbiri = 3,

        }

        class Koltuk
        {
            public int xKonumu;
            public int yKonumu;
            public CinsiyetTipi cinsiyetTipi;
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Koltuk koltuk = ((Koltuk)btn.Tag);

            CinsiyetTipi cinsiyetTipi = koltuk.cinsiyetTipi;
            int xKonumu = koltuk.xKonumu;
            int yKonumu = koltuk.yKonumu;

            Koltuk yanKoltuk = YanKoltuguBul(koltuk);
            //Cinsiyet tiplerini karşılaştır farklıysa kaydetmeden mesaj getir
            if (cinsiyetTipi == CinsiyetTipi.TanimliDegil)
            {
                if (rbErkek.Checked)
                {
                    if (yanKoltuk.cinsiyetTipi == CinsiyetTipi.Erkek
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.TanimliDegil
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.Hiçbiri)
                    {
                        btn.Text = "E";
                        btn.BackColor = Color.Blue;

                        koltuk.cinsiyetTipi = CinsiyetTipi.Erkek;
                        btn.Tag = koltuk;
                    }
                    else
                    {
                        DialogResult mesajSonucu = MessageBox.Show("Cinsiyetler farklı olamaz. Yinede Eklemek İster misiniz?", "Cinsiyet Farklılığı", MessageBoxButtons.YesNo);
                        if (mesajSonucu == System.Windows.Forms.DialogResult.Yes)
                        {
                            btn.Text = "E";
                            btn.BackColor = Color.Blue;

                            koltuk.cinsiyetTipi = CinsiyetTipi.Erkek;
                            btn.Tag = koltuk;
                        }
                    }


                }

                else if (rbKadin.Checked)
                {
                    if (yanKoltuk.cinsiyetTipi == CinsiyetTipi.Kadin
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.TanimliDegil
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.Hiçbiri)
                    {
                        btn.Text = "K";
                        btn.BackColor = Color.Pink;

                        koltuk.cinsiyetTipi = CinsiyetTipi.Kadin;
                        btn.Tag = koltuk;
                    }
                    else
                    {
                        MessageBox.Show("Cinsiyetler farklı olamaz.");
                    }
                }
                else if (rbHicbiri.Checked)
                {
                    btn.Text = "H";
                    btn.BackColor = Color.Purple;

                    koltuk.cinsiyetTipi = CinsiyetTipi.Hiçbiri;
                    btn.Tag = koltuk;

                }
                else
                {
                    btn.Text = "-";
                    btn.BackColor = Color.Empty;

                    koltuk.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                    btn.Tag = koltuk;
                }
            }

            else
            {
                btn.Text = "-";
                btn.BackColor = Color.Empty;

                koltuk.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                btn.Tag = koltuk;
            }
        }

        private Koltuk YanKoltuguBul(Koltuk koltuk)
        {
            Koltuk yanKoltuk = new Koltuk();
            foreach (Control control in scAnaPanel.Panel2.Controls)
            {
                if (control is Button)
                {
                    Button btn = (control as Button);
                    Koltuk donguKoltugu = ((Koltuk)btn.Tag);
                    if (koltuk.yKonumu == donguKoltugu.yKonumu)
                    {
                        // buraya tıklanan buton ile aynı seviyedeki 4 buton gelecek
                        int artisSayisi;
                        // 0 veya 2 numaralı koltuk olduğundan yan koltuk xKonumun 1 fazlası
                        if (koltuk.xKonumu % 2 == 0)
                        {
                            artisSayisi = 1;
                        }
                        // 1 veya 3 numaralı koltuk olduğundan yan koltuk xKonumun 1 azı
                        else
                        {
                            artisSayisi = -1;
                        }

                        if (donguKoltugu.xKonumu == koltuk.xKonumu + artisSayisi)
                        {
                            yanKoltuk = donguKoltugu;
                            break;

                        }
                    }
                }
            }

            return yanKoltuk;
        }

        private void cmbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSecim.SelectedItem.ToString() == "Koridor")
            {
                foreach (Control control in scAnaPanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        Koltuk donguKoltugu = ((Koltuk)btn.Tag);

                        //Turnary if
                        //1. kullanımı
                        btn.Enabled = donguKoltugu.xKonumu == 0 || donguKoltugu.xKonumu == 3;
                        //2. kullanımı
                        //btn.Enabled = donguKoltugu.xKonumu == 0 || donguKoltugu.xKonumu == 3?true : false;

                        /*
                        if (donguKoltugu.xKonumu == 1 || donguKoltugu.xKonumu == 2)
                        {
                            btn.Enabled = false;

                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                         */
                    }
                }
            }

            else if (cmbSecim.SelectedItem.ToString() == "Pencere")
            {
                {
                    foreach (Control control in scAnaPanel.Panel2.Controls)
                    {
                        if (control is Button)
                        {
                            Button btn = (control as Button);
                            Koltuk donguKoltugu = ((Koltuk)btn.Tag);
                            if (donguKoltugu.xKonumu == 0 || donguKoltugu.xKonumu == 3)
                            {
                                btn.Enabled = false;

                            }
                            else
                            {
                                btn.Enabled = true;
                            }
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbKoltukTipi.SelectedIndex = 2;
        }

        private void lbKoltukTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKoltukTipi.SelectedItem.ToString() == "Erkek")
            {
                foreach (Control control in scAnaPanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        Koltuk koltuk = ((Koltuk)btn.Tag);
                        //yan koltuğu erkek olanları enable yapacağız.
                        Koltuk yanKoltuk = YanKoltuguBul(koltuk);
                        if (yanKoltuk.cinsiyetTipi==CinsiyetTipi.Erkek)
                        {
                            btn.Enabled = true;
                        }
                        else
                        {
                            btn.Enabled = false;
                        }
                        
                    }
                }
            }
            else if (lbKoltukTipi.SelectedItem.ToString() == "Kadın")
            {
                foreach (Control control in scAnaPanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        Koltuk koltuk = ((Koltuk)btn.Tag);
                        //yan koltuğu erkek olanları enable yapacağız.
                        Koltuk yanKoltuk = YanKoltuguBul(koltuk);
                        if (yanKoltuk.cinsiyetTipi == CinsiyetTipi.Kadin)
                        {
                            btn.Enabled = true;
                            cmbSecim.Text = "Erkek";
                        }
                        else
                        {
                            btn.Enabled = false;
                        }

                    }
                }
            }
            else if (lbKoltukTipi.SelectedItem.ToString() == "Hiçbiri")
            {
                foreach (Control control in scAnaPanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        Koltuk donguKoltugu = ((Koltuk)btn.Tag);
                        btn.Enabled = true;
                    }
                }

            }

            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000,550);
            lbl_pnlAnasayfaUyari.Font = new Font(openSansRegular(@"OpenSans-Regular.ttf"), 12);
            lblGirisYap.Font = new Font(openSansRegular(@"OpenSans-Bold.ttf"), 18);
            lblRandevuAra.Font = new Font(openSansRegular(@"OpenSans-Bold.ttf"), 18);
            lblRandevuSec.Font = new Font(openSansRegular(@"OpenSans-Bold.ttf"), 18);
            lblSaatSec.Font = new Font(openSansRegular(@"OpenSans-Bold.ttf"), 18);
            lblRecetelerim.Font = new Font(openSansRegular(@"OpenSans-Bold.ttf"), 18);
            lbl_ilaclar.Font = new Font(openSansRegular(@"OpenSans-Bold.ttf"), 18);

        }

        FontFamily openSansRegular(string dosyayolu)
        {
            PrivateFontCollection fontlar = new PrivateFontCollection();
            fontlar.AddFontFile("fonts/OpenSans-Regular.ttf");
            return fontlar.Families[0];
        }
        FontFamily openSansBold(string dosyayolu)
        {
            PrivateFontCollection fontlar = new PrivateFontCollection();
            fontlar.AddFontFile("fonts/OpenSans-Bold.ttf");
            return fontlar.Families[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Randevuyu onaylamak istiyor musunuz?", "Randevuyu Onayla",MessageBoxButtons.YesNo);
        }

        private void btn_pnlAnasayfa_RandevuAl_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Visible = false;
            pnlGirisYap.Visible = true;
            pnlGirisYap.Location = new Point(0, 0);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            pnlGirisYap.Visible = false;
            pnlRandevuAra.Visible = true;
            pnlRandevuAra.Location = new Point(0, 0);
        }

        private void btnRandevularim_Click(object sender, EventArgs e)
        {
            pnlRandevuAra.Visible = false;
            pnlRandevularim.Visible = true;
            pnlRandevularim.Location = new Point(0, 0);
        }

        private void btnRandevularimGeri_Click(object sender, EventArgs e)
        {
            pnlRandevularim.Visible = false;
            pnlRandevuAra.Visible = true;

        }

        private void btnReceteGeri_Click(object sender, EventArgs e)
        {
            pnlRecetelerim.Visible = false;
            pnlRandevuAra.Visible = true;
        }

        private void btnRecetelerim_Click(object sender, EventArgs e)
        {
            pnlRecetelerim.Location = new Point(0, 0);
            pnlRecetelerim.Visible = true;
            pnlRandevuAra.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sayisal s = new sayisal();
        int[] dizi = new int[6];
        int index = 0;
        string sayilar = "";


        private void btSayi_Click(object sender, EventArgs e)
        {
            int sayi;
            bool varyok;
            if (index >= 6)
                btSayi.Enabled = false;
            else
                while (true)
                {
                    //aynı sayi bir daha çekilmesin diye
                    sayi = s.sayi_cek(1, 49);
                    varyok = s.varmi(sayi, dizi);
                    if (varyok == false)
                        dizi[index] = sayi;
                    index++;
                    sayilar = sayilar + " " + sayi.ToString();
                    lbsayilar.Text = sayilar;
                    break;
                }
        }

        private void btDon_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        private void sifirla()
        {
            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = 0;

            index = 0;
            sayilar = "";
            lbsayilar.Text = "";
            btSayi.Enabled = true;
        }

        private void btSirala_Click(object sender, EventArgs e)
        {
            string yazi_hali;
            dizi = s.sirala(dizi);
            yazi_hali = Yaz(dizi);
            lbsirali.Text = yazi_hali;
        }

        string Yaz(int[] dizim)
        {
            string sirali = "";
            for (int i = 0; i < dizim.Length; i++)
                sirali = sirali + " " + dizim[i].ToString();
            return sirali;
        }
    }
}

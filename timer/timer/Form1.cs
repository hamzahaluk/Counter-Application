using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = saat.ToString().PadLeft(2, '0') + ":" + dakika.ToString().PadLeft(2, '0') + ":" + saniye.ToString().PadLeft(2, '0');
            saniye++;
            if (saniye==60)
            {
                dakika++;
                saniye = 0;
                    if (dakika==60)
	                {
                        saat++;
                        dakika = 0;
                        if (saat==24)
                        {
                            saat = 0;
                        }
	                }
            }
         

        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_dur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            saat = 0;
            dakika = 0;
            saniye = 0;
            textBox1.Text = saat.ToString().PadLeft(2, '0') + ":" + dakika.ToString().PadLeft(2, '0') + ":" + saniye.ToString().PadLeft(2, '0');
        }
    }
}

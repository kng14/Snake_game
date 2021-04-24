using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SnakeEng yeni = new SnakeEng();
            yeni.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dusuk materyalli oyunlardandır. bir adet tebesir, matchbox ve düz beton zemin yeterlidir. oyuna katılacaklar düz zemine tebeşirle arabaların yarışacağı pisti çizerler. bu pistin bol virajlı ve uzun bir pist olması makbuldür. pist üzerinde belli yerler pit stop olarak belirlenir, yanan kişinin arabası en yakın pit stoptan oyuna devam eder. mantık basittir: herkes matchbox arabasını başlangıç çizgisine koyar ve sırayla birr - kiii - üç repliği eşliğinde arabasının kıçına hafifçe vurarak pist içinde yürütür. bu yürütme esnasında aracı pistin içinde tutmak, gerekirse diğer arkadaşların arabasının geçişini engellemek esastır. oyunda yanma iki şekilde olur: araç pistin dışına çıkar yahut diğer arkadaşın arabasına dokunur. bu durumda araç en yakın pit stopa koyulur ve oradan devam ettirilir. oyun sonunda kaybedenler kazanan kişiye frukogazoz alır ve eleman gazozunu afiyetle içerken sahip olduğu matchbox'u gıpta ile incelerler...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool basildimi = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!basildimi)
            {
                DialogResult cvp = MessageBox.Show("Devam edilsin mi?", "Kapat",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                if (DialogResult.Yes == cvp)
                {
                    basildimi = true;
                    this.Close();
                }
                else
                    e.Cancel = true;
            }
        }
    }
}

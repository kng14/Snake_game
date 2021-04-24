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
    public partial class SnakeEng : Form
    {
        public SnakeEng()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool basildimi = false;
        private void SnakeEng_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!basildimi)
            {
                DialogResult cvp = MessageBox.Show("Do you want to continue?", "Close",
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

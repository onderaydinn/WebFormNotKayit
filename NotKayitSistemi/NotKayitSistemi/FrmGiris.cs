using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();
                
                frm.Show();
            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();

                frm.Show();
            }
            
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

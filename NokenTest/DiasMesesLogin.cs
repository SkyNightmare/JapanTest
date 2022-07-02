using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokenTest
{
    public partial class DiasMesesLogin : Form
    {
        public DiasMesesLogin()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "3051")
            {
                DiasMeses DiasMesesPass = new DiasMeses();
                DiasMesesPass.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: Passcode erroneo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}

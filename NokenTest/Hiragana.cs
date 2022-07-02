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
    public partial class Hiragana : Form
    {
        public Hiragana()
        {
            InitializeComponent();
        }
        int intentos = 0;

        private void Passcode()
        {
            lbl_Pass.Visible = true;   
        }

        private void btn_Check1_Click(object sender, EventArgs e)
        {

            if (txt_B1.Text == "A" || txt_B1.Text == "a")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B1.Enabled = false;
                btn_Check1.Enabled = false;
                txt_B2.Enabled = true;
                btn_Check2.Enabled = true;
                txt_B2.Focus();
            }
            else
            {
                MessageBox.Show("Vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B1.Text = "";
                txt_B1.Focus();
                intentos++;
            }
        }

        private void btn_Check2_Click(object sender, EventArgs e)
        {
            if (txt_B2.Text == "I" || txt_B2.Text == "i")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B2.Enabled = false;
                btn_Check2.Enabled = false;
                txt_B3.Enabled = true;
                btn_Check3.Enabled = true;
                txt_B3.Focus();
            }
            else
            {
                MessageBox.Show("Vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B2.Text = "";
                txt_B2.Focus();
                intentos++;
            }
        }

        private void btn_Check3_Click(object sender, EventArgs e)
        {
            if (txt_B3.Text == "U" || txt_B3.Text == "u")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B3.Enabled = false;
                btn_Check3.Enabled = false;
                txt_B4.Enabled = true;
                btn_Check4.Enabled = true;
                txt_B4.Focus();
            }
            else
            {
                MessageBox.Show("Vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B3.Text = "";
                txt_B3.Focus();
                intentos++;
            }
        }

        private void btn_Check4_Click(object sender, EventArgs e)
        {
            if (txt_B4.Text == "E" || txt_B4.Text == "e")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B4.Enabled = false;
                btn_Check4.Enabled = false;
                txt_B5.Enabled = true;
                btn_Check5.Enabled = true;
                txt_B5.Focus();
            }
            else
            {
                MessageBox.Show("Vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B4.Text = "";
                txt_B4.Focus();
                intentos++;
            }
        }

        private void btn_Check5_Click(object sender, EventArgs e)
        {
            if (txt_B5.Text == "O" || txt_B5.Text == "o")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B5.Enabled = false;
                btn_Check5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_B5.Text = "";
                txt_B5.Focus();
                intentos++;
            }
            if (btn_Check5.Enabled == false)
            {
                btn_Cont.Visible = true;
                lbl_fin.Visible = true;
                lbl_fin.Text = "Felicidades lo lograste! Fallastes "+ intentos+ " veces en el intento.";
                Passcode();
            }
        }

        private void btn_Cont_Click(object sender, EventArgs e)
        {
            new QuizKanji().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}


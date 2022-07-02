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
    public partial class DragDrop : Form
    {
        public DragDrop()
        {
            InitializeComponent();
            timer1.Interval = 250;
            timer1.Start();
        }

        bool blink_on = false;
        int contador = 0;

        private void DragDrop_Load(object sender, EventArgs e)
        {
            pb_Main.AllowDrop = true;     
        }

        private void Passcode()
        {
            if (contador == 4)
            {
                lbl_Pass.Visible = true;
            }
        }

        private void pb_Img1_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Img1.DoDragDrop(pb_Img1.Image, DragDropEffects.Copy);  //verificar el copy
        }

        private void pb_Img2_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Img2.DoDragDrop(pb_Img2.Image, DragDropEffects.Copy);
        }

        private void pb_Img3_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Img3.DoDragDrop(pb_Img3.Image, DragDropEffects.Copy);
        }

        private void pb_Img4_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Img4.DoDragDrop(pb_Img4.Image, DragDropEffects.Copy);
        }

        private void pb_Main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb_Main_DragDrop(object sender, DragEventArgs e)
        {
            pb_Main.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if(pb_Main.Image == pb_Img1.Image)
            {
                lbl_Oracion.Text = "辞書___新しい言葉を引きながら,新聞を読みました";
                txt_Respuesta.Enabled = true;
                btn_Check.Enabled = true;
                txt_Respuesta.Clear();
            }
            if (pb_Main.Image == pb_Img2.Image)
            {
                lbl_Oracion.Text = "お金はない___夢はある";
                txt_Respuesta.Enabled = true;
                btn_Check.Enabled = true;
                txt_Respuesta.Clear();
            }
            if (pb_Main.Image == pb_Img3.Image)
            {
                lbl_Oracion.Text = "明日は雨___降る。";
                txt_Respuesta.Enabled = true;
                btn_Check.Enabled = true;
                txt_Respuesta.Clear();
            }
            if (pb_Main.Image == pb_Img4.Image)
            {
                lbl_Oracion.Text = "私___できる。";
                txt_Respuesta.Enabled = true;
                btn_Check.Enabled = true;
                txt_Respuesta.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(blink_on)
            {
                label2.ForeColor = Color.Red;
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.ForeColor = Color.Black;
                label2.ForeColor = Color.Red;
            }
            blink_on = !blink_on;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbl_Resp1.Visible = true;
            lbl_Resp2.Visible = true;
            lbl_Resp3.Visible = true;
            lbl_Resp4.Visible = true;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (pb_Main.Image == pb_Img1.Image && txt_Respuesta.Text == "DE" || txt_Respuesta.Text == "で")
            {
                contador++;
                lbl_Contador.Text = "" + contador + "/4";
                lbl_Contador.Visible = true;
                pb_Img1.Enabled = false;
                btn_Check.Enabled = false;
                Passcode();
            }
            else if (pb_Main.Image == pb_Img2.Image && txt_Respuesta.Text == "KEDO" || txt_Respuesta.Text == "けど") 
            {
                contador++;
                lbl_Contador.Text = "" + contador + "/4";
                lbl_Contador.Visible = true;
                pb_Img2.Enabled = false;
                btn_Check.Enabled = false;
                Passcode();
            }
            else if (pb_Main.Image == pb_Img3.Image && txt_Respuesta.Text == "GA" || txt_Respuesta.Text == "が") 
            {
                contador++;
                lbl_Contador.Text = "" + contador + "/4";
                lbl_Contador.Visible = true;
                pb_Img3.Enabled = false;
                btn_Check.Enabled = false;
                Passcode();
            }
            else if (pb_Main.Image == pb_Img4.Image && txt_Respuesta.Text == "MO" || txt_Respuesta.Text == "も")
            {
                contador++;
                lbl_Contador.Text = "" + contador + "/4";
                lbl_Contador.Visible = true;
                pb_Img4.Enabled = false;
                btn_Check.Enabled = false;
                Passcode();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}

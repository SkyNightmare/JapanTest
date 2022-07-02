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
    public partial class DiasMeses : Form
    {
        public DiasMeses()
        {
            InitializeComponent();

            //Tooltip para Dias

            ToolTip sunToolTip = new ToolTip();
            sunToolTip.ToolTipTitle = "にちようび";
            sunToolTip.UseFading = true;
            sunToolTip.UseAnimation = true;
            sunToolTip.IsBalloon = true;
            sunToolTip.ShowAlways = true;
            sunToolTip.AutoPopDelay = 1000;
            sunToolTip.InitialDelay = 1000;
            sunToolTip.ReshowDelay = 500;
            sunToolTip.SetToolTip(lbl_Sun, "Nichiyoubi");

            ToolTip monToolTip = new ToolTip();
            monToolTip.ToolTipTitle = "げつようび";
            monToolTip.UseFading = true;
            monToolTip.UseAnimation = true;
            monToolTip.IsBalloon = true;
            monToolTip.ShowAlways = true;
            monToolTip.AutoPopDelay = 1000;
            monToolTip.InitialDelay = 1000;
            monToolTip.ReshowDelay = 500;
            monToolTip.SetToolTip(lbl_Mon, "Getsuyoubi");

            ToolTip tuesToolTip = new ToolTip();
            tuesToolTip.ToolTipTitle = "かようび";
            tuesToolTip.UseFading = true;
            tuesToolTip.UseAnimation = true;
            tuesToolTip.IsBalloon = true;
            tuesToolTip.ShowAlways = true;
            tuesToolTip.AutoPopDelay = 1000;
            tuesToolTip.InitialDelay = 1000;
            tuesToolTip.ReshowDelay = 500;
            tuesToolTip.SetToolTip(lbl_Tues, "Kayoubi");

            ToolTip wedToolTip = new ToolTip();
            wedToolTip.ToolTipTitle = "すいようび";
            wedToolTip.UseFading = true;
            wedToolTip.UseAnimation = true;
            wedToolTip.IsBalloon = true;
            wedToolTip.ShowAlways = true;
            wedToolTip.AutoPopDelay = 1000;
            wedToolTip.InitialDelay = 1000;
            wedToolTip.ReshowDelay = 500;
            wedToolTip.SetToolTip(lbl_Wed, "Suiyoubi");

            ToolTip thursToolTip = new ToolTip();
            thursToolTip.ToolTipTitle = "もくようび";
            thursToolTip.UseFading = true;
            thursToolTip.UseAnimation = true;
            thursToolTip.IsBalloon = true;
            thursToolTip.ShowAlways = true;
            thursToolTip.AutoPopDelay = 1000;
            thursToolTip.InitialDelay = 1000;
            thursToolTip.ReshowDelay = 500;
            thursToolTip.SetToolTip(lbl_Thurs, "Mokuyoubi");

            ToolTip friToolTip = new ToolTip();
            friToolTip.ToolTipTitle = "きんようび";
            friToolTip.UseFading = true;
            friToolTip.UseAnimation = true;
            friToolTip.IsBalloon = true;
            friToolTip.ShowAlways = true;
            friToolTip.AutoPopDelay = 1000;
            friToolTip.InitialDelay = 1000;
            friToolTip.ReshowDelay = 500;
            friToolTip.SetToolTip(lbl_Fri, "Kinyoubi");

            ToolTip saturToolTip = new ToolTip();
            saturToolTip.ToolTipTitle = "どようび";
            saturToolTip.UseFading = true;
            saturToolTip.UseAnimation = true;
            saturToolTip.IsBalloon = true;
            saturToolTip.ShowAlways = true;
            saturToolTip.AutoPopDelay = 1000;
            saturToolTip.InitialDelay = 1000;
            saturToolTip.ReshowDelay = 500;
            saturToolTip.SetToolTip(lbl_Satur, "Doyoubi");

            //Tooltip para Meses

            ToolTip marToolTip = new ToolTip();
            marToolTip.ToolTipTitle = "さんがつ";
            marToolTip.UseFading = true;
            marToolTip.UseAnimation = true;
            marToolTip.IsBalloon = true;
            marToolTip.ShowAlways = true;
            marToolTip.AutoPopDelay = 1000;
            marToolTip.InitialDelay = 1000;
            marToolTip.ReshowDelay = 500;
            marToolTip.SetToolTip(lbl_Mar, "Sangatsu");

            ToolTip agoToolTip = new ToolTip();
            agoToolTip.ToolTipTitle = "はちがつ";
            agoToolTip.UseFading = true;
            agoToolTip.UseAnimation = true;
            agoToolTip.IsBalloon = true;
            agoToolTip.ShowAlways = true;
            agoToolTip.AutoPopDelay = 1000;
            agoToolTip.InitialDelay = 1000;
            agoToolTip.ReshowDelay = 500;
            agoToolTip.SetToolTip(lbl_Ago, "Hachigatsu");

            ToolTip septToolTip = new ToolTip();
            septToolTip.ToolTipTitle = "くがつ";
            septToolTip.UseFading = true;
            septToolTip.UseAnimation = true;
            septToolTip.IsBalloon = true;
            septToolTip.ShowAlways = true;
            septToolTip.AutoPopDelay = 1000;
            septToolTip.InitialDelay = 1000;
            septToolTip.ReshowDelay = 500;
            septToolTip.SetToolTip(lbl_Sept, "Kugatsu");

            ToolTip febToolTip = new ToolTip();
            febToolTip.ToolTipTitle = "にがつ";
            febToolTip.UseFading = true;
            febToolTip.UseAnimation = true;
            febToolTip.IsBalloon = true;
            febToolTip.ShowAlways = true;
            febToolTip.AutoPopDelay = 1000;
            febToolTip.InitialDelay = 1000;
            febToolTip.ReshowDelay = 500;
            febToolTip.SetToolTip(lbl_Feb, "Nigatsu");

            ToolTip julToolTip = new ToolTip();
            julToolTip.ToolTipTitle = "しちがつ";
            julToolTip.UseFading = true;
            julToolTip.UseAnimation = true;
            julToolTip.IsBalloon = true;
            julToolTip.ShowAlways = true;
            julToolTip.AutoPopDelay = 1000;
            julToolTip.InitialDelay = 1000;
            julToolTip.ReshowDelay = 500;
            julToolTip.SetToolTip(lbl_Jul, "Shichigatsu");

            ToolTip janToolTip = new ToolTip();
            janToolTip.ToolTipTitle = "いちがつ";
            janToolTip.UseFading = true;
            janToolTip.UseAnimation = true;
            janToolTip.IsBalloon = true;
            janToolTip.ShowAlways = true;
            janToolTip.AutoPopDelay = 1000;
            janToolTip.InitialDelay = 1000;
            janToolTip.ReshowDelay = 500;
            janToolTip.SetToolTip(lbl_Jan, "Ichigatsu");

            ToolTip octToolTip = new ToolTip();
            octToolTip.ToolTipTitle = "じゅうがつ";
            octToolTip.UseFading = true;
            octToolTip.UseAnimation = true;
            octToolTip.IsBalloon = true;
            octToolTip.ShowAlways = true;
            octToolTip.AutoPopDelay = 1000;
            octToolTip.InitialDelay = 1000;
            octToolTip.ReshowDelay = 500;
            octToolTip.SetToolTip(lbl_Oct, "Juugatsu");

            ToolTip mayToolTip = new ToolTip();
            mayToolTip.ToolTipTitle = "ごがつ";
            mayToolTip.UseFading = true;
            mayToolTip.UseAnimation = true;
            mayToolTip.IsBalloon = true;
            mayToolTip.ShowAlways = true;
            mayToolTip.AutoPopDelay = 1000;
            mayToolTip.InitialDelay = 1000;
            mayToolTip.ReshowDelay = 500;
            mayToolTip.SetToolTip(lbl_May, "Gogatsu");

            ToolTip junToolTip = new ToolTip();
            junToolTip.ToolTipTitle = "ろくがつ";
            junToolTip.UseFading = true;
            junToolTip.UseAnimation = true;
            junToolTip.IsBalloon = true;
            junToolTip.ShowAlways = true;
            junToolTip.AutoPopDelay = 1000;
            junToolTip.InitialDelay = 1000;
            junToolTip.ReshowDelay = 500;
            junToolTip.SetToolTip(lbl_Jun, "Rokugatsu");

            ToolTip dicToolTip = new ToolTip();
            dicToolTip.ToolTipTitle = "じゅうにがつ";
            dicToolTip.UseFading = true;
            dicToolTip.UseAnimation = true;
            dicToolTip.IsBalloon = true;
            dicToolTip.ShowAlways = true;
            dicToolTip.AutoPopDelay = 1000;
            dicToolTip.InitialDelay = 1000;
            dicToolTip.ReshowDelay = 500;
            dicToolTip.SetToolTip(lbl_Dic, "Juunigatsu");

            ToolTip abrToolTip = new ToolTip();
            abrToolTip.ToolTipTitle = "しがつ";
            abrToolTip.UseFading = true;
            abrToolTip.UseAnimation = true;
            abrToolTip.IsBalloon = true;
            abrToolTip.ShowAlways = true;
            abrToolTip.AutoPopDelay = 1000;
            abrToolTip.InitialDelay = 1000;
            abrToolTip.ReshowDelay = 500;
            abrToolTip.SetToolTip(lbl_Abr, "Shigatsu");

            ToolTip novToolTip = new ToolTip();
            novToolTip.ToolTipTitle = "じゅういちがつ";
            novToolTip.UseFading = true;
            novToolTip.UseAnimation = true;
            novToolTip.IsBalloon = true;
            novToolTip.ShowAlways = true;
            novToolTip.AutoPopDelay = 1000;
            novToolTip.InitialDelay = 1000;
            novToolTip.ReshowDelay = 500;
            novToolTip.SetToolTip(lbl_Dic, "Juuichigatsu");
        }
        private void Passcode()
        {
                lbl_Pass.Visible = true;   
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Tues.Text == "B"  && txt_Fri.Text == "E"  
                && txt_Wed.Text == "C"  && txt_Sun.Text == "G" 
                && txt_Satur.Text == "F"  && txt_Mon.Text == "A" 
                && txt_Thurs.Text == "D")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_Send.Enabled = false;
                //b e c g f a d
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Send2_Click(object sender, EventArgs e)
        {
            if (txt_Mar.Text == "C" && txt_Ago.Text == "H"
                && txt_Sept.Text == "I" && txt_Feb.Text == "B"
                && txt_Jul.Text == "G" && txt_Jan.Text == "A"
                && txt_Oct.Text == "J" && txt_May.Text == "E"
                && txt_Jun.Text == "F" && txt_Dic.Text == "L"
                && txt_Abr.Text == "D" && txt_Nov.Text == "K")
            {
                MessageBox.Show("Respuesta correcta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_Send2.Enabled = false;
                //c h i b g a j e f l d k 
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta vuelve a intentarlo", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (btn_Send.Enabled == false && btn_Send2.Enabled == false)
            {
                btn_Cont.Visible = true;
                Passcode();
            }
        }

        private void btn_Cont_Click(object sender, EventArgs e)
        {
            new DragDrop().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}

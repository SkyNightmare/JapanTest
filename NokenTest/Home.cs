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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.White;
            menuStrip1.Renderer = new Renders();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        private class Renders : ToolStripProfessionalRenderer
        {
            public Renders() : base(new Colores()) { }
        }

        private class Colores : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Red; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Red; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Red; }
            }
        }
        private void numerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NumerosLogin().Show();
            this.Hide();
        }

        private void hiraganaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HiraganaLogin().Show();
            this.Hide();
        }

        private void diasYMesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DiasMesesLogin().Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .3;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Katakana().Show();
            this.Hide();
        }

        private void oracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OracionesLogin().Show();
            this.Hide();
        }

        private void katakanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Katakana().Show();
            this.Hide();
        }
    }
}

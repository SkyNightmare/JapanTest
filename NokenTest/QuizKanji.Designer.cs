namespace NokenTest
{
    partial class QuizKanji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizKanji));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPreg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_Reinciar = new System.Windows.Forms.Button();
            this.btn_Cont = new System.Windows.Forms.Button();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NokenTest.Properties.Resources.questionmark;
            this.pictureBox1.Location = new System.Drawing.Point(263, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPreg
            // 
            this.lblPreg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreg.Location = new System.Drawing.Point(32, 312);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(811, 39);
            this.lblPreg.TabIndex = 1;
            this.lblPreg.Text = "Preguntas";
            this.lblPreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreg.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(41, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 47);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(473, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 47);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(41, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 47);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(473, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(355, 47);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(263, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(381, 50);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "QUIZ KANJI(Numeros)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Reinciar
            // 
            this.btn_Reinciar.BackColor = System.Drawing.Color.White;
            this.btn_Reinciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reinciar.ForeColor = System.Drawing.Color.Red;
            this.btn_Reinciar.Location = new System.Drawing.Point(74, 165);
            this.btn_Reinciar.Name = "btn_Reinciar";
            this.btn_Reinciar.Size = new System.Drawing.Size(131, 54);
            this.btn_Reinciar.TabIndex = 8;
            this.btn_Reinciar.Text = "Reiniciar";
            this.btn_Reinciar.UseVisualStyleBackColor = false;
            this.btn_Reinciar.Visible = false;
            this.btn_Reinciar.Click += new System.EventHandler(this.btn_Reinciar_Click);
            // 
            // btn_Cont
            // 
            this.btn_Cont.BackColor = System.Drawing.Color.White;
            this.btn_Cont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cont.ForeColor = System.Drawing.Color.Red;
            this.btn_Cont.Location = new System.Drawing.Point(661, 165);
            this.btn_Cont.Name = "btn_Cont";
            this.btn_Cont.Size = new System.Drawing.Size(131, 54);
            this.btn_Cont.TabIndex = 9;
            this.btn_Cont.Text = "Continuar";
            this.btn_Cont.UseVisualStyleBackColor = false;
            this.btn_Cont.Visible = false;
            this.btn_Cont.Click += new System.EventHandler(this.btn_Cont_Click);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(369, 539);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(120, 20);
            this.lbl_Pass.TabIndex = 10;
            this.lbl_Pass.Text = "PASSCODE: 7710";
            this.lbl_Pass.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::NokenTest.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(24, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // QuizKanji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.btn_Cont);
            this.Controls.Add(this.btn_Reinciar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPreg);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuizKanji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblPreg;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblTitulo;
        private Button btn_Reinciar;
        private Button btn_Cont;
        private Label lbl_Pass;
        private PictureBox pictureBox2;
    }
}
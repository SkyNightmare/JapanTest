namespace NokenTest
{
    partial class DragDrop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragDrop));
            this.pb_Img1 = new System.Windows.Forms.PictureBox();
            this.pb_Img2 = new System.Windows.Forms.PictureBox();
            this.pb_Img3 = new System.Windows.Forms.PictureBox();
            this.pb_Img4 = new System.Windows.Forms.PictureBox();
            this.pb_Main = new System.Windows.Forms.PictureBox();
            this.lbl_Oracion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Respuesta = new System.Windows.Forms.TextBox();
            this.lbl_Resp1 = new System.Windows.Forms.Label();
            this.lbl_Resp2 = new System.Windows.Forms.Label();
            this.lbl_Resp3 = new System.Windows.Forms.Label();
            this.lbl_Resp4 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Img1
            // 
            this.pb_Img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Img1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Img1.Image = global::NokenTest.Properties.Resources.Newspaper;
            this.pb_Img1.Location = new System.Drawing.Point(56, 85);
            this.pb_Img1.Name = "pb_Img1";
            this.pb_Img1.Size = new System.Drawing.Size(151, 95);
            this.pb_Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Img1.TabIndex = 0;
            this.pb_Img1.TabStop = false;
            this.pb_Img1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Img1_MouseDown);
            // 
            // pb_Img2
            // 
            this.pb_Img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Img2.Image = global::NokenTest.Properties.Resources.Dream;
            this.pb_Img2.Location = new System.Drawing.Point(224, 85);
            this.pb_Img2.Name = "pb_Img2";
            this.pb_Img2.Size = new System.Drawing.Size(146, 95);
            this.pb_Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Img2.TabIndex = 1;
            this.pb_Img2.TabStop = false;
            this.pb_Img2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Img2_MouseDown);
            // 
            // pb_Img3
            // 
            this.pb_Img3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Img3.Image = global::NokenTest.Properties.Resources.Rainy;
            this.pb_Img3.Location = new System.Drawing.Point(389, 85);
            this.pb_Img3.Name = "pb_Img3";
            this.pb_Img3.Size = new System.Drawing.Size(143, 95);
            this.pb_Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Img3.TabIndex = 2;
            this.pb_Img3.TabStop = false;
            this.pb_Img3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Img3_MouseDown);
            // 
            // pb_Img4
            // 
            this.pb_Img4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Img4.Image = global::NokenTest.Properties.Resources.Ican;
            this.pb_Img4.Location = new System.Drawing.Point(555, 85);
            this.pb_Img4.Name = "pb_Img4";
            this.pb_Img4.Size = new System.Drawing.Size(159, 95);
            this.pb_Img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Img4.TabIndex = 3;
            this.pb_Img4.TabStop = false;
            this.pb_Img4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Img4_MouseDown);
            // 
            // pb_Main
            // 
            this.pb_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Main.Location = new System.Drawing.Point(210, 205);
            this.pb_Main.Name = "pb_Main";
            this.pb_Main.Size = new System.Drawing.Size(435, 259);
            this.pb_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Main.TabIndex = 4;
            this.pb_Main.TabStop = false;
            this.pb_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.pb_Main_DragDrop);
            this.pb_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.pb_Main_DragEnter);
            // 
            // lbl_Oracion
            // 
            this.lbl_Oracion.AutoSize = true;
            this.lbl_Oracion.Location = new System.Drawing.Point(200, 484);
            this.lbl_Oracion.Name = "lbl_Oracion";
            this.lbl_Oracion.Size = new System.Drawing.Size(147, 20);
            this.lbl_Oracion.TabIndex = 5;
            this.lbl_Oracion.Text = "Arrastra una imagen ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ayuda!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(322, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(172, 31);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Drag and Drop";
            // 
            // txt_Respuesta
            // 
            this.txt_Respuesta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Respuesta.Enabled = false;
            this.txt_Respuesta.Location = new System.Drawing.Point(533, 476);
            this.txt_Respuesta.Name = "txt_Respuesta";
            this.txt_Respuesta.Size = new System.Drawing.Size(100, 27);
            this.txt_Respuesta.TabIndex = 8;
            // 
            // lbl_Resp1
            // 
            this.lbl_Resp1.AutoSize = true;
            this.lbl_Resp1.Location = new System.Drawing.Point(80, 269);
            this.lbl_Resp1.Name = "lbl_Resp1";
            this.lbl_Resp1.Size = new System.Drawing.Size(22, 20);
            this.lbl_Resp1.TabIndex = 9;
            this.lbl_Resp1.Text = "が";
            this.lbl_Resp1.Visible = false;
            // 
            // lbl_Resp2
            // 
            this.lbl_Resp2.AutoSize = true;
            this.lbl_Resp2.Location = new System.Drawing.Point(80, 298);
            this.lbl_Resp2.Name = "lbl_Resp2";
            this.lbl_Resp2.Size = new System.Drawing.Size(22, 20);
            this.lbl_Resp2.TabIndex = 10;
            this.lbl_Resp2.Text = "で";
            this.lbl_Resp2.Visible = false;
            // 
            // lbl_Resp3
            // 
            this.lbl_Resp3.AutoSize = true;
            this.lbl_Resp3.Location = new System.Drawing.Point(80, 331);
            this.lbl_Resp3.Name = "lbl_Resp3";
            this.lbl_Resp3.Size = new System.Drawing.Size(32, 20);
            this.lbl_Resp3.TabIndex = 11;
            this.lbl_Resp3.Text = "けど";
            this.lbl_Resp3.Visible = false;
            // 
            // lbl_Resp4
            // 
            this.lbl_Resp4.AutoSize = true;
            this.lbl_Resp4.Location = new System.Drawing.Point(80, 364);
            this.lbl_Resp4.Name = "lbl_Resp4";
            this.lbl_Resp4.Size = new System.Drawing.Size(21, 20);
            this.lbl_Resp4.TabIndex = 12;
            this.lbl_Resp4.Text = "も";
            this.lbl_Resp4.Visible = false;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.White;
            this.btn_Check.Enabled = false;
            this.btn_Check.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Check.ForeColor = System.Drawing.Color.Red;
            this.btn_Check.Location = new System.Drawing.Point(650, 475);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(106, 29);
            this.btn_Check.TabIndex = 13;
            this.btn_Check.Text = "Enviar";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Location = new System.Drawing.Point(78, 458);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(31, 20);
            this.lbl_Contador.TabIndex = 14;
            this.lbl_Contador.Text = "0/4";
            this.lbl_Contador.Visible = false;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(38, 495);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(120, 20);
            this.lbl_Pass.TabIndex = 15;
            this.lbl_Pass.Text = "PASSCODE: 0962";
            this.lbl_Pass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NokenTest.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(15, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Contador);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.lbl_Resp4);
            this.Controls.Add(this.lbl_Resp3);
            this.Controls.Add(this.lbl_Resp2);
            this.Controls.Add(this.lbl_Resp1);
            this.Controls.Add(this.txt_Respuesta);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Oracion);
            this.Controls.Add(this.pb_Main);
            this.Controls.Add(this.pb_Img4);
            this.Controls.Add(this.pb_Img3);
            this.Controls.Add(this.pb_Img2);
            this.Controls.Add(this.pb_Img1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DragDrop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragDrop";
            this.Load += new System.EventHandler(this.DragDrop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_Img1;
        private PictureBox pb_Img2;
        private PictureBox pb_Img3;
        private PictureBox pb_Img4;
        private PictureBox pb_Main;
        private Label lbl_Oracion;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_Titulo;
        private TextBox txt_Respuesta;
        private Label lbl_Resp1;
        private Label lbl_Resp2;
        private Label lbl_Resp3;
        private Label lbl_Resp4;
        private Button btn_Check;
        private Label lbl_Contador;
        private Label lbl_Pass;
        private PictureBox pictureBox1;
    }
}
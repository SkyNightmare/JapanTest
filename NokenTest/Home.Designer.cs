namespace NokenTest
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escrituraJaponesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katakanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiraganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diasYMesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.btn_Close = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escrituraJaponesaToolStripMenuItem,
            this.numerosToolStripMenuItem,
            this.diasYMesesToolStripMenuItem,
            this.oracionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escrituraJaponesaToolStripMenuItem
            // 
            this.escrituraJaponesaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katakanaToolStripMenuItem,
            this.hiraganaToolStripMenuItem});
            this.escrituraJaponesaToolStripMenuItem.Name = "escrituraJaponesaToolStripMenuItem";
            this.escrituraJaponesaToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.escrituraJaponesaToolStripMenuItem.Text = "Escritura Japonesa";
            // 
            // katakanaToolStripMenuItem
            // 
            this.katakanaToolStripMenuItem.Name = "katakanaToolStripMenuItem";
            this.katakanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.katakanaToolStripMenuItem.Text = "Katakana";
            this.katakanaToolStripMenuItem.Click += new System.EventHandler(this.katakanaToolStripMenuItem_Click);
            // 
            // hiraganaToolStripMenuItem
            // 
            this.hiraganaToolStripMenuItem.Name = "hiraganaToolStripMenuItem";
            this.hiraganaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiraganaToolStripMenuItem.Text = "Hiragana";
            this.hiraganaToolStripMenuItem.Click += new System.EventHandler(this.hiraganaToolStripMenuItem_Click);
            // 
            // numerosToolStripMenuItem
            // 
            this.numerosToolStripMenuItem.Name = "numerosToolStripMenuItem";
            this.numerosToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.numerosToolStripMenuItem.Text = "Numeros";
            this.numerosToolStripMenuItem.Click += new System.EventHandler(this.numerosToolStripMenuItem_Click);
            // 
            // diasYMesesToolStripMenuItem
            // 
            this.diasYMesesToolStripMenuItem.Name = "diasYMesesToolStripMenuItem";
            this.diasYMesesToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.diasYMesesToolStripMenuItem.Text = "Dias y meses";
            this.diasYMesesToolStripMenuItem.Click += new System.EventHandler(this.diasYMesesToolStripMenuItem_Click);
            // 
            // oracionesToolStripMenuItem
            // 
            this.oracionesToolStripMenuItem.Name = "oracionesToolStripMenuItem";
            this.oracionesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.oracionesToolStripMenuItem.Text = "Oraciones";
            this.oracionesToolStripMenuItem.Click += new System.EventHandler(this.oracionesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Mincho", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(281, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "始める";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fadeOut
            // 
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.ForeColor = System.Drawing.Color.Red;
            this.btn_Close.Location = new System.Drawing.Point(642, 385);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(146, 53);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Salir";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NokenTest.Properties.Resources.japonBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem escrituraJaponesaToolStripMenuItem;
        private ToolStripMenuItem hiraganaToolStripMenuItem;
        private ToolStripMenuItem katakanaToolStripMenuItem;
        private ToolStripMenuItem numerosToolStripMenuItem;
        private ToolStripMenuItem diasYMesesToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Timer fadeOut;
        private Button btn_Close;
        private ToolStripMenuItem oracionesToolStripMenuItem;
    }
}
namespace JuegoPokemon
{
    partial class Batalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batalla));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VidaPokemon1Label = new System.Windows.Forms.Label();
            this.NombrePokemon1Label = new System.Windows.Forms.Label();
            this.NombreJugador1Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VidaPokemon2Label = new System.Windows.Forms.Label();
            this.NombrePokemon2Label = new System.Windows.Forms.Label();
            this.NombreJugador2Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Jugador1ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Jugador2ComboBox = new System.Windows.Forms.ComboBox();
            this.Pokemon2PictureBox = new System.Windows.Forms.PictureBox();
            this.Pokemon1PictureBox = new System.Windows.Forms.PictureBox();
            this.Rendirse1Button = new System.Windows.Forms.Button();
            this.Rendirse2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1584, 841);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VidaPokemon1Label);
            this.panel1.Controls.Add(this.NombrePokemon1Label);
            this.panel1.Controls.Add(this.NombreJugador1Label);
            this.panel1.Location = new System.Drawing.Point(49, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VidaPokemon1Label
            // 
            this.VidaPokemon1Label.AutoSize = true;
            this.VidaPokemon1Label.BackColor = System.Drawing.Color.Black;
            this.VidaPokemon1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VidaPokemon1Label.ForeColor = System.Drawing.Color.White;
            this.VidaPokemon1Label.Location = new System.Drawing.Point(47, 93);
            this.VidaPokemon1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VidaPokemon1Label.Name = "VidaPokemon1Label";
            this.VidaPokemon1Label.Size = new System.Drawing.Size(57, 20);
            this.VidaPokemon1Label.TabIndex = 2;
            this.VidaPokemon1Label.Text = "label6";
            this.VidaPokemon1Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // NombrePokemon1Label
            // 
            this.NombrePokemon1Label.AutoSize = true;
            this.NombrePokemon1Label.BackColor = System.Drawing.Color.Black;
            this.NombrePokemon1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePokemon1Label.ForeColor = System.Drawing.Color.White;
            this.NombrePokemon1Label.Location = new System.Drawing.Point(47, 44);
            this.NombrePokemon1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombrePokemon1Label.Name = "NombrePokemon1Label";
            this.NombrePokemon1Label.Size = new System.Drawing.Size(57, 20);
            this.NombrePokemon1Label.TabIndex = 1;
            this.NombrePokemon1Label.Text = "label4";
            // 
            // NombreJugador1Label
            // 
            this.NombreJugador1Label.AutoSize = true;
            this.NombreJugador1Label.BackColor = System.Drawing.Color.Black;
            this.NombreJugador1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreJugador1Label.ForeColor = System.Drawing.Color.White;
            this.NombreJugador1Label.Location = new System.Drawing.Point(47, 11);
            this.NombreJugador1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreJugador1Label.Name = "NombreJugador1Label";
            this.NombreJugador1Label.Size = new System.Drawing.Size(57, 20);
            this.NombreJugador1Label.TabIndex = 0;
            this.NombreJugador1Label.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.VidaPokemon2Label);
            this.panel2.Controls.Add(this.NombrePokemon2Label);
            this.panel2.Controls.Add(this.NombreJugador2Label);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1221, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 130);
            this.panel2.TabIndex = 3;
            // 
            // VidaPokemon2Label
            // 
            this.VidaPokemon2Label.AutoSize = true;
            this.VidaPokemon2Label.BackColor = System.Drawing.Color.Black;
            this.VidaPokemon2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VidaPokemon2Label.ForeColor = System.Drawing.Color.White;
            this.VidaPokemon2Label.Location = new System.Drawing.Point(52, 93);
            this.VidaPokemon2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VidaPokemon2Label.Name = "VidaPokemon2Label";
            this.VidaPokemon2Label.Size = new System.Drawing.Size(57, 20);
            this.VidaPokemon2Label.TabIndex = 2;
            this.VidaPokemon2Label.Text = "label7";
            this.VidaPokemon2Label.Click += new System.EventHandler(this.VidaPokemon2Label_Click);
            // 
            // NombrePokemon2Label
            // 
            this.NombrePokemon2Label.AutoSize = true;
            this.NombrePokemon2Label.BackColor = System.Drawing.Color.Black;
            this.NombrePokemon2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePokemon2Label.ForeColor = System.Drawing.Color.White;
            this.NombrePokemon2Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NombrePokemon2Label.Location = new System.Drawing.Point(52, 44);
            this.NombrePokemon2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombrePokemon2Label.Name = "NombrePokemon2Label";
            this.NombrePokemon2Label.Size = new System.Drawing.Size(57, 20);
            this.NombrePokemon2Label.TabIndex = 1;
            this.NombrePokemon2Label.Text = "label5";
            this.NombrePokemon2Label.Click += new System.EventHandler(this.NombrePokemon2Label_Click);
            // 
            // NombreJugador2Label
            // 
            this.NombreJugador2Label.AutoSize = true;
            this.NombreJugador2Label.BackColor = System.Drawing.Color.Black;
            this.NombreJugador2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreJugador2Label.ForeColor = System.Drawing.Color.White;
            this.NombreJugador2Label.Location = new System.Drawing.Point(52, 11);
            this.NombreJugador2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreJugador2Label.Name = "NombreJugador2Label";
            this.NombreJugador2Label.Size = new System.Drawing.Size(57, 20);
            this.NombreJugador2Label.TabIndex = 0;
            this.NombreJugador2Label.Text = "label3";
            this.NombreJugador2Label.Click += new System.EventHandler(this.NombreJugador2Label_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(704, 743);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar batalla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Jugador1ComboBox
            // 
            this.Jugador1ComboBox.FormattingEnabled = true;
            this.Jugador1ComboBox.Location = new System.Drawing.Point(49, 249);
            this.Jugador1ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Jugador1ComboBox.Name = "Jugador1ComboBox";
            this.Jugador1ComboBox.Size = new System.Drawing.Size(263, 24);
            this.Jugador1ComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecciona tu ataque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1297, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selecciona tu ataque";
            // 
            // Jugador2ComboBox
            // 
            this.Jugador2ComboBox.FormattingEnabled = true;
            this.Jugador2ComboBox.Location = new System.Drawing.Point(1253, 249);
            this.Jugador2ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Jugador2ComboBox.Name = "Jugador2ComboBox";
            this.Jugador2ComboBox.Size = new System.Drawing.Size(263, 24);
            this.Jugador2ComboBox.TabIndex = 8;
            // 
            // Pokemon2PictureBox
            // 
            this.Pokemon2PictureBox.BackColor = System.Drawing.Color.White;
            this.Pokemon2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pokemon2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Pokemon2PictureBox.Image")));
            this.Pokemon2PictureBox.Location = new System.Drawing.Point(1065, 382);
            this.Pokemon2PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pokemon2PictureBox.Name = "Pokemon2PictureBox";
            this.Pokemon2PictureBox.Size = new System.Drawing.Size(411, 351);
            this.Pokemon2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pokemon2PictureBox.TabIndex = 10;
            this.Pokemon2PictureBox.TabStop = false;
            this.Pokemon2PictureBox.Click += new System.EventHandler(this.Pokemon2PictureBox_Click);
            // 
            // Pokemon1PictureBox
            // 
            this.Pokemon1PictureBox.BackColor = System.Drawing.Color.White;
            this.Pokemon1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pokemon1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Pokemon1PictureBox.Image")));
            this.Pokemon1PictureBox.Location = new System.Drawing.Point(131, 382);
            this.Pokemon1PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pokemon1PictureBox.Name = "Pokemon1PictureBox";
            this.Pokemon1PictureBox.Size = new System.Drawing.Size(400, 351);
            this.Pokemon1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pokemon1PictureBox.TabIndex = 11;
            this.Pokemon1PictureBox.TabStop = false;
            // 
            // Rendirse1Button
            // 
            this.Rendirse1Button.BackColor = System.Drawing.Color.Crimson;
            this.Rendirse1Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Rendirse1Button.Location = new System.Drawing.Point(16, 769);
            this.Rendirse1Button.Margin = new System.Windows.Forms.Padding(4);
            this.Rendirse1Button.Name = "Rendirse1Button";
            this.Rendirse1Button.Size = new System.Drawing.Size(100, 28);
            this.Rendirse1Button.TabIndex = 9;
            this.Rendirse1Button.Text = "Rendirse";
            this.Rendirse1Button.UseVisualStyleBackColor = false;
            // 
            // Rendirse2Button
            // 
            this.Rendirse2Button.BackColor = System.Drawing.Color.Crimson;
            this.Rendirse2Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Rendirse2Button.Location = new System.Drawing.Point(1455, 769);
            this.Rendirse2Button.Margin = new System.Windows.Forms.Padding(4);
            this.Rendirse2Button.Name = "Rendirse2Button";
            this.Rendirse2Button.Size = new System.Drawing.Size(100, 28);
            this.Rendirse2Button.TabIndex = 12;
            this.Rendirse2Button.Text = "Rendirse";
            this.Rendirse2Button.UseVisualStyleBackColor = false;
            // 
            // Batalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 830);
            this.Controls.Add(this.Rendirse2Button);
            this.Controls.Add(this.Pokemon1PictureBox);
            this.Controls.Add(this.Pokemon2PictureBox);
            this.Controls.Add(this.Rendirse1Button);
            this.Controls.Add(this.Jugador2ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Jugador1ComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Batalla";
            this.Text = "Batalla";
            this.Load += new System.EventHandler(this.Batalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VidaPokemon1Label;
        private System.Windows.Forms.Label NombrePokemon1Label;
        private System.Windows.Forms.Label NombreJugador1Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label VidaPokemon2Label;
        private System.Windows.Forms.Label NombrePokemon2Label;
        private System.Windows.Forms.Label NombreJugador2Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Jugador1ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Jugador2ComboBox;
        private System.Windows.Forms.PictureBox Pokemon2PictureBox;
        private System.Windows.Forms.PictureBox Pokemon1PictureBox;
        private System.Windows.Forms.Button Rendirse1Button;
        private System.Windows.Forms.Button Rendirse2Button;
    }
}
namespace JuegoPokemon
{
    partial class HallOfFame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallOfFame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinalizarButton = new System.Windows.Forms.Button();
            this.PokemonGanadorPictureBox = new System.Windows.Forms.PictureBox();
            this.PokemonGanadorLabel = new System.Windows.Forms.Label();
            this.JugadorGanadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonGanadorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 570);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador ganador";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FinalizarButton);
            this.panel1.Controls.Add(this.PokemonGanadorPictureBox);
            this.panel1.Controls.Add(this.PokemonGanadorLabel);
            this.panel1.Controls.Add(this.JugadorGanadorLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 448);
            this.panel1.TabIndex = 2;
            // 
            // FinalizarButton
            // 
            this.FinalizarButton.BackColor = System.Drawing.Color.MediumBlue;
            this.FinalizarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FinalizarButton.Location = new System.Drawing.Point(302, 397);
            this.FinalizarButton.Name = "FinalizarButton";
            this.FinalizarButton.Size = new System.Drawing.Size(107, 43);
            this.FinalizarButton.TabIndex = 3;
            this.FinalizarButton.Text = "Finalizar";
            this.FinalizarButton.UseVisualStyleBackColor = false;
            this.FinalizarButton.Click += new System.EventHandler(this.FinalizarButton_Click);
            // 
            // PokemonGanadorPictureBox
            // 
            this.PokemonGanadorPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PokemonGanadorPictureBox.BackgroundImage")));
            this.PokemonGanadorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PokemonGanadorPictureBox.Location = new System.Drawing.Point(93, 174);
            this.PokemonGanadorPictureBox.Name = "PokemonGanadorPictureBox";
            this.PokemonGanadorPictureBox.Size = new System.Drawing.Size(225, 204);
            this.PokemonGanadorPictureBox.TabIndex = 4;
            this.PokemonGanadorPictureBox.TabStop = false;
            // 
            // PokemonGanadorLabel
            // 
            this.PokemonGanadorLabel.AutoSize = true;
            this.PokemonGanadorLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.PokemonGanadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonGanadorLabel.ForeColor = System.Drawing.Color.White;
            this.PokemonGanadorLabel.Location = new System.Drawing.Point(173, 131);
            this.PokemonGanadorLabel.Name = "PokemonGanadorLabel";
            this.PokemonGanadorLabel.Size = new System.Drawing.Size(52, 18);
            this.PokemonGanadorLabel.TabIndex = 3;
            this.PokemonGanadorLabel.Text = "label2";
            // 
            // JugadorGanadorLabel
            // 
            this.JugadorGanadorLabel.AutoSize = true;
            this.JugadorGanadorLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.JugadorGanadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadorGanadorLabel.ForeColor = System.Drawing.Color.White;
            this.JugadorGanadorLabel.Location = new System.Drawing.Point(173, 68);
            this.JugadorGanadorLabel.Name = "JugadorGanadorLabel";
            this.JugadorGanadorLabel.Size = new System.Drawing.Size(52, 18);
            this.JugadorGanadorLabel.TabIndex = 2;
            this.JugadorGanadorLabel.Text = "label2";
            // 
            // HallOfFame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HallOfFame";
            this.Text = "HallOfFame";
            this.Load += new System.EventHandler(this.HallOfFame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonGanadorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FinalizarButton;
        private System.Windows.Forms.PictureBox PokemonGanadorPictureBox;
        private System.Windows.Forms.Label PokemonGanadorLabel;
        private System.Windows.Forms.Label JugadorGanadorLabel;
    }
}
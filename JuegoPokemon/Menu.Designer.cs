namespace JuegoPokemon
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombrePokemonLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarPokeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreJugadorTextBox = new System.Windows.Forms.TextBox();
            this.GeneroComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarUsuarioButton = new System.Windows.Forms.Button();
            this.JugadoresDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona tu Pokemon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(573, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Pokemon:\r\n";
            // 
            // NombrePokemonLabel
            // 
            this.NombrePokemonLabel.AutoSize = true;
            this.NombrePokemonLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NombrePokemonLabel.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePokemonLabel.ForeColor = System.Drawing.Color.Black;
            this.NombrePokemonLabel.Location = new System.Drawing.Point(841, 251);
            this.NombrePokemonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombrePokemonLabel.Name = "NombrePokemonLabel";
            this.NombrePokemonLabel.Size = new System.Drawing.Size(104, 27);
            this.NombrePokemonLabel.TabIndex = 2;
            this.NombrePokemonLabel.Text = "Nombre";
            this.NombrePokemonLabel.Click += new System.EventHandler(this.NombrePokemonLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(764, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TipoLabel.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoLabel.ForeColor = System.Drawing.Color.Black;
            this.TipoLabel.Location = new System.Drawing.Point(841, 300);
            this.TipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(65, 27);
            this.TipoLabel.TabIndex = 5;
            this.TipoLabel.Text = "Tipo";
            this.TipoLabel.Click += new System.EventHandler(this.TipoLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 152);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PokemonesataGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(138, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Crea tu perfil";
            // 
            // AgregarPokeButton
            // 
            this.AgregarPokeButton.BackColor = System.Drawing.Color.DarkBlue;
            this.AgregarPokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarPokeButton.Location = new System.Drawing.Point(826, 201);
            this.AgregarPokeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarPokeButton.Name = "AgregarPokeButton";
            this.AgregarPokeButton.Size = new System.Drawing.Size(86, 30);
            this.AgregarPokeButton.TabIndex = 8;
            this.AgregarPokeButton.Text = "Agregar";
            this.AgregarPokeButton.UseVisualStyleBackColor = false;
            this.AgregarPokeButton.Click += new System.EventHandler(this.AgregarPokeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre de jugador:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(129, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Genero: ";
            // 
            // NombreJugadorTextBox
            // 
            this.NombreJugadorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreJugadorTextBox.Location = new System.Drawing.Point(243, 186);
            this.NombreJugadorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NombreJugadorTextBox.Name = "NombreJugadorTextBox";
            this.NombreJugadorTextBox.Size = new System.Drawing.Size(191, 26);
            this.NombreJugadorTextBox.TabIndex = 11;
            this.NombreJugadorTextBox.TextChanged += new System.EventHandler(this.NombreJugadorTextBox_TextChanged);
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Location = new System.Drawing.Point(243, 236);
            this.GeneroComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(191, 28);
            this.GeneroComboBox.TabIndex = 12;
            this.GeneroComboBox.SelectedIndexChanged += new System.EventHandler(this.GeneroComboBox_SelectedIndexChanged);
            // 
            // AgregarUsuarioButton
            // 
            this.AgregarUsuarioButton.BackColor = System.Drawing.Color.DarkBlue;
            this.AgregarUsuarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuarioButton.Location = new System.Drawing.Point(346, 292);
            this.AgregarUsuarioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarUsuarioButton.Name = "AgregarUsuarioButton";
            this.AgregarUsuarioButton.Size = new System.Drawing.Size(86, 30);
            this.AgregarUsuarioButton.TabIndex = 13;
            this.AgregarUsuarioButton.Text = "Agregar";
            this.AgregarUsuarioButton.UseVisualStyleBackColor = false;
            this.AgregarUsuarioButton.Click += new System.EventHandler(this.AgregarUsuarioButton_Click);
            // 
            // JugadoresDataGrid
            // 
            this.JugadoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JugadoresDataGrid.Location = new System.Drawing.Point(202, 400);
            this.JugadoresDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.JugadoresDataGrid.Name = "JugadoresDataGrid";
            this.JugadoresDataGrid.RowHeadersWidth = 51;
            this.JugadoresDataGrid.RowTemplate.Height = 24;
            this.JugadoresDataGrid.Size = new System.Drawing.Size(244, 154);
            this.JugadoresDataGrid.TabIndex = 14;
            this.JugadoresDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Elephant", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(205, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jugadores guardados";
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.BackColor = System.Drawing.Color.White;
            this.PokemonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PokemonPictureBox.Image")));
            this.PokemonPictureBox.Location = new System.Drawing.Point(692, 350);
            this.PokemonPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(220, 204);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokemonPictureBox.TabIndex = 3;
            this.PokemonPictureBox.TabStop = false;
            this.PokemonPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.PokemonPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JugadoresDataGrid);
            this.Controls.Add(this.AgregarUsuarioButton);
            this.Controls.Add(this.GeneroComboBox);
            this.Controls.Add(this.NombreJugadorTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgregarPokeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TipoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombrePokemonLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombrePokemonLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AgregarPokeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreJugadorTextBox;
        private System.Windows.Forms.ComboBox GeneroComboBox;
        private System.Windows.Forms.Button AgregarUsuarioButton;
        private System.Windows.Forms.DataGridView JugadoresDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PokemonPictureBox;
    }
}


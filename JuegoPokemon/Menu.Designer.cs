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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NombrePokemonLabel = new System.Windows.Forms.Label();
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
            this.PokeDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.IniciarBatallaButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokeDataGridView)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(803, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona tu Pokemon";
            // 
            // NombrePokemonLabel
            // 
            this.NombrePokemonLabel.AutoSize = true;
            this.NombrePokemonLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NombrePokemonLabel.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePokemonLabel.ForeColor = System.Drawing.Color.Black;
            this.NombrePokemonLabel.Location = new System.Drawing.Point(957, 588);
            this.NombrePokemonLabel.Name = "NombrePokemonLabel";
            this.NombrePokemonLabel.Size = new System.Drawing.Size(104, 27);
            this.NombrePokemonLabel.TabIndex = 2;
            this.NombrePokemonLabel.Text = "Nombre";
            this.NombrePokemonLabel.Click += new System.EventHandler(this.NombrePokemonLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(184, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Crea tu perfil";
            // 
            // AgregarPokeButton
            // 
            this.AgregarPokeButton.BackColor = System.Drawing.Color.DarkBlue;
            this.AgregarPokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarPokeButton.Location = new System.Drawing.Point(1081, 248);
            this.AgregarPokeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarPokeButton.Name = "AgregarPokeButton";
            this.AgregarPokeButton.Size = new System.Drawing.Size(115, 37);
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
            this.label6.Location = new System.Drawing.Point(3, 229);
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
            this.label7.Location = new System.Drawing.Point(131, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Genero: ";
            // 
            // NombreJugadorTextBox
            // 
            this.NombreJugadorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreJugadorTextBox.Location = new System.Drawing.Point(333, 231);
            this.NombreJugadorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreJugadorTextBox.Name = "NombreJugadorTextBox";
            this.NombreJugadorTextBox.Size = new System.Drawing.Size(228, 26);
            this.NombreJugadorTextBox.TabIndex = 11;
            this.NombreJugadorTextBox.TextChanged += new System.EventHandler(this.NombreJugadorTextBox_TextChanged);
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Location = new System.Drawing.Point(333, 327);
            this.GeneroComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(228, 28);
            this.GeneroComboBox.TabIndex = 12;
            this.GeneroComboBox.SelectedIndexChanged += new System.EventHandler(this.GeneroComboBox_SelectedIndexChanged);
            // 
            // AgregarUsuarioButton
            // 
            this.AgregarUsuarioButton.BackColor = System.Drawing.Color.DarkBlue;
            this.AgregarUsuarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuarioButton.Location = new System.Drawing.Point(448, 378);
            this.AgregarUsuarioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarUsuarioButton.Name = "AgregarUsuarioButton";
            this.AgregarUsuarioButton.Size = new System.Drawing.Size(115, 37);
            this.AgregarUsuarioButton.TabIndex = 13;
            this.AgregarUsuarioButton.Text = "Agregar";
            this.AgregarUsuarioButton.UseVisualStyleBackColor = false;
            this.AgregarUsuarioButton.Click += new System.EventHandler(this.AgregarUsuarioButton_Click);
            // 
            // JugadoresDataGrid
            // 
            this.JugadoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JugadoresDataGrid.Location = new System.Drawing.Point(152, 492);
            this.JugadoresDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JugadoresDataGrid.Name = "JugadoresDataGrid";
            this.JugadoresDataGrid.RowHeadersWidth = 51;
            this.JugadoresDataGrid.RowTemplate.Height = 24;
            this.JugadoresDataGrid.Size = new System.Drawing.Size(173, 190);
            this.JugadoresDataGrid.TabIndex = 14;
            this.JugadoresDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Elephant", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(121, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Selecciona tu jugador";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.BackColor = System.Drawing.Color.White;
            this.PokemonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PokemonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PokemonPictureBox.Image")));
            this.PokemonPictureBox.Location = new System.Drawing.Point(861, 313);
            this.PokemonPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(292, 250);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokemonPictureBox.TabIndex = 3;
            this.PokemonPictureBox.TabStop = false;
            this.PokemonPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PokeDataGridView
            // 
            this.PokeDataGridView.AllowUserToAddRows = false;
            this.PokeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PokeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PokeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokeDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PokeDataGridView.Location = new System.Drawing.Point(808, 54);
            this.PokeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokeDataGridView.Name = "PokeDataGridView";
            this.PokeDataGridView.RowHeadersWidth = 51;
            this.PokeDataGridView.RowTemplate.Height = 24;
            this.PokeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PokeDataGridView.Size = new System.Drawing.Size(388, 190);
            this.PokeDataGridView.TabIndex = 16;
            this.PokeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PokeDataGridView_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 278);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(141, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.Red;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(315, 378);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(115, 37);
            this.EliminarButton.TabIndex = 19;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // IniciarBatallaButton1
            // 
            this.IniciarBatallaButton1.BackColor = System.Drawing.Color.Black;
            this.IniciarBatallaButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarBatallaButton1.Location = new System.Drawing.Point(616, 626);
            this.IniciarBatallaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IniciarBatallaButton1.Name = "IniciarBatallaButton1";
            this.IniciarBatallaButton1.Size = new System.Drawing.Size(153, 56);
            this.IniciarBatallaButton1.TabIndex = 20;
            this.IniciarBatallaButton1.Text = "Iniciar Batalla";
            this.IniciarBatallaButton1.UseVisualStyleBackColor = false;
            this.IniciarBatallaButton1.Click += new System.EventHandler(this.IniciarBatallaButton1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 718);
            this.Controls.Add(this.IniciarBatallaButton1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PokeDataGridView);
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
            this.Controls.Add(this.NombrePokemonLabel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombrePokemonLabel;
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
        private System.Windows.Forms.DataGridView PokeDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button IniciarBatallaButton1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPokemon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            GeneroComboBox.Items.Add("Masculino");
            GeneroComboBox.Items.Add("Femenino");
            GeneroComboBox.Items.Add("Otro");

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);//que aparezca el form en el centro de la pantalla

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPokeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Batalla nuevoFormulario = new Batalla();
            nuevoFormulario.Show();
        }
    }
    }



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
    public partial class HallOfFame : Form
    {

        public HallOfFame()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;//posicionar de forma manual la posicion del form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HallOfFame_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);//que aparezca el form en el centro de la pantalla

        }

        private void FinalizarButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}

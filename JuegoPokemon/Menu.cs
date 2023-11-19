using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPokemon
{
    public partial class Menu : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private SqlDataAdapter adaptador;
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
           

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);//que aparezca el form en el centro de la pantalla
            CargarDatosPokemon();
        }


        private void CargarDatosPokemon()
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    string consulta = "SELECT PKL_Id_Poke, PKL_Name, PKL_Life FROM PokeList";
                    adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tablaPokemones = new DataTable();
                    adaptador.Fill(tablaPokemones);

                    dataGridView1.AutoGenerateColumns = true; // Puedes establecer esto en false y definir manualmente las columnas si lo prefieres.
                    dataGridView1.DataSource = tablaPokemones;

                    // Ajusta el ancho de las columnas automáticamente
               
                     dataGridView1.Columns["PKL_Name"].Width = 150;
                    dataGridView1.Columns["PKL_Life"].Width = 150;

                    // Opcional: Refresca el DataGridView
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de Pokémon: " + ex.Message);
                }
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //Jugador
        private void NombreJugadorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarUsuarioButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("INSERT INTO Trainer (T_Name, T_Sex) VALUES (@T_Name, @T_Sex); SELECT SCOPE_IDENTITY();", conexion);
                    comando.Parameters.AddWithValue("@T_Name", NombreJugadorTextBox.Text);
                    comando.Parameters.AddWithValue("@T_Sex", GeneroComboBox.SelectedItem.ToString());

                    int idJugador = Convert.ToInt32(comando.ExecuteScalar());

                    MessageBox.Show("Jugador agregado con ID: " + idJugador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar jugador: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       


        //Pokemones
        private void PokemonesataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarPokeButton_Click(object sender, EventArgs e)
        {

           
        }

       

        private void NombrePokemonLabel_Click(object sender, EventArgs e)
        {

        }

        private void TipoLabel_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
    }



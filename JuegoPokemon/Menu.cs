using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace JuegoPokemon
{
    public partial class Menu : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private SqlDataAdapter adaptador;
        private List<EquipoPokemon> equipos = new List<EquipoPokemon>();

        private SoundPlayer soundPlayer;
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            PokeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CargarDatosPokemon();

            string rutaSonido = "C:\\Users\\josed\\Desktop\\3er Cautri 2023\\PROGRA 4\\JuegoPokemon\\CancionInicio\\Pokemon-Instrumental.wav"; //Igaual que con las imagenes, pongan la ruta solo que aqui tambien agregan el archivo"Pokemon-Instrumental.wav"
            soundPlayer = new SoundPlayer(rutaSonido);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            PokeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // PokeDataGridView.CellContentClick -= PokeDataGridView_CellContentClick;

            // Asociar el nuevo evento
            PokeDataGridView.SelectionChanged += PokeDataGridView_SelectionChanged;

            // Suscribir eventos para parar musica cuando se cierre el form
            this.Load += Form1_Load;
            this.FormClosed += Form1_FormClosed;

            GeneroComboBox.Items.Add("Masculino");
            GeneroComboBox.Items.Add("Femenino");

            comboBox1.Items.Add("Activo");
            comboBox1.Items.Add("Inactivo");

            // Cargar datos
            CargarDatosPokemon();
            CargarDatosJugadores();

            soundPlayer.PlayLooping();//Reproducir cancion en bucle

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Para la musica cuando se cierre el form
            soundPlayer.Stop();
        }




        private void CargarDatosPokemon()
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    string consulta = "SELECT PKL_Name, PKL_Life FROM PokeList";
                    adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tablaPokemones = new DataTable();
                    adaptador.Fill(tablaPokemones);

                    PokeDataGridView.DataSource = tablaPokemones;
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
            SqlConnection conexion = null;

            try
            {
                ConexionBD conexionBD = new ConexionBD();
                conexion = conexionBD.ObtenerConexion();

                SqlCommand comando = new SqlCommand("INSERT INTO Trainer (T_Name, T_Sex, T_Status) VALUES (@T_Name, @T_Sex, @T_Status); SELECT SCOPE_IDENTITY();", conexion);
                comando.Parameters.AddWithValue("@T_Name", NombreJugadorTextBox.Text);

                string generoSeleccionado = GeneroComboBox.SelectedItem.ToString();

                if (generoSeleccionado == "Masculino")
                {
                    generoSeleccionado = "M";
                }
                else if (generoSeleccionado == "Femenino")
                {
                    generoSeleccionado = "F";
                }
                else
                {
                    MessageBox.Show("Digite una opcion disponible");
                }

                GeneroComboBox.SelectedItem.ToString();

                comando.Parameters.AddWithValue("@T_Sex", generoSeleccionado);

                // Asignar el valor de T_Status basado en la selección del ComboBox
                comando.Parameters.AddWithValue("@T_Status", comboBox1.SelectedItem.ToString() == "Activo" ? 1 : 0);

                conexion.Open();
                int idJugador = Convert.ToInt32(comando.ExecuteScalar());

                MessageBox.Show("Jugador agregado con ID: " + idJugador);

                // Actualizar el DataGridView
                CargarDatosJugadores();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar jugador: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally
                if (conexion != null)
                {
                    ConexionBD conexionBD = new ConexionBD();
                    conexionBD.CerrarConexion(conexion);
                }
            }
        }






        private void CargarDatosJugadores()
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    string consulta = "SELECT T_Name FROM Trainer";
                    adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tablaJugadores = new DataTable();
                    adaptador.Fill(tablaJugadores);

                    JugadoresDataGrid.DataSource = tablaJugadores;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de jugadores: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Pokemones
        private void PokemonesataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosPokemon();
        }



        private void AgregarPokeButton_Click(object sender, EventArgs eventArgs)
        {
            // Verificar si se ha seleccionado un jugador
            if (JugadoresDataGrid.SelectedRows.Count > 0)
            {
                string nombreJugador = JugadoresDataGrid.SelectedRows[0].Cells["T_Name"].Value.ToString();

                // Obtener el equipo del jugador actual o crear uno nuevo si no existe
                EquipoPokemon equipo = equipos.FirstOrDefault(e => e.NombreJugador == nombreJugador);
                if (equipo == null)
                {
                    equipo = new EquipoPokemon(nombreJugador);
                    equipos.Add(equipo);
                }

                // Verificar el límite de 10 Pokémon
                if (equipo.LimiteAlcanzado())
                {
                    MessageBox.Show("El límite de 6 Pokémon por jugador ha sido alcanzado.");
                    return;
                }

                // Agregar el Pokémon al equipo
                equipo.PokemonSeleccionados.Add(NombrePokemonLabel.Text);

                int numeroPokemonAgregado = equipo.PokemonSeleccionados.Count;
                MessageBox.Show($"{NombrePokemonLabel.Text} ha sido   asignado al equipo de {nombreJugador}. Número: {numeroPokemonAgregado}");
            }
            else
            {
                MessageBox.Show("Seleccione un jugador para asignarle un Pokémon.");
            }

        }

        private void IniciarBatallaButton1_Click(object sender, EventArgs e)
        {
            if (equipos != null && equipos.Count > 0)
            {
                this.Hide();

                Batalla nuevoFormulario = new Batalla(equipos);
                nuevoFormulario.Show();
            }
            else
            {
                MessageBox.Show("No hay suficientes equipos para iniciar la batalla.");
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }




        private void PokeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) //Cambio el metododo al de abajo "SelectionChanged"
        {


        }


        private void PokeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (PokeDataGridView.SelectedRows.Count > 0)
            {
                // Sacar el nombre del Pokémon seleccionado
                string nombrePokemon = PokeDataGridView.SelectedRows[0].Cells["PKL_Name"].Value.ToString();
                NombrePokemonLabel.Text = nombrePokemon;

                string rutaImagenLocal = Path.Combine(Application.StartupPath, "C:\\Users\\josed\\Desktop\\3er Cautri 2023\\PROGRA 4\\JuegoPokemon\\Pokemon_img", nombrePokemon + ".png");//ruta

                CargarImagenPokemon(rutaImagenLocal);
            }
        }


        private void CargarImagenPokemon(string rutaImagen)//Tener la imagen de formma local
        {

            if (File.Exists(rutaImagen))
            {
                try
                {

                    PokemonPictureBox.Image = Image.FromFile(rutaImagen);//Mostrarla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen del Pokémon: " + ex.Message);
                }
            }
            else
            {

                PokemonPictureBox.Image = null;
            }
        }






        private void EliminarButton_Click(object sender, EventArgs e)
        {

            if (JugadoresDataGrid.SelectedRows.Count > 0)
            {
                string nombreJugador = JugadoresDataGrid.SelectedRows[0].Cells["T_Name"].Value.ToString();

                if (!string.IsNullOrEmpty(nombreJugador))
                {
                    EliminarJugador(nombreJugador);
                    CargarDatosJugadores();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un jugador para eliminar.");
            }
        }


        private void EliminarJugador(string nombreJugador)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    string consulta = "DELETE FROM Trainer WHERE T_Name = @Nombre";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombreJugador);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Jugador eliminado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el jugador con el nombre proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar jugador: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}



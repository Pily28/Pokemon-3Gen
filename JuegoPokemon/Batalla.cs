using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Media;


namespace JuegoPokemon
{
    public partial class Batalla : Form
    {
        private Random random = new Random();
        private List<string> imagenes = new List<string>();

        private List<EquipoPokemon> equipos;
        // Corregido aquí

        private SoundPlayer soundPlayer;

        public Batalla(List<EquipoPokemon> equipos)
        {
            InitializeComponent();
            this.equipos = equipos;

            string rutaCarpeta = @"C:\Users\josed\Desktop\3er Cautri 2023\PROGRA 4\JuegoPokemon\img";
            imagenes.AddRange(Directory.GetFiles(rutaCarpeta, "*.jpg"));
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.StartPosition = FormStartPosition.Manual;

            string rutaSonido = "C:\\Users\\josed\\Desktop\\3er Cautri 2023\\PROGRA 4\\JuegoPokemon\\CancionInicio\\pokemon-batalla.wav";
            soundPlayer = new SoundPlayer(rutaSonido);
        }

        private void Batalla_Load(object sender, EventArgs e)
        { // Asegúrate de tener al menos un equipo en la lista antes de intentar acceder al primero
          // Asegúrate de tener al menos un equipo en la lista antes de intentar acceder al primero
            if (equipos != null && equipos.Count > 0)
            {
                EquipoPokemon jugador1 = equipos[0];

                // Verificar si hay al menos dos equipos antes de intentar acceder al segundo
                if (equipos.Count > 1)
                {
                    EquipoPokemon jugador2 = equipos[1];
                    ActualizarInterfazJugador(jugador1, jugador2);
                }
                else
                {
                    // Manejar el caso en el que no hay suficientes equipos
                    MessageBox.Show("No hay suficientes equipos para iniciar la batalla.");
                    // Puedes cerrar el formulario o tomar alguna otra acción según sea necesario
                    this.Close();
                }
            }

        
    

            MostrarImagenAleatoria();
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);//que aparezca el form en el centro de la pantalla



            int borderRadius = 15; // Grado de curvatura
            System.Drawing.Drawing2D.GraphicsPath roundedPath = BorderRadius(panel1.ClientRectangle, borderRadius);
            Region roundedRegion = new Region(roundedPath);
            panel1.Region = roundedRegion;

            System.Drawing.Drawing2D.GraphicsPath roundedPathPanel2 = BorderRadius(panel2.ClientRectangle, borderRadius);
            Region roundedRegionPanel2 = new Region(roundedPathPanel2);
            panel2.Region = roundedRegionPanel2;

            soundPlayer.PlayLooping();//Reproducir cancion en bucle

            // Suscribir eventos para parar musica cuando se cierre el form
            this.Load += Batalla_Load;
            this.FormClosed += Batalla_FormClosed;

        }

        private void ActualizarInterfazJugador(EquipoPokemon jugador1, EquipoPokemon jugador2) //recibe a los jugadores para actualizar la interfaz para actualizar el form con sus datos
        {
            int vida = 100;
            
            if (jugador1.PokemonSeleccionados.Count > 0) //Ver si el jugador 1 tiene por lo menos 1 Pokemon
            {
                NombreJugador1Label.Text = "Jugador: "+jugador1.NombreJugador;

                // Acceder al primer Pokémon en el equipo del jugador 1
                string primerPokemonJugador1 = jugador1.PokemonSeleccionados[0];
                NombrePokemon1Label.Text = "Pokemon: "+primerPokemonJugador1;

                // Obtener la ruta de la imagen del Pokémon
                string rutaImagenJugador1 = Path.Combine("C:\\Users\\josed\\Desktop\\3er Cautri 2023\\PROGRA 4\\JuegoPokemon\\Pokemon_img", $"{primerPokemonJugador1}.png");

                // Mostrar la imagen del Pokémon si existe
                if (File.Exists(rutaImagenJugador1))
                {
                    Pokemon1PictureBox.Image = Image.FromFile(rutaImagenJugador1);
                }
                else
                {
                    Pokemon1PictureBox.Image = null;
                }

                //Hacer las operaciones de bajar "vida" con los ataques 
                string VidaToString = vida.ToString();//Cambiar la vida a String

                VidaPokemon1Label.Text = "Vida: 100/"+VidaToString;// Darle vida de 100 al Pokemon y mosatrar la que tiene con los ataques de la partida
                

            }
            else
            {
                // Manejar el caso en el que no hay Pokémon en el equipo del jugador 1
                MessageBox.Show("El equipo del jugador 1 no tiene Pokémon.");
                this.Close();//Y cierra el formulario 
                return;
            }

           
            if (jugador2.PokemonSeleccionados.Count > 0)//Lo mismo de arriba pero con el jugador 2
            {

                NombreJugador2Label.Text = "Jugador: "+jugador2.NombreJugador;
                
                string primerPokemonJugador2 = jugador2.PokemonSeleccionados[0];
                NombrePokemon2Label.Text = "Pokemon: "+primerPokemonJugador2;

                string rutaImagenJugador2 = Path.Combine("C:\\Users\\josed\\Desktop\\3er Cautri 2023\\PROGRA 4\\JuegoPokemon\\Pokemon_img", $"{primerPokemonJugador2}.png");

              
                if (File.Exists(rutaImagenJugador2))
                {
                    Pokemon2PictureBox.Image = Image.FromFile(rutaImagenJugador2);
                }
                else
                {
                    Pokemon2PictureBox.Image = null;
                }

                //Hacer las operaciones de bajar "vida" con los ataques 
                string VidaToString = vida.ToString();//Cambiar la vida a String

                VidaPokemon2Label.Text = "Vida: 100/"+VidaToString;// Darle vida de 100 al Pokemon y mosatrar la que tiene con los ataques de la partida




            }
            else
            {  
                MessageBox.Show("El equipo del jugador 2 no tiene Pokémon.");
                this.Close();
            }
        }




        private void Batalla_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Para la musica cuando se cierre el form
            soundPlayer.Stop();
        }// Detener musica

        private System.Drawing.Drawing2D.GraphicsPath BorderRadius(Rectangle rectangle, int borderRadius)//Radius
        {
            int diameter = borderRadius * 2;
            System.Drawing.Drawing2D.GraphicsPath roundedRect = new System.Drawing.Drawing2D.GraphicsPath();
            roundedRect.AddArc(rectangle.X, rectangle.Y, diameter, diameter, 180, 90); // Esquina superior izquierda
            roundedRect.AddArc(rectangle.Right - diameter, rectangle.Y, diameter, diameter, 270, 90); // Esquina superior derecha
            roundedRect.AddArc(rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter, 0, 90); // Esquina inferior derecha
            roundedRect.AddArc(rectangle.X, rectangle.Bottom - diameter, diameter, diameter, 90, 90); // Esquina inferior izquierda
            roundedRect.CloseFigure();
            return roundedRect;
        }


        private void MostrarImagenAleatoria()
        {
            if (imagenes.Count > 0)
            {
                int indiceAleatorio = random.Next(imagenes.Count);
                string rutaImagen = imagenes[indiceAleatorio];
                MostrarImagen(rutaImagen);
            }
        }
        private void MostrarImagen(string rutaImagen)
        {
            Image imagen = Image.FromFile(rutaImagen);

            
            pictureBox1.Image = RedimensionarImagen(imagen, this.ClientSize);


            string nombreImagen = Path.GetFileNameWithoutExtension(rutaImagen);
            label1.Text = "Arena: " + nombreImagen;

            //Elementos al combo box, jugador 1
            Jugador1ComboBox.Items.Add("Ataque 1");
            Jugador1ComboBox.Items.Add("Ataque 2");
            Jugador1ComboBox.Items.Add("Ataque 3");

            //Elementos al combo box, jugador 2
            Jugador2ComboBox.Items.Add("Ataque 1");
            Jugador2ComboBox.Items.Add("Ataque 2");
            Jugador2ComboBox.Items.Add("Ataque 3");

        }
        private Image RedimensionarImagen(Image imagen, Size newSize)
        {
            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.DrawImage(imagen, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            SemiFinal nuevoFormulario = new SemiFinal();
            nuevoFormulario.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        //Jugador 2
        private void NombreJugador2Label_Click(object sender, EventArgs e)
        {

        }

        private void NombrePokemon2Label_Click(object sender, EventArgs e)
        {

        }

        private void VidaPokemon2Label_Click(object sender, EventArgs e)
        {

        }

        private void Pokemon2PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

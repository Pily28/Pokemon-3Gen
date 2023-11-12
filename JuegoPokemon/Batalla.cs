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

namespace JuegoPokemon
{
    public partial class Batalla : Form
    {
        private Random random = new Random();
        private List<string> imagenes = new List<string>();
        public Batalla()
        {
            InitializeComponent();

            string rutaCarpeta = @"C:\Users\josed\Desktop\3er Cautri 2023\PROGRA 4\JuegoPokemon\img"; 
            imagenes.AddRange(Directory.GetFiles(rutaCarpeta, "*.jpg"));
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.StartPosition = FormStartPosition.Manual;//posicionar de forma manual la posicion del form
        }

        private void Batalla_Load(object sender, EventArgs e)
        {
            MostrarImagenAleatoria();
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);//que aparezca el form en el centro de la pantalla

           

            int borderRadius = 15; // Grado de curvatura
            System.Drawing.Drawing2D.GraphicsPath roundedPath = GetRoundedRectangle(panel1.ClientRectangle, borderRadius);
            Region roundedRegion = new Region(roundedPath);
            panel1.Region = roundedRegion;

            System.Drawing.Drawing2D.GraphicsPath roundedPathPanel2 = GetRoundedRectangle(panel2.ClientRectangle, borderRadius);
            Region roundedRegionPanel2 = new Region(roundedPathPanel2);
            panel2.Region = roundedRegionPanel2;
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRectangle(Rectangle rectangle, int borderRadius)
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
    }
}

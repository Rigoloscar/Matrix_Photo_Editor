using Librería_de_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Formulario_1
{
    public partial class Presentación : Form
    {
        string directorio;
        int contador;
        string archivo;
        FileInfo[] archivos;
        Imagen foto = new Imagen();
        PictureBox imagen = new PictureBox();

        string ruta_play = "play4.png";
        string ruta_pause = "pause4.png";

        public Presentación()
        {
            InitializeComponent();
        }

        private void Presentación_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            button1.Image = System.Drawing.Bitmap.FromFile(ruta_pause);
            timer1.Interval = 4000;
            textBox1.Text = ("4 (default)");
            button2.Enabled = false;
            textBox1.Enabled = false;
            label2.Enabled = false;
        }

        public void Start(string directorio)
        {
            this.directorio = directorio;
            timer1.Start();

            DirectoryInfo d = new DirectoryInfo(this.directorio);
            this.archivos = d.GetFiles();
            this.contador = this.archivos.Length -1;
            Presentacion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.contador >= 0)
            {
                Presentacion();
                this.contador--;
            }
            else
            {
                this.Close();
            }
        }

        private void Presentacion()
        {
            this.archivo = this.archivos[this.contador].FullName;
            foto.GetPanel(panel1.Height, panel1.Width);
            int cargar = foto.Cargar(this.archivo);
            if (cargar == 0)
            {
                label2.Enabled = false;
                panel1.Controls.Remove(label2);
                Bitmap voltear = new Bitmap(foto.CrearBitmap());
                imagen.Location = new Point(0, 0);
                imagen.Width = foto.GetDimensiones()[1];
                imagen.Height = foto.GetDimensiones()[0];
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                imagen.Image = voltear as System.Drawing.Image;
                panel1.Controls.Add(imagen);
            }
            else
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(label2);
                label2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                button1.Image = System.Drawing.Bitmap.FromFile(ruta_pause);
                timer1.Enabled = true;
                button2.Enabled = false;
                textBox1.Enabled = false;

                if (textBox1.Text != null)
                {
                    try
                    {
                        timer1.Interval = 1000*Convert.ToInt32(textBox1.Text);
                    }
                    catch (FormatException)
                    {
                        return;
                    }
                }
            }
            else if (timer1.Enabled == true)
            {
                button1.Image = System.Drawing.Bitmap.FromFile(ruta_play);
                timer1.Enabled = false;
                button2.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.contador = this.archivos.Length - 1;
            button1.Image = System.Drawing.Bitmap.FromFile(ruta_pause);
            timer1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = false;

            if (textBox1.Text != null)
            {
                try
                {
                    timer1.Interval = 1000*Convert.ToInt32(textBox1.Text);
                }
                catch (FormatException)
                {
                    return;
                }
            }
        }
    }
}

using Librería_de_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Formulario_1
{
    public partial class Selecionar : Form
    {
        Point[] selec = new Point[2];
        bool recDown = false;
        bool recUp = false;
        bool proc = false;

        Imagen foto = new Imagen();
        PictureBox imagen = new PictureBox();
        Bitmap picture;

        public Selecionar()
        {
            InitializeComponent();
        }

        private void Recortar_Load(object sender, EventArgs e)
        {
            this.recDown = false;
            this.recUp = false;
            this.proc = false;

            this.ClientSize = new Size(Convert.ToInt32(foto.GetDatos()[1]), Convert.ToInt32(foto.GetDatos()[0]));
            pictureBox1.Size = new Size(Convert.ToInt32(foto.GetDatos()[1]), Convert.ToInt32(foto.GetDatos()[0]));

            this.picture = new Bitmap(foto.CrearBitmap());
            imagen.Location = new Point(0, 0);
            imagen.Width = Convert.ToInt32(foto.GetDatos()[1]);
            imagen.Height = Convert.ToInt32(foto.GetDatos()[0]);
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.Image = this.picture as Image;
            pictureBox1.BackgroundImage = this.picture;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if ((this.recDown == true) && (recUp == false))
            {
                System.Drawing.Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Red);
                graphics.DrawRectangle(myPen, GetRectangle(selec));
                myPen.Dispose();
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if ((this.recDown == true) && (recUp == false))
            {
                this.selec[1] = new Point(e.X, e.Y);
                pictureBox1.Refresh();
            }
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (this.recUp == false)
            {
                this.selec[0] = new Point(e.X, e.Y);
                this.recDown = true;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (this.recDown == true)
            {
                if ((selec[0].X >= selec[1].X) || (selec[0].Y >= selec[1].Y))
                {
                    MessageBox.Show("Uso inadecuado de la herramienta: debe desplazar el cursor de arriba a abajo, y de izquierda a derecha");
                    this.proc = false;
                    this.Close();
                }
                else
                {
                    this.recUp = true;
                    this.proc = true;
                    this.recDown = false;
                    this.Close();
                }
            }
        }

        private Rectangle GetRectangle(Point[] datos)
        {
            Rectangle rect = new Rectangle();
            rect.X = Math.Min(this.selec[0].X, this.selec[1].X);
            rect.Y = Math.Min(this.selec[0].Y, this.selec[1].Y);
            rect.Width = Math.Abs(this.selec[0].X - this.selec[1].X);
            rect.Height = Math.Abs(this.selec[0].Y - this.selec[1].Y);
            return rect;
        }

        public void GetImagen(Imagen imagen)
        {
            this.foto = imagen;
        }

        public bool StatusHerramienta()
        {
            return proc;
        }

        public Point[] GivePuntos()
        {
            return this.selec;
        }

    }
}

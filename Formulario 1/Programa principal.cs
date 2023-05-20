using Formulario_1;
using Librería_de_clases;
using Microsoft.Win32;
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


namespace Formularios
{
    public partial class Programa_principal : Form
    {
       // PROYECTO DE PROGRAMACIÓN
       // Versión: 2.1

        Imagen foto = new Imagen();
        PictureBox imagen = new PictureBox();
        string archivo;   // nombre (y ruta) del archivo
        int cambios = 0; // variable que contabiliza los cambios. Si es 1 hay cambios por guardar. Si es 0 todos los cambios están guardados, o no hay.
        string usuario; // usuario que ha iniciado sesión
        int status; // tipo de ususario: admin o estándar
        Stack<Imagen> RegistrosDes = new Stack<Imagen>(); // Guarda las imágenes antes de ser editadas en una pila para la opción deshacer
        Stack<Imagen> RegistrosRe = new Stack<Imagen>(); // Guarda las imágenes editadas en una pila para la opción rehacer
        // Button1 es el botón usado para deshacer y button2 es el usado para rehacer

        public Programa_principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Autentificación f0 = new Autentificación();
            f0.ShowDialog();

            button1.Enabled = false;
            button2.Enabled = false;
            this.usuario = f0.GiveDatos()[0];
            this.status = Convert.ToInt32(f0.GiveDatos()[1]);

            switch (status) // si el status es 1 el usuario es administrador. Si es 0, es usuario normal
            {
                case 1: userLabel.Text = ("Admin: " + this.usuario); 
                        administraciónToolStripMenuItem.Visible = true;
                    break;
                case 0: userLabel.Text = ("Usuario: " + this.usuario);
                        administraciónToolStripMenuItem.Visible = false; 
                    break;
            }
            
        }

        // Cargar la imagen
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.archivo = openFileDialog1.FileName;
                int cargar = foto.Cargar(this.archivo);
                foto.GetPanel(panel1.Width, panel1.Height);

                if (cargar == 0)
                {
                    MessageBox.Show("Imagen cargada con éxito");
                    DibujarBitmap();

                }
                else
                {
                    MessageBox.Show("Error de carga");
                }
            }
        }

        // Dibuja el bitmap
        private void DibujarBitmap()
        {
            Bitmap bmp = new Bitmap(foto.CrearBitmap());
            imagen.Location = new Point(0, 0);
            imagen.Width = foto.GetDimensiones()[1];
            imagen.Height = foto.GetDimensiones()[0];
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.Image = (Image)bmp;
            panel1.Controls.Add(imagen);

            if (this.RegistrosDes.Count > 0) // Activa los botones de deshacer y rehacer si hay una o más imágenes en sus respectivas pilas
            {
                button1.Enabled = true;
            } 

            if (this.RegistrosRe.Count > 0)
            {
                button2.Enabled = true;
            } 
        }

        // Mostrar datos
        private void mostrarNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                Mostrar_datos f2 = new Mostrar_datos();

                f2.SetID(foto.GetDatos()[2]);
                f2.SetAlto(foto.GetDatos()[0]);
                f2.SetAncho(foto.GetDatos()[1]);

                string nombre = Path.GetFileName(this.archivo);
                f2.SetName(nombre);

                f2.ShowDialog();
            }
        }

        // Mostrar créditos
        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Créditos f3 = new Créditos();
            f3.ShowDialog();
        }

        // Salvar
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                foto.Salvar(this.archivo);
                this.cambios = 0;
                MessageBox.Show("Imagen guardada con éxito");
            }
        }

        // Salvar como
        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.archivo = saveFileDialog1.FileName;
                    foto.Salvar(this.archivo);
                    this.cambios = 0;
                    MessageBox.Show("Imagen guardada con éxito");
                }
            }
        }

        // Salir
        private void Programa_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cambios == 1)
            {
                Salir f4 = new Salir();
                f4.ShowDialog();

                if (f4.Veredicto() == false) // Resultado de un form que se abre preguntando si quiere salir sin guardar
                {
                    e.Cancel = true;
                }
            }
        }

        // Modo presentación
        private void modoPresentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string directorio = folderBrowserDialog1.SelectedPath;

            if (string.IsNullOrEmpty(directorio) == false) // Si el directorio es válido inicia la presentación
            {
                Presentación f7 = new Presentación();
                f7.Start(directorio);
                f7.ShowDialog();
            }
        }

        // Enmarcar
        private void enmarcarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {

                Enmarcar f6 = new Enmarcar();
                f6.ShowDialog();
                byte[] color = f6.GetColor(); // Devuelve las componentes RGB en un vector de bytes de 3 componentes para el marco
                int grosor = f6.GetMarco();

                if (color != null && grosor > 0)
                {
                    this.RegistrosDes.Push(foto.Getcopia()); // Mete la imágen en la pila deshacer antes de aplicar la edición
                    foto.Enmarcar(grosor, color[0], color[1], color[2]);
                    DibujarBitmap();

                    this.cambios = 1;
                }

            }
        }

        // Intensificar un color
        private void intensificarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                this.RegistrosDes.Push(foto.Getcopia());
                Intensidad f8 = new Intensidad();
                f8.ShowDialog();
                byte[] color = f8.Intensito();
                foto.CambiarIntensidad(color[0], color[1], color[2]);
                DibujarBitmap();

                this.cambios = 1;
            }
        }


        // Brillo
        private void brilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                this.RegistrosDes.Push(foto.Getcopia());
                Brillo f9 = new Brillo();
                f9.ShowDialog();
                int valor = f9.GetValue(); // Valor de brillo que se aumenta o disminuye (admite negativos)
                foto.Brillo(valor);
                DibujarBitmap();
                this.cambios = 1;
            }
        }

        // Negativo
        private void negativoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                this.RegistrosDes.Push(foto.Getcopia());
                foto.Negativo();
                DibujarBitmap();
                this.cambios = 1;
            }
        }

        // Escala de grises
        private void escalaDeGrisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                this.RegistrosDes.Push(foto.Getcopia());
                foto.Grises();
                DibujarBitmap();
                this.cambios = 1;
            }
        }

        // Voltear
        private void voltearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                Voltear f5 = new Voltear();
                f5.ShowDialog();

                switch (f5.GetEje())
                {
                    case 'x': // Voltea sobre el eje horizontal
                        this.RegistrosDes.Push(foto.Getcopia());
                        foto.VoltearX();
                        break;
                    case 'y': // Voltea sobre el eje vertical
                        this.RegistrosDes.Push(foto.Getcopia());
                        foto.VoltearY();
                        break;
                }

                DibujarBitmap();
                this.cambios = 1;
            }
        }

        // Recortar
        private void recortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                Selecionar f6 = new Selecionar();
                f6.GetImagen(this.foto);
                f6.ShowDialog();

                if (f6.StatusHerramienta() == true) // StatusHerramienta te dice si el usuario ha recortado correctamente (de arriba-izquierda a abajo-derecha)
                {
                    this.RegistrosDes.Push(foto.Getcopia());
                    foto.Recortar(f6.GivePuntos()[0], f6.GivePuntos()[1]); // Recorta en función de dos puntos que se dan en un vector
                    DibujarBitmap();
                    this.cambios = 1;
                }
            }
        }

        // Girar
        private void girarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                Girar f8 = new Girar();
                f8.ShowDialog();

                switch (f8.GetEje())
                {
                    case 'D': // Gira hacia la derecha
                        this.RegistrosDes.Push(foto.Getcopia());
                        foto.GirarDerecha();
                        break;
                    case 'I': // Gira hacia la izquierda
                        this.RegistrosDes.Push(foto.Getcopia());
                        foto.GirarIzquierda();
                        break;
                }

                DibujarBitmap();
                this.cambios = 1;
            }
        }

        //Sepia
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                this.RegistrosDes.Push(foto.Getcopia());
                foto.Sepia();
                DibujarBitmap();
                this.cambios = 1;
            }
        }

        // Opciones de administrador
        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administración f9 = new Administración();
            f9.ShowDialog();
        }

        // Deshacer 
        private void button1_Click(object sender, EventArgs e)
        {
            this.RegistrosRe.Push(foto.Getcopia());
            foto = RegistrosDes.Pop();
            DibujarBitmap();

            if (this.RegistrosDes.Count == 0) // Inhabilita el botón de deshacer (button1) al llegar a 0 imágenes en la pila
            {
                button1.Enabled = false;
            }

            this.cambios = 1;
        }

        // Rehacer
        private void button2_Click(object sender, EventArgs e)
        {
            this.RegistrosDes.Push(foto.Getcopia());
            foto = RegistrosRe.Pop();
            DibujarBitmap();

            if (this.RegistrosRe.Count == 0) // Inhabilita el botón de rehacer (button2) al llegar a 0 imágenes en la pila
            {
                button2.Enabled = false;
            }

            this.cambios = 1;
        }

        // Ajustes de usuario
        private void ajustesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajustes f10 = new Ajustes();
            f10.GetDatos(this.usuario);
            f10.ShowDialog();
        }

        // Desenfocar
        private void desenfoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                MessageBox.Show("Ha de importar una imagen primero");
            }
            else
            {
                int grado;
                Selecionar f11 = new Selecionar();
                Desenfoque f12 = new Desenfoque();
                f11.GetImagen(this.foto);
                f11.ShowDialog();

                if (f11.StatusHerramienta() == true) // StatusHerramienta te dice si el usuario ha recortado correctamente (de arriba-izquierda a abajo-derecha)
                {
                    this.RegistrosDes.Push(foto.Getcopia());
                    f12.ShowDialog();
                    grado = f12.GetGrado();
                    foto.Desenfocar(grado, f11.GivePuntos()[0], f11.GivePuntos()[1]); // Recorta en función de dos puntos que se dan en un vector
                    DibujarBitmap();
                    this.cambios = 1;
                }
            }
        }

        // Cerrar sesión
        private void cerrarSessiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.usuario = null;
            this.status = 0;
            userLabel.Text = "Usuario: ";
            Autentificación f12 = new Autentificación();
            f12.ShowDialog();
            this.usuario = f12.GiveDatos()[0];
            this.status = Convert.ToInt32(f12.GiveDatos()[1]);

            switch (status)
            {
                case 1:
                    userLabel.Text = ("Admin: " + this.usuario);
                    administraciónToolStripMenuItem.Visible = true;
                    break;
                case 0:
                    userLabel.Text = ("Usuario: " + this.usuario);
                    administraciónToolStripMenuItem.Visible = false;
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Librería_de_clases
{
    public class Imagen
    {
        // Atributos
        string identificador;
        int alto;
        int ancho;
        int MaxValue;
        int PanelAncho;
        int PanelAlto;
        Pixel[,] datos;

        // Métodos
        public int Cargar(string nombre)
        {
            try
            {
                string[] extension = (Path.GetExtension(nombre)).Split('.');

                if (extension[extension.Length - 1] == "ppm") // Carga las PPM
                {
                    StreamReader F = new StreamReader(nombre);

                    int i = 0;
                    int j = 0;
                    string[] lectura;

                    string cadena = F.ReadLine();
                    this.identificador = cadena;
                    cadena = F.ReadLine();
                    lectura = cadena.Split(' ');
                    this.ancho = Convert.ToInt32(lectura[0]);
                    this.alto = Convert.ToInt32(lectura[1]);
                    cadena = F.ReadLine();
                    this.MaxValue = Convert.ToInt32(cadena);
                    cadena = F.ReadLine();

                    this.datos = new Pixel[this.alto, this.ancho];

                    while (cadena != null)
                    {
                        lectura = cadena.Split(' ');
                        j = 0;

                        for (j = 0; j < this.ancho; j++)
                        {
                            this.datos[i, j] = new Pixel();
                            this.datos[i, j].SetRed(Convert.ToByte(lectura[j * 3]));
                            this.datos[i, j].SetGreen(Convert.ToByte(lectura[(j * 3) + 1]));
                            this.datos[i, j].SetBlue(Convert.ToByte(lectura[(j * 3) + 2]));
                        }
                        i++;
                        cadena = F.ReadLine();

                    }
                    F.Close();
                    return 0;
                }
                else // Carga las demás
                {
                    Bitmap bmp = new Bitmap(nombre);

                    this.identificador = "P3";
                    this.ancho = bmp.Width;
                    this.alto = bmp.Height;
                    this.datos = new Pixel[this.alto, this.ancho];

                    for (int i = 0; i < this.alto; i++)
                    {
                        for (int j = 0; j < this.ancho; j++)
                        {
                            Color c = bmp.GetPixel(j, i);
                            Pixel p = new Pixel(c.R, c.G, c.B);
                            this.datos[i, j] = p;
                        }
                    }
                    bmp.Dispose();
                    return 0; 
                }
            }
            catch (FileNotFoundException)
            {
                return -1;
            }
            catch (FormatException)
            {
                return -1;
            }
            catch (ArgumentException)
            {
                return -1;
            }
            catch (IndexOutOfRangeException)
            {
                return -1;
            }
        }

        public void Salvar(string nombre)
        {
            string[] extension = (Path.GetExtension(nombre)).Split('.');

            if (extension[extension.Length - 1] == "ppm") // Guarda la imagen como ppm
            { 
                StreamWriter G = new StreamWriter(nombre);

                int i = 0;
                int j = 0;

                G.WriteLine(this.identificador);
                G.WriteLine(this.ancho + " " + this.alto);
                G.WriteLine(this.MaxValue);

                for (i = 0; i < this.alto; i++)
                {
                    for (j = 0; j < this.ancho; j++)
                    {
                        G.Write(datos[i, j].GetRed());
                        G.Write(" ");
                        G.Write(datos[i, j].GetGreen());
                        G.Write(" ");
                        G.Write(datos[i, j].GetBlue());
                        G.Write(" ");
                    }
                    G.WriteLine();
                }
                G.Close();
            }
            else  // Guarda la imagen en otro formato
            {
                Bitmap foto = new Bitmap (CrearBitmap());

                switch (extension[extension.Length - 1])    
                {
                    case "jpg": foto.Save(nombre, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case "png": foto.Save(nombre, System.Drawing.Imaging.ImageFormat.Png); break;
                    case "gif": foto.Save(nombre, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case "ico": foto.Save(nombre, System.Drawing.Imaging.ImageFormat.Icon); break;
                }
            }
        }

        public Pixel ConsultarPixel(int i, int j)
        {
            if (i < 0 || i >= this.alto || j < 0 || j >= this.ancho)
            {
                return null;
            }
            else
            {
                return datos[i, j];
            }
        }

        public string[] GetDatos()
        {
            string[] dim = new string[3];
            dim[0] = Convert.ToString(this.alto);
            dim[1] = Convert.ToString(this.ancho);
            dim[2] = this.identificador;
            return dim;
        }

        public int[] GetDimensiones() // Da las dimensiones de la imágen adaptadas a las del panel
        {
            int[] dim = new int[2];

            if (this.alto > this.PanelAlto)
            {
                dim[0] = this.PanelAlto;
                dim[1] = (this.ancho * this.PanelAlto) / this.alto;
                
            }
            else if (this.ancho > this.PanelAncho)
            {
                dim[1] = this.PanelAncho;
                dim[0] = (this.alto * this.PanelAncho) / this.ancho;
                
            }
            else if ((this.ancho > this.PanelAncho) && (this.alto > this.PanelAlto))
            {
                dim[0] = (this.alto * this.PanelAncho) / this.ancho;
                dim[1] = (this.ancho * this.PanelAlto) / this.alto;
            }
            else
            {
                dim[1] = this.ancho;
                dim[0] = this.alto;
            }
            return dim;
        }

        public Bitmap CrearBitmap()
        {
            Bitmap bmp = new Bitmap(this.ancho, this.alto);
            
            for (int i = 0; i < this.alto; i++)
{
                for (int j = 0; j < this.ancho; j++)
{
                    byte r = this.datos[i, j].GetRed();
                    byte g = this.datos[i, j].GetGreen();
                    byte b = this.datos[i, j].GetBlue();
  
                    Color c = Color.FromArgb(r, g, b);
                    bmp.SetPixel(j, i, c);
                }
            }
            return bmp;
        }

        public int ModificarPixel(int i, int j, byte R, byte G, byte B)
        {

            if (datos[i, j] != null)
            {
                this.datos[i, j].SetRed(R);

                this.datos[i, j].SetGreen(G);

                this.datos[i, j].SetBlue(B);
                return 0; 
            }
            return -1; 

        }

        public void Recortar(Point inicial, Point final) // Recorta la imagen dados dos puntos
        {
            int alto = Math.Abs(final.Y - inicial.Y);
            int ancho = Math.Abs(final.X - inicial.X);
            int k = 0;
            int l = 0;
            Pixel[,] recortada = new Pixel[alto, ancho];

            for (int i = inicial.Y; i < final.Y; i++)
            {
                for (int j = inicial.X; j < final.X; j++)
                {
                    recortada[k, l] = this.datos[i, j];
                    l++;
                }
                l = 0;
                k++;
            }

            this.ancho = ancho;
            this.alto = alto;
            this.datos = recortada;
        }

        public void Grises() // Escala de grises
        {
            byte resultat;
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    byte r = this.datos[i, j].GetRed();
                    byte g = this.datos[i, j].GetGreen();
                    byte b = this.datos[i, j].GetBlue();

                    resultat = Convert.ToByte((r + g + b) / 3);
                    
                    this.datos[i, j].SetRed(resultat);
                    this.datos[i, j].SetGreen(resultat);
                    this.datos[i, j].SetBlue(resultat);
                }
            }
        }
    
        public void VoltearX()  // Voltea sobre el eje Y
        {
            int i = this.alto-1;
            int j = 0;
            Pixel[,] copia = new Pixel[this.alto, this.ancho];

            for (int k = 0; k < this.alto; k++)
            {
                for (int l = 0; l < this.ancho; l++)
                {
                    copia[k, l] = this.datos[k, l]; 
                }
            }

            for (int k = 0; k < this.alto; k++)
            {
                for (int l = 0; l < this.ancho; l++)
                {
                    this.datos[k, l] = copia[i, j];
                    j++;
                }
                j = 0;
                i--;
            }

        }

        public void VoltearY()  // Voltea sobre el eje X
        {
            int i = 0;
            int j = this.ancho - 1;
            Pixel[,] copia = new Pixel[this.alto, this.ancho];

            for (int k = 0; k < this.alto; k++)
            {
                for (int l = 0; l < this.ancho; l++)
                {
                    copia[k, l] = this.datos[k, l];
                }

            }

            for (int k = 0; k < this.alto; k++)
            {
                for (int l = 0; l < this.ancho; l++)
                {

                    this.datos[k, l] = copia[i, j];
                    j--;
                }
                j = this.ancho - 1;
                i++;
            }

        }

        public void GirarIzquierda() // Gira la imagen a la izquierda
        {
            int x = this.ancho - 1;
            Pixel[,] girada = new Pixel[this.ancho, this.alto];
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    girada[j, i] = this.datos[i, x];
                    x--;
                }
                x = this.ancho - 1;
            }
            this.datos = girada;
            this.ancho = this.alto;
            this.alto = x + 1;
        }

        public void GirarDerecha() // Gira la imagen a la derecha
        {
            int y = this.alto - 1;
            int x = this.alto;
            Pixel[,] girada = new Pixel[this.ancho, this.alto];
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    girada[j, i] = this.datos[y, j];

                }
                y--;
            }
            this.datos = girada;
            this.alto = this.ancho;
            this.ancho = x;
        }

        public void Enmarcar(int grosor, byte R, byte G, byte B) // Enmarca la imagen
        {
            for (int i = 0; i < this.alto; i++)
            {
                if (i == grosor)
                {
                    i = this.alto - grosor;
                }
                for (int j = 0; j < this.ancho; j++)
                {
                    this.ModificarPixel(i, j, R, G, B);
                }
            }

            for (int j = 0; j < this.ancho; j++)
            {
                if (j == grosor)
                {
                    j = this.ancho - grosor;
                }
                for (int i = 0; i < this.alto; i++)
                {
                    this.ModificarPixel(i, j, R, G, B);
                }
            }
        }

        public void GetPanel(int w, int h)
        {
            this.PanelAlto = h;
            this.PanelAncho = w;
        }

        public void CambiarIntensidad(byte r, byte g, byte b) // Intensificar color
        {
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    byte r0 = this.datos[i, j].GetRed();
                    byte g0 = this.datos[i, j].GetGreen();
                    byte b0 = this.datos[i, j].GetBlue();


                    if (r0 + r > 255)
                    {
                        this.datos[i, j].SetRed(Convert.ToByte(255));
                    }
                    else
                    {
                        this.datos[i, j].SetRed(Convert.ToByte(r0 + r));
                    }

                    if (g0 + g > 255)
                    {
                        this.datos[i, j].SetGreen(Convert.ToByte(255));
                    }
                    else
                    {
                        this.datos[i, j].SetGreen(Convert.ToByte(g0 + g));
                    }

                    if (b0 + b > 255)
                    {
                        this.datos[i, j].SetBlue(Convert.ToByte(255));
                    }
                    else
                    {
                        this.datos[i, j].SetBlue(Convert.ToByte(b0 + b));
                    }
                }
            }
        }

        public void Negativo() // Función extra: te da el negativo de la imagen. 
        {
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    int r = 255 - this.datos[i, j].GetRed();
                    int g = 255 - this.datos[i, j].GetGreen();
                    int b = 255 - this.datos[i, j].GetBlue();

                    this.datos[i, j].SetRed(Convert.ToByte(r));
                    this.datos[i, j].SetGreen(Convert.ToByte(g));
                    this.datos[i, j].SetBlue(Convert.ToByte(b));
                }
            }
        }

        public void Brillo(int value) // Función extra: aumenta el brillo de la imagen
        {
            int r, g, b;
            
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    if ((this.datos[i, j].GetRed() + value) > 255)
                    {
                        r = 255;  
                    }
                    else if ((this.datos[i, j].GetRed() + value) < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = this.datos[i, j].GetRed() + value;
                    }

                    if ((this.datos[i, j].GetGreen() + value) > 255)
                    {
                        g = 255;
                    }
                    else if ((this.datos[i, j].GetGreen() + value) < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = this.datos[i, j].GetGreen() + value;
                    }

                    if ((this.datos[i, j].GetBlue() + value) > 255)
                    {
                        b = 255;
                    }
                    else if ((this.datos[i, j].GetBlue() + value) < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = this.datos[i, j].GetBlue() + value;
                    }

                    this.datos[i, j].SetRed(Convert.ToByte(r));
                    this.datos[i, j].SetGreen(Convert.ToByte(g));
                    this.datos[i, j].SetBlue(Convert.ToByte(b));
                }
            }
        }

        public void Sepia() // Función extra: aplica un filtro sepia
        {
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    int r = this.datos[i, j].GetRed();
                    int g = this.datos[i, j].GetGreen();
                    int b = this.datos[i, j].GetBlue();
                    int lum = ((r + g + b) / 3);

                    if (lum + 60 > 255)
                    {
                        this.datos[i, j].SetRed(Convert.ToByte(255));
                        this.datos[i, j].SetGreen(Convert.ToByte(212));
                        this.datos[i, j].SetBlue(Convert.ToByte(195));
                    }
                    else
                    {
                        this.datos[i, j].SetRed(Convert.ToByte(60 + lum));
                        this.datos[i, j].SetGreen(Convert.ToByte(17 + lum));
                        this.datos[i, j].SetBlue(Convert.ToByte(lum));
                    }
                }
            }
        }

        public Pixel[,] GetcopiaPix() // Copia la matriz de píxeles. Usada para la pila deshacer
        {
            Pixel[,] copia = new Pixel[this.alto, this.ancho];

            for (int k = 0; k < this.alto; k++)
            {
                for (int l = 0; l < this.ancho; l++)
                {
                    copia[k, l] = new Pixel(this.datos[k, l].GetRed(), this.datos[k, l].GetGreen(), this.datos[k, l].GetBlue());
                }

            }
            return copia;
        }

        public Imagen Getcopia() // Copia el resto de parámetros para devolver una imagen copia e insertarla en la pila
        {
            Imagen copia = new Imagen();
            copia.identificador = this.identificador;
            copia.alto = this.alto;
            copia.ancho = this.ancho;
            copia.MaxValue = this.MaxValue;
            copia.PanelAncho = this.PanelAncho;
            copia.PanelAlto = this.PanelAlto;
            copia.datos = this.GetcopiaPix();

            return copia;
        }

        public void Desenfocar(int grado, Point punto0, Point punto1) // Función extra: desenfoca
        {
            while (grado > 0)
            {
                for (int i = (punto0.Y +1); i < (punto1.Y -1); i++)
                {
                    for (int j = (punto0.X + 1); j < (punto1.X - 1); j++)
                    {
                        int r = this.datos[i - 1, j - 1].GetRed() + this.datos[i + 1, j + 1].GetRed();
                        int g = this.datos[i - 1, j - 1].GetGreen() + this.datos[i + 1, j + 1].GetGreen();
                        int b = this.datos[i - 1, j - 1].GetBlue() + this.datos[i + 1, j + 1].GetBlue();
                        this.datos[i, j].SetRed(Convert.ToByte(r / 2));
                        this.datos[i, j].SetGreen(Convert.ToByte(g / 2));
                        this.datos[i, j].SetBlue(Convert.ToByte(b / 2));

                    }
                }
                grado--;
            }
        }
    }
}

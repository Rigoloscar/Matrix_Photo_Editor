using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_clases
{
    public class Pixel
    {
        // Atributos
        byte Green = 0;
        byte Blue = 0;
        byte Red = 0;

        // Métodos
        public byte GetBlue()
        {
            return (this.Blue);
        }

        public Pixel(byte red, byte green, byte blue)
        {
            this.Green = green;
            this.Blue = blue;
            this.Red = red;
        }

        public Pixel()
        {
        }

        public byte GetGreen()
        {
            return (this.Green);
        }

        public byte GetRed()
        {
            return (this.Red);
        }

        public void SetBlue(byte color)
        {
            this.Blue = color;
        }

        public void SetGreen(byte color)
        {
            this.Green = color;
        }

        public void SetRed(byte color)
        {
            this.Red = color;
        }
    }

   

}

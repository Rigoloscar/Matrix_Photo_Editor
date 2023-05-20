using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_1
{
    public partial class Enmarcar : Form
    {
        int grosor;
        byte[] RGB = new byte[3];
        Color color;
        public Enmarcar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.grosor = Convert.ToInt32(textBox2.Text);
                this.Close();
 
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los campos");
                return;
            }
        }

        public byte[] GetColor()
        {
            this.RGB[0] = this.color.R;
            this.RGB[1] = this.color.G;
            this.RGB[2] = this.color.B;

            return this.RGB;
        }
        public int GetMarco()
        {
            return this.grosor;
        }

        private void Enmarcar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.color = colorDialog1.Color;
            panel1.BackColor = color;
        }
    }
}

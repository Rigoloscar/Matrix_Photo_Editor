using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_1
{
    public partial class Intensidad : Form
    {
        byte[] resultat = new byte[3];

        public Intensidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //rojo
        {
            this.resultat[0] = Convert.ToByte(trackBarRojo.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e) //verde
        {
            this.resultat[1] = Convert.ToByte(trackBarVerde.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e) //azul
        {
            this.resultat[2] = Convert.ToByte(trackBarAzul.Value);
        }

        public byte[] Intensito()
        {
            return this.resultat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Formularios;
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
    public partial class Salir : Form
    {
        bool close = false;

        public Salir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.close = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.close = true;
            this.Close();
        }

        public bool Veredicto()
        {
            return this.close;
        }

        private void Salir_Load(object sender, EventArgs e)
        {

        }
    }
}

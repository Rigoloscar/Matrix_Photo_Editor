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
    public partial class Girar : Form
    {
        public Girar()
        {
            InitializeComponent();
        }
        char orientacion = 'o';

        private void button1_Click(object sender, EventArgs e)
        {
            this.orientacion = 'D';
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.orientacion = 'I';
            this.Close();
        }

        public char GetEje()
        {
            return this.orientacion;
        }

        private void Voltear_Load(object sender, EventArgs e)
        {
            this.orientacion = 'o';
        }

        private void Girar_Load(object sender, EventArgs e)
        {

        }
    }
}


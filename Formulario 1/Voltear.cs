using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_1
{
    public partial class Voltear : Form
    {
        char eje = 'o';

        public Voltear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eje = 'x';
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.eje = 'y';
            this.Close();
        }

        public char GetEje()
        {
            return this.eje;
        }

        private void Voltear_Load(object sender, EventArgs e)
        {
            this.eje = 'o';
        }
    }
}

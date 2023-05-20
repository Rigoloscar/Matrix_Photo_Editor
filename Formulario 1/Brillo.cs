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
    public partial class Brillo : Form
    {
        int valor = 0;

        public Brillo()
        {
            InitializeComponent();
        }

        private void Brillo_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.valor = trackBar1.Value;
            this.Close();
        }

        public int GetValue()
        {
            return valor;
        }
    }
}

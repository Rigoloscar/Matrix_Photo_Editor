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
    public partial class Desenfoque : Form
    {
        int grado;
        public Desenfoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.grado  = trackBar1.Value;
          this.Close();
        }

        public int GetGrado()
        {
            return grado;
        }

        private void Desenfoque_Load(object sender, EventArgs e)
        {
        }
    }
}

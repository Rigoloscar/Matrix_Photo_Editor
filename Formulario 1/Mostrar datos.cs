using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Mostrar_datos : Form
    {
        string identificador;
        string nombre;
        string ancho;
        string alto;

        public Mostrar_datos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = ("Nombre: "+this.nombre);
            label3.Text = ("Dimensiones: "+this.alto+" x "+this.ancho+" píxeles");
            label4.Text = ("Identificador: "+this.identificador);
        }
        
        public void SetID(string ID)
        {
            this.identificador = ID;
        }

        public void SetName(string name)
        {
            this.nombre = name;
        }

        public void SetAlto(string alto)
        {
            this.alto = alto;
        }

        public void SetAncho(string ancho)
        {
            this.ancho = ancho;
        }
    }
}

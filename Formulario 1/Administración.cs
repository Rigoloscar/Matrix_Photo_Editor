using Librería_1;
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
    public partial class Administración : Form
    {
        BaseDatos usuarios = new BaseDatos();
        DataTable tabla;
        int fila;

        public Administración()
        {
            InitializeComponent();
        }

        private void Administración_Load(object sender, EventArgs e)
        {
            this.usuarios.Iniciar();
            this.fila = 0;
            
            RellenarTabla();
        }

        private void RellenarTabla()
        {
            this.tabla = this.usuarios.DarTabla();
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = this.tabla.Rows.Count;
            dataGridView1.Columns[0].HeaderText = "Nombre de usuario";
            dataGridView1.Columns[1].HeaderText = "Contraseña";
            dataGridView1.Columns[2].HeaderText = "Correo electrónico";
            dataGridView1.Columns[3].HeaderText = "Estatus";

            dataGridView1.Columns[0].Width = 123;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 197;
            dataGridView1.Columns[3].Width = 123;

            for (int i=0; i <tabla.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = this.tabla.Rows[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = this.tabla.Rows[i][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = this.tabla.Rows[i][2].ToString();
                
                if (Convert.ToInt32(this.tabla.Rows[i][3]) == 1)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "Administrador";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Value = "Usuario estándar";
                }
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.fila = e.RowIndex;

            if (this.fila >= 0)
            {
                if (dataGridView1.Rows[this.fila].Cells[3].Value.ToString() == "Administrador")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string nombre = dataGridView1.Rows[this.fila].Cells[0].Value.ToString();

            if (checkBox1.Checked == true)
            {
                this.usuarios.ModificarAdmin(nombre, 1);
                dataGridView1.Invalidate();
                RellenarTabla();
            }
            else
            {
                this.usuarios.ModificarAdmin(nombre, 0);
                dataGridView1.Invalidate();
                RellenarTabla();
            }
        }

        private void Administración_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.usuarios.Cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = dataGridView1.Rows[this.fila].Cells[0].Value.ToString();
            usuarios.EliminarUsuario(nombre);
            dataGridView1.Invalidate();
            RellenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajustes f1 = new Ajustes();
            string nombre = dataGridView1.Rows[this.fila].Cells[0].Value.ToString();
            f1.GetDatos(nombre);
            f1.ShowDialog();
            dataGridView1.Invalidate();
            RellenarTabla();
        }
    }
}

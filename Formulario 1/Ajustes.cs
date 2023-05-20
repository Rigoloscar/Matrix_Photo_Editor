using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librería_1;
using Librería_de_clases;

namespace Formulario_1
{
    public partial class Ajustes : Form
    {
        BaseDatos usuarios = new BaseDatos();
        int operation; // Si es 0 no se produce nada, si es 1 se cambia el usuario, si es 2 se cambia la contraseña y si es 3 se cambia el email.
        string password;
        string user;
        string mail;


        public Ajustes()
        {
            InitializeComponent();
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            DoneBtn.Visible = false;
            DoneLbl.Visible = false;
            textBox1.Visible = false;
            this.operation = 0;
        }

        public void GetDatos(string user)
        {
            this.usuarios.Iniciar();
            DataTable datos = usuarios.GetUsuario(user);
            this.user = user;
            this.password = datos.Rows[0][1].ToString();
            this.mail = datos.Rows[0][2].ToString();

            NameLbl.Text = "Nombre: " + this.user;
            PassLbl.Text = "Contraseña: " + this.password;
            MailLbl.Text = "Email: " + this.mail;
        }

        private void NameBtn_Click(object sender, EventArgs e)
        {
            this.operation = 1;
            NameBtn.Enabled = false;
            PassBtn.Enabled = false;
            MailBtn.Enabled = false;
            textBox1.Clear();

            DoneBtn.Visible = true;
            DoneLbl.Visible = true;
            textBox1.Visible = true;
            DoneLbl.Text = "Nuevo nombre:";

        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            this.operation = 2;
            NameBtn.Enabled = false;
            PassBtn.Enabled = false;
            MailBtn.Enabled = false;
            textBox1.Clear();

            DoneBtn.Visible = true;
            DoneLbl.Visible = true;
            textBox1.Visible = true;
            DoneLbl.Text = "Nueva contraseña:";
        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            this.operation = 3;
            NameBtn.Enabled = false;
            PassBtn.Enabled = false;
            MailBtn.Enabled = false;
            textBox1.Clear();

            DoneBtn.Visible = true;
            DoneLbl.Visible = true;
            textBox1.Visible = true;
            DoneLbl.Text = "Nuevo email:";
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
           switch (this.operation)
           {
                case 1:

                    if (textBox1.TextLength >0)
                    {
                        string user = textBox1.Text;

                        if (usuarios.Cotejar(user, null) == 0)
                        {
                            this.user = user;
                            usuarios.ModificarUsuario(this.user, this.mail);
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario ya registrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se admite el campo en blanco");
                    }
                    break;

                case 2:

                    if (textBox1.TextLength > 0)
                    {
                        this.password = textBox1.Text;
                        usuarios.ModificarClave(this.user, this.password);
                    }
                    else
                    {
                        MessageBox.Show("No se admite el campo en blanco");
                    }
                    break;

                case 3: 
                    
                    if (textBox1.TextLength > 0)
                    {
                        string email = textBox1.Text;
                        int comprobar = ComprobarMail(email);
                        
                        if (comprobar == 1)
                        {
                            if (usuarios.Cotejar(null, email) == -1)
                            {
                                MessageBox.Show("Email ya registrado");
                            }
                            else
                            {
                                this.mail = email;
                                usuarios.ModificarMail(this.user, this.mail);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Formato incorrecto. El correo ha de contener una @ y un punto");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No se admite el campo en blanco");
                    }
                    break;
           }

            DoneBtn.Visible = false;
            DoneLbl.Visible = false;
            textBox1.Visible = false;
            textBox1.Clear();
            this.operation = 0;
            NameLbl.Text = "Nombre: " + this.user;
            PassLbl.Text = "Contraseña: " + this.password;
            MailLbl.Text = "Email: " + this.mail;
            NameBtn.Enabled = true;
            PassBtn.Enabled = true;
            MailBtn.Enabled = true;
        }

        private void Ajustes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.usuarios.Cerrar();
        }

        private int ComprobarMail(string mail) // Comprueba que el gmail tenga como mínimo una arroba y un punto
        {
            char[] lectura = mail.ToCharArray();
            bool arroba = false;
            bool punto = false;

            for (int i = 0; i < lectura.Length; i++)
            {
                if (lectura[i] == '@')
                {
                    arroba = true;
                }
                else if (lectura[i] == '.')
                {
                    punto = true;
                }
            }

            if (arroba == true && punto == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

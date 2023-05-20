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
    public partial class Autentificación : Form
    {
        BaseDatos usuarios = new BaseDatos();
        bool NewUser = false; // Indica si se está iniciando sesión o creando un nuevo usuario; false por defecto (inicio de sesión normal)
        bool autentification = false;
        string password;
        string user;
        string mail;
        int status; // Indica el tipo de usuario: estándar (0) o administrador (1)

        public Autentificación()
        {
            InitializeComponent();
        }

        private void Autentificación_Load(object sender, EventArgs e)
        {
            this.usuarios.Iniciar();

            MailText.Visible = false;
            mailLabel.Visible = false;
            CreateBtn.Visible = true;
            this.autentification = false;
            this.NewUser = false;
            passText.PasswordChar = '*';
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (this.NewUser == false)
            {
                string user = UserText.Text;
                string password = passText.Text;
                LogBtn.Text = "Iniciar sesión";

                DataTable consulta = this.usuarios.GetUsuario(user);

                if (consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario no registrado");
                }
                else if (consulta.Rows[0][1].ToString() != password)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else
                {
                    this.user = user;
                    this.password = password;
                    this.status = Convert.ToInt32(consulta.Rows[0][3]);
                    this.autentification = true;
                    this.usuarios.Cerrar();
                    this.Close();
                }
            }
            else if (this.NewUser == true)
            {
                LogBtn.Text = "Crear cuenta";
                string mail = MailText.Text;
                string user = UserText.Text;
                string password = passText.Text;
                int c =  this.usuarios.Cotejar(user, mail);

                if (c == -1)
                {
                    MessageBox.Show("Nombre de ususario i/o correo ya registrados");
                }
                else
                {
                    if (ComprobarMail(mail) == 0)
                    {
                        MessageBox.Show("Formato incorrecto. El correo ha de contener una @ y un punto");
                    }
                    else if (MailText.TextLength > 0 && UserText.TextLength > 0 && passText.TextLength > 0)
                    {
                        this.usuarios.AñadirUsuario(user, password, mail, 0);
                        this.user = user;
                        this.password = password;
                        this.status = 0;
                        MessageBox.Show("Usuario añadido con éxito");
                        this.autentification = true;
                        this.usuarios.Cerrar();
                        this.Close();
                    }
                }
            }
        }

        public string[] GiveDatos()
        {
            string[] respuesta = new string[2];
            respuesta[0] = this.user;
            respuesta[1] = Convert.ToString(this.status);
            return respuesta;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            LogBtn.Text = "Crear cuenta";
            UserText.Clear();
            passText.Clear();
            passText.ResetText();
            this.NewUser = true;
            CreateBtn.Visible = false;
            MailText.Visible = true;
            mailLabel.Visible = true;
        }

        private void Autentificación_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.autentification == true)
            {
                this.Close();
            }
            else
            {
                Environment.Exit(0);
            }
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

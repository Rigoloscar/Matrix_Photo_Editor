using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Librería_1
{
    public class BaseDatos
    {
        SQLiteConnection cnx = new SQLiteConnection();
        // Schema: (NOMBRE varchar primarykey, PASSWORD varchar, CORREO varchar, ESTATUS integer)
        // Tabla: usuarios
        public void Iniciar()
        {
            string dataSource = "Data Source=..\\..\\..\\SQL\\basedatos.db";
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }

        public DataTable DarTabla()
        {
            DataTable data = new DataTable();
            string mensaje = "SELECT * FROM usuarios";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(mensaje, this.cnx);
            adp.Fill(data);
            return data;
        }

        public void Cerrar()
        {
            this.cnx.Close();
        }

        public DataTable GetUsuario(string nombre)
        {
            DataTable data = new DataTable();
            string mensaje = "SELECT * FROM usuarios where NOMBRE='" + nombre + "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(mensaje, this.cnx);
            adp.Fill(data);
            return data;
        }

        public int Cotejar(string nombre, string mail)
        {
            DataTable data = new DataTable();
            DataTable data2 = new DataTable();
            string mensaje = "SELECT * FROM usuarios where NOMBRE='" + nombre + "'";
            string mensaje2 = "SELECT * FROM usuarios where CORREO='" + mail + "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(mensaje, this.cnx);
            adp.Fill(data);
            adp = new SQLiteDataAdapter(mensaje2, this.cnx);
            adp.Fill(data2);
            
            if (data.Rows.Count > 0)
            {
                return -1;
            }
            else if (data2.Rows.Count > 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public void AñadirUsuario(string nombre, string password, string correo, int status)
        {
            string mensaje = "INSERT INTO usuarios VALUES ('"+nombre+"', '"+password+"', '"+correo+"', "+status+")";
            SQLiteCommand comando = new SQLiteCommand(mensaje, this.cnx);
            comando.ExecuteNonQuery(); 
        }

        public void ModificarAdmin(string nombre, int status)
        {
            string mensaje = "UPDATE usuarios SET ESTATUS="+status+" WHERE NOMBRE='"+nombre+"'";
            SQLiteCommand comando = new SQLiteCommand(mensaje, this.cnx);
            comando.ExecuteNonQuery();
        }

        public void EliminarUsuario(string nombre)
        {
            string mensaje = "DELETE FROM usuarios WHERE NOMBRE='"+nombre+"'";
            SQLiteCommand comando = new SQLiteCommand(mensaje, this.cnx);
            comando.ExecuteNonQuery();
        }

        public void ModificarUsuario(string nombre, string mail)
        {
            string mensaje = "UPDATE usuarios SET NOMBRE='" + nombre + "' WHERE CORREO='" + mail + "'";
            SQLiteCommand comando = new SQLiteCommand(mensaje, this.cnx);
            comando.ExecuteNonQuery();
        }

        public void ModificarMail(string nombre, string mail)
        {
            string mensaje = "UPDATE usuarios SET CORREO='" + mail + "' WHERE NOMBRE='" + nombre + "'";
            SQLiteCommand comando = new SQLiteCommand(mensaje, this.cnx);
            comando.ExecuteNonQuery();
        }

        public void ModificarClave(string nombre, string password)
        {
            string mensaje = "UPDATE usuarios SET PASSWORD='" + password + "' WHERE NOMBRE='" + nombre + "'";
            SQLiteCommand comando = new SQLiteCommand(mensaje, this.cnx);
            comando.ExecuteNonQuery();
        }
    }
}

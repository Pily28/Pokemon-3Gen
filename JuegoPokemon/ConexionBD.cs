﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JuegoPokemon
{
   
     internal class ConexionBD
    {
        private string cadenaConexion = "Data Source=LAPTOP-8IOQJHCT;Initial Catalog=dbPoke;Integrated Security=True;"; //Cambien el "Data Source = ..." por el nombre de su servidor (aparece al abir SQL)

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                // No es necesario abrir la conexión aquí
                // conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            return conexion;
        }

        // Agrega un nuevo método para cerrar la conexión
        public void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}

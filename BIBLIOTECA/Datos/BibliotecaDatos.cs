using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIBLIOTECA.Entity;
using System.Data.SqlClient;
using System.Data;

namespace BIBLIOTECA.Datos
{
    class BibliotecaDatos
    {
        private string sCadenaConection = @"Data Source=DAVID_CHOQUE\SQLSERVER2012;Initial Catalog=BD_BIBLIOTECA;integrated security = true";

        internal int grabarBiblioteca(Biblioteca oBiblioteca)
        {
            var queryString = @"INSERT INTO BIBLIOTECA(NOM_BIBLIOTECA,DIRECCION,TELEFONO,EMAIL)
                               VALUES(@NOM_BIBLIOTECA,@DIRECCION,@TELEFONO,@EMAIL)";
            var respuesta = 0;
            try
            {
                using (SqlConnection conection = new SqlConnection(sCadenaConection))
                {
                    conection.Open();

                    SqlCommand command = conection.CreateCommand();
                    command.CommandText = queryString;
                    command.CommandType = CommandType.Text;

                    command.Parameters.Clear();
                    command.Parameters.Add("@NOM_BIBLIOTECA", SqlDbType.VarChar).Value = oBiblioteca.NomBiblioteca;
                    command.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = oBiblioteca.Direccion;
                    command.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = oBiblioteca.Telefono;
                    command.Parameters.Add("@EMAIL", SqlDbType.Char).Value = oBiblioteca.Email;
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

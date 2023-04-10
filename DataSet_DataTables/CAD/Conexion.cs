using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace CAD
{
    public class Connect
    {
        public SqlConnection Conexion = new SqlConnection(ConexionStr());
        public static string ConexionStr()
        {
            string cadena;
            using (XmlReader lectorxml = XmlReader.Create("settings.xml"))
            {
                lectorxml.ReadToFollowing("add");
                cadena = lectorxml.ReadElementContentAsString();
                return cadena;
            }
        }
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
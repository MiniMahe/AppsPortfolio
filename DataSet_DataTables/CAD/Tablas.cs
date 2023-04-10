using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    public class Tabla
    {
        private Connect conexion = new Connect();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public DataSet Datos()
        {
            DataSet dataSet = new DataSet("West_Music");
            comando.Connection = conexion.AbrirConexion();
            string sql = "select * from Customer";
            string sql1 = "select * from InvoiceLine";
            string sql2 = "select * from Invoice";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, comando.Connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(sql1, comando.Connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, comando.Connection);
            adapter.Fill(dataSet, "Customer");
            adapter1.Fill(dataSet, "InvoiceLine");
            adapter2.Fill(dataSet, "Invoice");
            comando.Connection = conexion.CerrarConexion();
            return dataSet;
        }
    }
}
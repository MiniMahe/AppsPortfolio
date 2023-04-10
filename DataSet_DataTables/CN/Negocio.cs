using CAD;
using System.Data;

namespace CN
{
    public class Negocio
    {
        private Tabla data = new Tabla();
        public DataSet MostrarCust()
        {
            DataSet lista = new DataSet();
            lista = data.Datos();
            return lista;
        }
    }
}
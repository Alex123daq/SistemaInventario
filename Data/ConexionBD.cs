using Microsoft.Data.SqlClient;

namespace SistemaInventario.Data
{
    public class ConexionBD
    {
        private string cadenaConexion =
            "Server=DESKTOP-7IUMJ8E\\SQLEXPRESS;Database=SistemaInventario;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
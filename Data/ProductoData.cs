using Microsoft.Data.SqlClient;
using SistemaInventario;

namespace SistemaInventario.Data
{
    public class ProductoData
    {
        private ConexionBD conexionBD = new ConexionBD();

        public void AgregarProducto(Producto producto)
        {
            using (var conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "INSERT INTO Productos (Codigo, Nombre, Cantidad, Precio) " +
                             "VALUES (@Codigo, @Nombre, @Cantidad, @Precio)";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
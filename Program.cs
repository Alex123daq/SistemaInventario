using Microsoft.Data.SqlClient;
using SistemaInventario;
using SistemaInventario.Data;

List<Producto> productos = new List<Producto>();

ProductoData productoData = new ProductoData();

int opcion = 0;
while ( opcion != 6)
{

    Console.WriteLine("================================");
    Console.WriteLine("      SISTEMA DE INVENTARIO");
    Console.WriteLine("================================");

    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Buscar producto");
    Console.WriteLine("4. Editar producto");
    Console.WriteLine("5. Eliminar producto");
    Console.WriteLine("6. Salir");

    Console.Write("Seleccione una opción: ");

    opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Seleccionaste la opción: {opcion}");


    if (opcion == 1)
    {
        Producto producto = new Producto();

        Console.Write("Codigo: ");
        producto.Codigo = Console.ReadLine();

        Console.Write("Nombre: ");
        producto.Nombre = Console.ReadLine();

        Console.Write("Cantidad: ");
        producto.Cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Precio: ");
        producto.Precio = Convert.ToDecimal(Console.ReadLine());

        productos.Add(producto);

        productoData.AgregarProducto(producto);

        Console.WriteLine("Producto agregado correctamente");

    }

    if (opcion == 2)
    {
        foreach (Producto producto in productos)
        {
            Console.WriteLine($"Codigo: {producto.Codigo}");
            Console.WriteLine($"Nombre: {producto.Nombre}");
            Console.WriteLine($"Cantidad: {producto.Cantidad}");
            Console.WriteLine($"Precio: {producto.Precio}");
            Console.WriteLine("----------------------");
        }
    }

    if (opcion == 3)
    {
        Console.WriteLine("Ingrese el codigo del producto: ");
        string codigo = Console.ReadLine();

        Producto productoEncontrado = productos.Find(p => p.Codigo == codigo);

        if (productoEncontrado != null)
        {
            Console.WriteLine($"Codigo: {productoEncontrado.Codigo}");
            Console.WriteLine($"Nombre: {productoEncontrado.Nombre}");
            Console.WriteLine($"Cantidad: {productoEncontrado.Cantidad}");
            Console.WriteLine($"Precio: {productoEncontrado.Precio}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado");
        }
    }

    if (opcion == 4)
    {
        Console.Write("Ingresa el codigo del producto: ");
        string codigo = Console.ReadLine();

     Producto productoEncontrado = productos.Find(p => p.Codigo == codigo);

        if (productoEncontrado != null) 
        {
            Console.Write("Nuevo Nombre: ");
            productoEncontrado.Nombre = Console.ReadLine();

            Console.Write("Cantidad: ");
            productoEncontrado.Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio: ");
            productoEncontrado.Precio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Producto actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    if (opcion == 5)
    {
        Console.Write("Ingrese el codigo del producto: ");
        string codigo = Console.ReadLine();


        Producto productoEncontrado = productos.Find(p => p.Codigo == codigo);

        if (productoEncontrado != null)
        {
            productos.Remove(productoEncontrado);

            Console.WriteLine("Producto eliminado correctamente");
        }
        else
        {
            Console.WriteLine("Producto no encontrado");
        }
    }


}




# Sistema de Inventario

Aplicación de consola desarrollada en C# para gestionar productos de un inventario.

## Funcionalidades

* Agregar productos.
* Mostrar productos.
* Buscar productos.
* Editar productos.
* Eliminar productos.
* Guardar productos en SQL Server.

## Tecnologías utilizadas

* C#
* .NET
* SQL Server
* Microsoft.Data.SqlClient
* Visual Studio

## Estructura del proyecto

```text
SistemaInventario
│
├── Data
│   ├── ConexionBD.cs
│   └── ProductoData.cs
│
├── Producto.cs
├── Program.cs
└── README.md
```

## Base de datos

El proyecto utiliza SQL Server para almacenar la información de los productos.

La tabla principal utilizada es:

`Productos`

Con los siguientes campos:

* `Codigo`
* `Nombre`
* `Cantidad`
* `Precio`

## Objetivo

Este proyecto fue desarrollado como parte de mi proceso de aprendizaje en C#, programación orientada a objetos y conexión con bases de datos.

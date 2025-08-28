// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Clientes cliente1 = new Clientes();
cliente1.Id = 1;
cliente1.Nombre = "Juan";
cliente1.Apellido = "Perez";
cliente1.Edad = 30;
cliente1.ProductosDisponibles = new List<Productos>();

Productos producto1 = new Productos();
producto1.Id = 1;
producto1.Nombre = "Coca Cola";
producto1.Precio = 50;
producto1.Disponibilidad = 100;
cliente1.ProductosDisponibles.Add(producto1);

Habitaciones habitacion1 = new Habitaciones();
habitacion1.Numero = 101;
habitacion1.Tipo = "Doble";
habitacion1.Precio = 200;
habitacion1.Disponible = true;
habitacion1.Clientes = new List<Clientes>();
habitacion1.Clientes.Add(cliente1);


Ventas venta1 = new Ventas();
venta1.Cliente = cliente1.Nombre;
venta1.Producto = producto1.Nombre;
venta1.Cantidad = 2;
venta1.Total = producto1.Precio * venta1.Cantidad;
venta1.ProductosVendidos = new List<Productos>();
venta1.ProductosVendidos.Add(producto1);

Console.WriteLine($"Cliente: {cliente1.Nombre} {cliente1.Apellido}, Edad: {cliente1.Edad}");
Console.WriteLine($"Habitacion: {habitacion1.Numero}, Tipo: {habitacion1.Tipo}, Precio: {habitacion1.Precio}, Disponible: {habitacion1.Disponible}");
Console.WriteLine($"Producto: {producto1.Nombre}, Precio: {producto1.Precio}, Disponibilidad: {producto1.Disponibilidad}");
Console.WriteLine($"Cliente: {venta1.Cliente}, Producto: {venta1.Producto}, Cantidad: {venta1.Cantidad}, Total: {venta1.Total}");

Console.ReadLine();

public class Clientes
{
    public int Id;
    public string? Nombre;
    public string? Apellido;
    public int Edad;
    public List<Productos>? ProductosDisponibles;
}

public class Habitaciones
{
    public int Numero;
    public string? Tipo;
    public int Precio;
    public bool Disponible;
    public List<Clientes>? Clientes;
}

public class Productos
{
    public int Id;
    public string? Nombre;
    public int Precio;
    public int Disponibilidad;
}

public class Ventas
{
    public string? Cliente;
    public string? Producto;
    public int Cantidad;
    public int Total;
    public List<Productos>? ProductosVendidos;

}

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
 public class Pizza
 {
    public Pizza(int id, string Nombre, decimal Precio, Picantes Picantes)
    {
        this.Id = id;
        this.Nombre = Nombre;
        this.Precio = Precio;
        this.Picantes = Picantes;
    }
    public int Id { get; }
    public string Nombre { get; }
    public decimal Precio { get; }
    public Picantes Picantes { get; }
 }
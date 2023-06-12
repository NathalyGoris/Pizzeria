using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
public class CestaDeCompras
 {
 public Cliente Cliente { get; set; } = new Cliente();
 public List<int> Ordenes { get; set; } = new List<int>();
 public bool HaPagado { get; set; }
 }
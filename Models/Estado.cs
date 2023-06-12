 using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
 public class Estados
{     
    public Menu Menu { get; } = new Menu();
    public CestaDeCompras Canasta { get; } = new CestaDeCompras();
    public UI UI { get; set; } = new UI();
}
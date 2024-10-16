namespace VentasInventarioBlazor.Models;

public class Venta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string NombreCliente { get; set; } = string.Empty;
    public double ValorProducto { get; set; }
    public double EfectivoRecibido { get; set; }
    public double Cambio { get; set; }
    public int Transferencia { get; set; } = 0;
}

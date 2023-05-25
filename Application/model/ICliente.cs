namespace Application.model;

public interface ICliente
{
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string Dni { get; set; }
}
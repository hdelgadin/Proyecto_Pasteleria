namespace Application.model.impl;

public class Pedido : IPedido
{
    private List<IServicio> _servicios;
    private double _gastosDeComida;
    private string _fechaDelEvento;
    private string _dniCliente;
    private int _idPedido;

    public Pedido(double gastosDeComida, string fechaDelEvento, string dniCliente, int idPedido)
    {
        _servicios = new List<IServicio>();
        _gastosDeComida = gastosDeComida;
        _fechaDelEvento = fechaDelEvento;
        _dniCliente = dniCliente;
        _idPedido = idPedido;
    }

    public List<IServicio> Servicios
    {
        get => _servicios;
    }

    public double GastosDeComida
    {
        get => _gastosDeComida;
        set => _gastosDeComida = value;
    }

    public string FechaDelEvento
    {
        get => _fechaDelEvento;
        set => _fechaDelEvento = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string DniCliente
    {
        get => _dniCliente;
        set => _dniCliente = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int IdPedido
    {
        get => _idPedido;
        set => _idPedido = value;
    }
}
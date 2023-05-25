namespace Application.model.impl;

public class Servicio : IServicio
{
    private string _nombreServicio;
    private string _tipoServicio;

    public Servicio(string nombreServicio, string tipoServicio)
    {
        _nombreServicio = nombreServicio;
        _tipoServicio = tipoServicio;
    }

    public string NombreServicio
    {
        get => _nombreServicio;
        set => _nombreServicio = value;
    }

    public string TipoServicio
    {
        get => _tipoServicio;
        set => _tipoServicio = value;
    }
}
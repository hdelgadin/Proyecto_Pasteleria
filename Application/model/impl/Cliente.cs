namespace Application.model.impl;

public class Cliente : ICliente
{
    private string _direccion;
    private string _telefono;
    private string _apellido;
    private string _nombre;
    private string _dni;

    public Cliente(string nombre, string apellido, string dni, string telefono, string direccion)
    {
        this._direccion = direccion;
        this._telefono = telefono;
        this._apellido = apellido;
        this._nombre = nombre;
        this._dni = dni;
    }

    public string Direccion
    {
        get => _direccion;
        set => _direccion = value;
    }

    public string Telefono
    {
        get => _telefono;
        set => _telefono = value;
    }

    public string Apellido
    {
        get => _apellido;
        set => _apellido = value;
    }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public string Dni
    {
        get => _dni;
        set => _dni = value;
    }
}
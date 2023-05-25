using Application.model;
using Application.util;

namespace Application.repository.impl;

public class RepositorioClienteImpl : IRepositorioCliente
{
    private List<ICliente> _clientes = new List<ICliente>();

    public ICliente Agregar(ICliente cliente)
    {
        _clientes.Add(cliente);

        return cliente;
    }

    public void Eliminar(ICliente cliente)
    {
        _clientes.Remove(cliente);
    }

    public void EliminarPorId(string id)
    {
        var cliente = ObtenerPorId(id);

        if (cliente.HasValue())
        {
            this.Eliminar(cliente.GetValue());
        }
    }

    public Optional<ICliente> ObtenerPorId(string id)
    {
        try
        {
            var cliente = _clientes.Where(cliente => cliente.Dni == id);

            return Optional<ICliente>.Of(cliente.First());
        }
        catch (Exception e)
        {
            return Optional<ICliente>.Empty();
        }
    }
}
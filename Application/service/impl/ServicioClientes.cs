using Application.model;
using Application.repository;
using Application.util;

namespace Application.service.impl;

public class ServicioClientes : IServicioClientes
{
    private IRepositorioCliente _repositorioCliente;

    public ServicioClientes(IRepositorioCliente repositorioCliente)
    {
        _repositorioCliente = repositorioCliente;
    }

    public ICliente Agregar(ICliente cliente)
    {
        this._repositorioCliente.Agregar(cliente);
        
        return cliente;
    }

    public void Eliminar(ICliente cliente)
    {
        this._repositorioCliente.Eliminar(cliente);
    }

    public void EliminarPorId(string id)
    {
        this._repositorioCliente.EliminarPorId(id);
    }

    public Optional<ICliente> ObtenerPorId(string id)
    {
        return this._repositorioCliente.ObtenerPorId(id);
    }
}
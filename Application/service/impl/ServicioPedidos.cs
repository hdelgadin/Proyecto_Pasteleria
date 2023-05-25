using Application.model;
using Application.repository;
using Application.util;

namespace Application.service.impl;

public class ServicioPedidos : IServicioPedidos
{
    private IRepositorioPedido _repositorioPedidos;

    public ServicioPedidos(IRepositorioPedido repositorioPedidos)
    {
        _repositorioPedidos = repositorioPedidos;
    }
    
    public IPedido Agregar(IPedido pedido)
    {
        this._repositorioPedidos.Agregar(pedido);

        return pedido;
    }

    public void Eliminar(IPedido pedido)
    {
        this._repositorioPedidos.Eliminar(pedido);
    }

    public void EliminarPorId(int id)
    {
        this._repositorioPedidos.EliminarPorId(id);
    }

    public Optional<IPedido> ObtenerPorId(int id)
    {
        return this._repositorioPedidos.ObtenerPorId(id);
    }
}
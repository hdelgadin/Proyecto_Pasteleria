using Application.model;
using Application.model.impl;
using Application.util;

namespace Application.repository.impl;

public class RepositorioPedidoImpl : IRepositorioPedido
{
    private List<IPedido> _pedidos = new List<IPedido>();

    public IPedido Agregar(IPedido pedido)
    {
        _pedidos.Add(pedido);

        return pedido;
    }

    public void Eliminar(IPedido pedido)
    {
        _pedidos.Remove(pedido);
    }

    public void EliminarPorId(int id)
    {
        var cliente = ObtenerPorId(id);

        if (cliente.HasValue())
        {
            this.Eliminar(cliente.GetValue());
        }
    }

    public Optional<IPedido> ObtenerPorId(int id)
    {
        try
        {
            var pedido = _pedidos.Where(cliente => cliente.IdPedido == id);

            return Optional<IPedido>.Of(pedido.First());
        }
        catch (Exception e)
        {
            return Optional<IPedido>.Empty();
        }
    }
}
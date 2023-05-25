using Application.repository;
using Application.repository.impl;
using Application.service;
using Application.service.impl;

namespace Application.factory.impl;

public class FabricaServicio : IFabricaServicio
{
    public IServicioPasteleria CrearServicioPasteleria()
    {
        IServicioPedidos pedidosService = GetPedidosService();
        IServicioClientes clientesService = GetClientesService();

        return new ServicioPasteleria(clientesService, pedidosService);
    }

    private IServicioPedidos GetPedidosService()
    {
        IRepositorioPedido repositorioPedido = new RepositorioPedidoImpl();

        return new ServicioPedidos(repositorioPedido);
    }

    private IServicioClientes GetClientesService()
    {
        IRepositorioCliente repositorioCliente = new RepositorioClienteImpl();

        return new ServicioClientes(repositorioCliente);
    }
}
namespace Application.service;

public interface IServicioPasteleria
{
    IServicioClientes ObtenerServicioClientes();
    
    IServicioPedidos obtenerServicioPedidos();
}
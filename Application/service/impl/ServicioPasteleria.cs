namespace Application.service.impl;

public class ServicioPasteleria :  IServicioPasteleria
{
    private IServicioClientes _servicioClientes;
    private IServicioPedidos _servicioPedidos;

    public ServicioPasteleria(IServicioClientes servicioClientes, IServicioPedidos servicioPedidos)
    {
        _servicioClientes = servicioClientes;
        _servicioPedidos = servicioPedidos;
    }

    public IServicioClientes ObtenerServicioClientes()
    {
        return _servicioClientes;
    }

    public IServicioPedidos obtenerServicioPedidos()
    {
        return _servicioPedidos;
    }
}
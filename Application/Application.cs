using Application.factory;
using Application.factory.impl;
using Application.model;
using Application.model.impl;
using Application.service;
using Application.util;

namespace Application;

public class Application
{
    
    public static void Main(String[] args)
    {
        IFabricaServicio fabrica = new FabricaServicio();

        IServicioPasteleria pasteleria = fabrica.CrearServicioPasteleria();
        
        MensajesUtil.EnviarMensajeBienvenida();
        
        Optional<ICliente> cliente = Optional<ICliente>.Empty();

        while (!cliente.HasValue())
        {
            cliente = PreguntarSiEsCliente(pasteleria);
        }
        
        //Optional<ICliente> 
    }

    public static Optional<ICliente> PreguntarSiEsCliente(IServicioPasteleria pasteleria)
    {
        Console.Write("Es cliente? Si/No: ");
        string esCliente = Console.ReadLine();
			
        //aca podemos agregar una exception para que cache si no escribe Si/No, que vuelva a preguntar o diga opcion incorrecta y vuelva a preguntar
        if (esCliente.Equals("No")) {
            return NewClient(pasteleria);
        }
        
        Optional<ICliente> cliente = GetCliente(pasteleria);

        if (!cliente.HasValue()) {
            Console.WriteLine("Cliente no encontrado con ese id!");
        }
            
        return cliente;
    }
    
    public static Optional<ICliente> NewClient(IServicioPasteleria pasteleria)
    {
        IServicioClientes clientes = pasteleria.ObtenerServicioClientes();
        
        Console.WriteLine("Ingrese su datos por favor: ");
        
        Console.Write ("Nombre: ");	   
        var nombre    = Console.ReadLine();
        Console.Write ("Apellido: ");  
        var apellido  = Console.ReadLine();
        Console.Write ("DNI: ");       
        var dni = Console.ReadLine();
        Console.Write ("Telefono: ");  
        var telefono  = Console.ReadLine();
        Console.Write ("Direccion: "); 
        var direccion = Console.ReadLine();
	    			
        ICliente cliente = new Cliente(nombre, apellido, dni, telefono, direccion);

        return Optional<ICliente>.Of(clientes.Agregar(cliente));
    }
    
    public static Optional<ICliente> GetCliente(IServicioPasteleria pasteleria){
        IServicioClientes clientes = pasteleria.ObtenerServicioClientes();

        Console.WriteLine("Ingrese su numero de documento: ");

        var dni = Console.ReadLine();

        return clientes.ObtenerPorId(dni);
    }
}
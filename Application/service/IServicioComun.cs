using Application.util;

namespace Application.service;

public interface IServicioComun<T, TE>
{
    public T Agregar(T cliente);
    
    public void Eliminar(T cliente);

    public void EliminarPorId(TE id);
    
    public Optional<T> ObtenerPorId(TE id);
}
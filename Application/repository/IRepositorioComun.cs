using Application.util;

namespace Application.repository;

public interface IRepositorioComun<T, TE>
{
    public T Agregar(T cliente);
    
    public void Eliminar(T cliente);

    public void EliminarPorId(TE id);
    
    public Optional<T> ObtenerPorId(TE id);
}
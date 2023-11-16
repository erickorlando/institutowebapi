using Instituto.Entidades;

namespace Instituto.Repositorios;

public interface IAlumnoRepository : IRepositoryBase<Alumno>
{
    Task EliminarTodos();
}
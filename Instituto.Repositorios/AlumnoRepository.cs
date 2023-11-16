using Dapper;
using Instituto.Datos;
using Instituto.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Instituto.Repositorios
{
    public class AlumnoRepository : RepositoryBase<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(InstitutoDbContext context) 
            : base(context)
        {
        }

        public async Task EliminarTodos()
        {
            var conexion = Context.Database.GetDbConnection();
            await conexion.QueryAsync("DELETE FROM Alumno");
        }
    }
}
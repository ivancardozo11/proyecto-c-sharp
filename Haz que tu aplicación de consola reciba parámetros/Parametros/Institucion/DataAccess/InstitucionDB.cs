using Institucion.Models;
using System.Data.Entity;

namespace Institucion.DataAccess
{
    public class InstitucionDB : DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
    }
}

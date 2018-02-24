using System.Data.Entity;

namespace PersistenciaTrabalho1.Models
{
    public class PersistenciaTrabalho1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PersistenciaTrabalho1Context() : base("name=PersistenciaTrabalho1Context")
        {
        }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}

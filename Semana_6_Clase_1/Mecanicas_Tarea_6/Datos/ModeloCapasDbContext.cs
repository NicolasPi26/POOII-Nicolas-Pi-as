using Mecanicas_Tarea_6.Datos.Entidades;
using Microsoft.EntityFrameworkCore;




namespace Mecanicas_Tarea_6.Datos
{
    public class ModeloCapasDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder opb)
        {
            var cn = @"server=localhost;uid=root;pwd=123456;database=mecanica_Mysql";
            opb.UseMySql(cn,
                ServerVersion.AutoDetect(cn) 
                );
        }
    }
}

using Mecanicas_Tarean6_Nicolas_Piñas.Data.Entidades;
using Microsoft.EntityFrameworkCore;



namespace Mecanicas_Tarean6_Nicolas_Piñas.Datos
{
    public class ModeloCapasDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opb)
        {
            var cn = @"server=localhost;uid=root;pwd=123456;database=Vehiculos_SQL";
            opb.UseMySql(cn,
                ServerVersion.AutoDetect(cn) 
                );
        }
    }
}

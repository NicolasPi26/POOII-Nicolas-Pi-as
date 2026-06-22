using Microsoft.EntityFrameworkCore;
using Mysql_ORM.Datos.Entidades;



namespace Mysql_ORM.Datos
{
    public class ModeloCapasDbContext : DbContext
    {

        public DbSet <Clientes> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opb)
        {
            var cn = @"server=localhost;uid=root;pwd=123456;database=cuarto_Mysql";
            opb.UseMySql(cn,
                ServerVersion.AutoDetect(cn) 
                );
        }
    }
}

using Microsoft.EntityFrameworkCore;



namespace ModeloCapas.CapaDatos
{
    public class ModeloCapasDbContext : DbContext
    {

        
        protected override void OnConfiguring(DbContextOptionsBuilder opb)
        {
            var cn = @"server=local;uid=root;pwd=123;database=cuarto_Mysql";
            opb.UseMySql(cn,
                Server)
        }
    }
}

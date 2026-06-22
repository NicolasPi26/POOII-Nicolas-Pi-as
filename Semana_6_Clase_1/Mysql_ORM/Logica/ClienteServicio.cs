using Mysql_ORM.Datos;
using Mysql_ORM.Datos.Entidades;
using Mysql_ORM.Migrations;

namespace Mysql_ORM.Logica
{
    public class ClienteServicio
    {
        private readonly ModeloCapasDbContext _dbContext;
        public ClienteServicio()
        {
            _dbContext = new ModeloCapasDbContext();
        }

        public List<Clientes> todos()
        {
            return _dbContext.Clientes.OrderBy(cl => cl.apellido).ToList();
        }

        public Clientes uno(int id)
        {
            return _dbContext.Clientes.FirstOrDefault(cl => cl.id == id);
        }
        public string insertar(Clientes clientes)
        {
            if (clientes == null) return "Error, debe completar la informaciondel cliente";
            try
            {
                _dbContext.Clientes.Add(clientes);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error" + ex.Message;
            }
        }
        public string actualizar(Clientes clientes)
        {
            if (clientes == null) return "Error, debe completar la informaciondel cliente";
            
            try
            {
                var cliente_base = _dbContext.Clientes
                .FirstOrDefault(cl => cl.id == clientes.id);

                cliente_base.telefono = clientes.telefono;
                cliente_base.apellido = clientes.apellido;
                cliente_base.direccion = clientes.direccion;
                cliente_base.correo = clientes.correo;
                cliente_base.nombre = clientes.nombre;

                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error" + ex.Message;
            }
            

        }

        public string eliminar(int id)
        {

            try
            {
                var cliente_base = _dbContext.Clientes
                .FirstOrDefault(cl => cl.id == id);

               
                _dbContext.Clientes.Remove(cliente_base);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error" + ex.Message;
            }


        }
    }
}




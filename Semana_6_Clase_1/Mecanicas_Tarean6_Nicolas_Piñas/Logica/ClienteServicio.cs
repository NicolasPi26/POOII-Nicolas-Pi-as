using Mecanicas_Tarean6_Nicolas_Piñas.Data.Entidades;
using Mecanicas_Tarean6_Nicolas_Piñas.Datos;
using Mecanicas_Tarean6_Nicolas_Piñas.Migrations;

namespace Mecanicas_Tarean6_Nicolas_Piñas.Logica
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
            if (clientes == null) return "Error, debe completar la informacion del cliente";
            try
            {
                _dbContext.Clientes.Add(clientes);
                _dbContext.SaveChanges();

                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
                
            }
        }
        public string actualizar(Clientes clientes)
        {
            if (clientes == null) return "Error, debe completar la informacion del cliente";
            try
            {
                var cliente_base = _dbContext.Clientes.FirstOrDefault(cl => cl.id == clientes.id);

                cliente_base.nombre = clientes.nombre;
                cliente_base.apellido = clientes.apellido;
                cliente_base.modelo = clientes.modelo;
                cliente_base.marca = clientes.marca;
                cliente_base.placa = clientes.placa;

                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message; 
            }
        }
        public string eliminar(int id)
        {
            try
            {
                var cliente_base = _dbContext.Clientes.FirstOrDefault(cl => cl.id == id);

                _dbContext.Clientes.Remove(cliente_base);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}

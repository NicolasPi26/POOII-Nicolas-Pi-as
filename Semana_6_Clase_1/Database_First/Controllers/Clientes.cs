namespace Database_First.Controllers
{
    using Database_First.Models;
    public class Clientes
    {
        private readonly JardineriaContext _jardineriaContext;
        public Clientes()
        {
            _jardineriaContext = new JardineriaContext();
        }
        public List<Cliente> todos()
        {
            return _jardineriaContext.Clientes.OrderBy(cl => cl.NombreCliente).ToList();
        }
        public Cliente uno(int codigoCliente)
        {
            return _jardineriaContext.Clientes.FirstOrDefault(cl => cl.CodigoCliente == codigoCliente);
        }
        public string agregrar(Cliente cliente)
        {
            try
            {
                if (cliente == null) return "Error al guardar el cliente";
                _jardineriaContext.Clientes.Add(cliente);
                _jardineriaContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string editar(Cliente cliente)
        {
            var cl = _jardineriaContext.Clientes.FirstOrDefault(cl => cl.CodigoCliente == cliente.CodigoCliente);
            if (cl is null) return "No se encontro al cliente";
            cl.NombreCliente = cliente.NombreCliente;
            cl.NombreContacto = cliente.NombreContacto;
            cl.ApellidoContacto = cliente.ApellidoContacto;
            cl.Telefono = cliente.Telefono;
            cl.Fax = cliente.Fax;
            cl.LineaDireccion1 = cliente.LineaDireccion1;
            cl.LineaDireccion2 = cliente.LineaDireccion2;
            cl.Ciudad = cliente.Ciudad;
            cl.Region = cliente.Region;
            cl.Pais = cliente.Pais;
            cl.CodigoPostal = cliente.CodigoPostal;
            cl.LimiteCredito = cliente.LimiteCredito;
            _jardineriaContext.Clientes.Update(cl);
            if (_jardineriaContext.SaveChanges() > 1)
            {
                return "ok";
            }
            else
            {
                return "Error al actualizar";
            }        
        }
        public string eliminar (int codigoCliente)
        {
            var cl = _jardineriaContext.Clientes.FirstOrDefault(cl => cl.CodigoCliente == codigoCliente);
            if (cl is null) return "No se encontro al cliente";
            _jardineriaContext.Clientes.Remove(cl);
            if (_jardineriaContext.SaveChanges() > 1)
            {
                return "Ok";
            }
            else
            {
                return "Ocurrio un error al eliminar el cliente";
            }
        }
    }
}

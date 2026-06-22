using Database_First.Models;
using Database_First.Models.Viewmodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database_First.Controllers
{
    public class Pedidos
    {
        private readonly JardineriaContext _jardinieriaContext;

        public Pedidos()
        {
            _jardinieriaContext = new JardineriaContext();
        }

        public List<ListaPedidosConProductos> ListaPedidosConProductos()
        {
            return (
                from po in _jardinieriaContext.Productos
                join dp in _jardinieriaContext.DetallePedidos
                on po.CodigoProducto equals dp.CodigoProducto
                join pe in _jardinieriaContext.Pedidos
                on dp.CodigoPedido equals pe.CodigoPedido
                select new ListaPedidosConProductos
                {
                    Cantidad = dp.Cantidad,
                    CantidadEnStock = po.CantidadEnStock,
                    CodigoCliente = pe.CodigoCliente,
                    CodigoProducto = po.CodigoProducto,
                    CodigoPedido = pe.CodigoPedido,
                    Comentarios = pe.Comentarios,
                    Descripcion = po.Descripcion,
                    Dimensiones = po.Dimensiones,
                    Estado = pe.Estado,
                    FechaEntrega = pe.FechaEntrega,
                    FechaEsperada = pe.FechaEsperada,
                    FechaPedido = pe.FechaPedido,
                    Gama = po.Gama,
                    Nombre = po.Nombre,
                    NumeroLinea = dp.NumeroLinea,
                    PrecioProveedor = po.PrecioProveedor,
                    PrecioUnidad = dp.PrecioUnidad,
                    PrecioVenta = po.PrecioVenta,
                    Proveedor = po.Proveedor,


                }
                ).toList();
        }
    }
}

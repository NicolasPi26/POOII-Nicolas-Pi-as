using ModeloCapas.CapaDatos;
using ModeloCapas.CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloCapas.CapaLogica
{
    public class VehiculosServicio // es lo mismo que el controller
    {
        private readonly ModeloCapasDbContext _db;
        public VehiculosServicio() 
        {
            _db = new ModeloCapasDbContext();
        }

        public List<VehiculoEntity> todosVehiculo()
        {
            return _db.Vehiculos.ToList();
        }

        public List<MatriculaEntity> todosVehiculosMatriculados ()
        {
            var res = (from vh in _db.Vehiculos
                      join ma in _db.Matriculas on vh.id equals ma.VehiculoEntityId
                      select new MatriculaEntity
                      {
                          Anio_Matricula = ma.Anio_Matricula,
                          Estado = ma.Estado,
                          VehiculoEntityId = ma.VehiculoEntityId,
                          id = ma.id,
                          VehiculoEntity = ma.VehiculoEntity,
                      }).ToList();
            return res;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModeloCapas.CapaDatos.Entidades
{
    public class MatriculaEntity
    {

        public int id {  get; set; }
        public DateOnly Anio_Matricula {  get; set; }
        public bool Estado {  get; set; }
        // estado=> Matriculado = true || Matriculado = False
        // Un vehiculo cuando cumple todos los requisitos esta matriculado

        // relaciones entre tablas

        public int VehiculoEntityId { get; set; }
        public VehiculoEntity VehiculoEntity { get; set; }


    }
}

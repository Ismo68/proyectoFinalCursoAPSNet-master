﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinalCursoAPSNet.Models
{
    public class Producto
    {
        [Key]
        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Categoria { get; set; }
        //[Column(TypeName = "number(18, 2)")]
        //[DisplayFormat(DataFormatString = "{0:€#,##}")]
        public Decimal Precio { get; set; }
        public Byte[] Imagen { get; set; }
        public String URLImagen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Entities
{
    public class Libro
    {
        [Key]
        public int Idlibro { get; set; }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Precio { get; set; }

    }
}

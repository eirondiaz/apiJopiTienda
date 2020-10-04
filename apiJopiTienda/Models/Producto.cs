using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiJopiTienda.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Precio { get; set; }
        public string Stock { get; set; }
        public string Foto { get; set; }
    }
}

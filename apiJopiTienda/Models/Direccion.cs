using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiJopiTienda.Models
{
    public class Direccion
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public string Pais { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
    }
}

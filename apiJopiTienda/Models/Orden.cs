using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiJopiTienda.Models
{
    public class Orden
    {
        [Key]
        public string Id { get; set; }
        public string Fecha { get; set; }
        public string Total { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public string Productos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiJopiTienda.Models
{
    public class Cart
    {
        public Cart()
        {
            Currency = "USD";
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public int ProductoId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiJopiTienda.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public List<Direccion> Direcciones { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Orden> Ordenes { get; set; }
    }
}

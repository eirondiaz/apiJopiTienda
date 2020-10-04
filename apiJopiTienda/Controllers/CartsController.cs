using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiJopiTienda.Context;
using apiJopiTienda.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiJopiTienda.Controllers
{
    [Route("api/usuarios/{UsuarioId}/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class CartsController : ControllerBase
    {
        private readonly AppDbContext context;
        public CartsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Cart> GetAll(int UsuarioId)
        {
            return context.Carts.Where(x => x.UsuarioId == UsuarioId).ToList();
            //var q = from x in context.Carts select new CartModel { Sku = x.Id, Name = x.Name, Price = x.Price, Quantity = x.Quantity, Currency = x.Currency };

            //return q.ToList();
        }

        [HttpGet("{id}", Name = "cartCreada")]
        public IActionResult GetById(int id, int UsuarioId)
        {
            var car = context.Carts.FirstOrDefault(x => x.Id == id && x.UsuarioId == UsuarioId);

            if (car == null)
            {
                return NotFound();
            }

            return new ObjectResult(car);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Cart car, int UsuarioId)
        {
            car.UsuarioId = UsuarioId;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prod = context.Productos.FirstOrDefault(x => x.Id == car.ProductoId);

            if (prod != null)
            {
                car.Name = prod.Nombre;
                car.Price = prod.Precio + ".00";
                context.Carts.Add(car);
                context.SaveChanges();

                return Ok(car);
            }

            return BadRequest();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, int UsuarioId)
        {
            var car = context.Carts.FirstOrDefault(x => x.Id == id && x.UsuarioId == UsuarioId);

            if (car == null)
            {
                return NotFound();
            }

            context.Remove(car);
            context.SaveChanges();
            return Ok(car);
        }
    }
}
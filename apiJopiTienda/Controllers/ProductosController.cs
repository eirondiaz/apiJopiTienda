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
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext context;
        public ProductosController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return context.Productos.ToList();
        }

        [HttpGet("{id}", Name = "prodCreado")]
        public IActionResult Get(int id)
        {
            var prod = context.Productos.FirstOrDefault(x => x.Id == id);

            if (prod == null)
            {
                return NotFound();
            }

            return Ok(prod);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Producto prod)
        {
            if (ModelState.IsValid)
            {
                context.Productos.Add(prod);
                context.SaveChanges();

                return new CreatedAtRouteResult("prodCreado", new { id = prod.Id }, prod);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prod = context.Productos.FirstOrDefault(x => x.Id == id);

            if (prod == null)
            {
                return NotFound();
            }

            context.Productos.Remove(prod);
            context.SaveChanges();
            return Ok(prod);
        }
    }
}
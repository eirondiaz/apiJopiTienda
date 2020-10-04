using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiJopiTienda.Context;
using apiJopiTienda.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiJopiTienda.Controllers
{
    [Route("api/usuarios/{UsuarioId}/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class OrdenesController : ControllerBase
    {
        private readonly AppDbContext context;
        public OrdenesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Orden> Get(int UsuarioId)
        {
            return context.Ordenes.Where(x => x.UsuarioId == UsuarioId).ToList();
        }

        [HttpGet("{id}", Name = "orderCreada")]
        public IActionResult GetById(string id, int UsuarioId)
        {
            var ord = context.Ordenes.FirstOrDefault(x => x.Id == id.ToString() && x.UsuarioId == UsuarioId);

            if (ord == null)
            {
                return NotFound();
            }

            return new ObjectResult(ord);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Orden ord, int UsuarioId)
        {
            ord.UsuarioId = UsuarioId;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Ordenes.Add(ord);
            context.SaveChanges();

            return Ok(ord);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id, int UsuarioId)
        {
            var ord = context.Ordenes.FirstOrDefault(x => x.Id == id.ToString() && x.UsuarioId == UsuarioId);

            if (ord == null)
            {
                return NotFound();
            }

            context.Remove(ord);
            context.SaveChanges();
            return Ok(ord);
        }
    }
}
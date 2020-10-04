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
    public class DireccionesController : ControllerBase
    {
        private readonly AppDbContext context;
        public DireccionesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Direccion> GetAll(int UsuarioId)
        {
            return context.Direcciones.Where(x => x.UsuarioId == UsuarioId).ToList();
        }

        // GET: api/pais/1/provincia/5
        [HttpGet("{id}", Name = "direccionCreada")]
        public IActionResult GetById(int id, int UsuarioId)
        {
            var dir = context.Direcciones.FirstOrDefault(x => x.Id == id && x.UsuarioId == UsuarioId);

            if (dir == null)
            {
                return NotFound();
            }

            return new ObjectResult(dir);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Direccion dir, int UsuarioId)
        {
            dir.UsuarioId = UsuarioId;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Direcciones.Add(dir);
            context.SaveChanges();

            return Ok(dir);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Direccion dir, int id)
        {
            if (dir.Id != id)
            {
                return BadRequest();
            }

            context.Entry(dir).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, int UsuarioId)
        {
            var dir = context.Direcciones.FirstOrDefault(x => x.Id == id && x.UsuarioId == UsuarioId);

            if (dir == null)
            {
                return NotFound();
            }

            context.Remove(dir);
            context.SaveChanges();
            return Ok(dir);
        }
    }
}
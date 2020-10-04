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
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext context;
        public UsuariosController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return context.Usuarios.Include(x => x.Direcciones).Include(x => x.Carts).Include(x => x.Ordenes).ToList();
        }

        [HttpGet("{id}", Name = "userCreado")]
        public IActionResult Get(int id)
        {
            var user = context.Usuarios.Include(x => x.Direcciones).Include(x => x.Carts).Include(x => x.Ordenes).FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario user)
        {
            if (ModelState.IsValid)
            {
                context.Usuarios.Add(user);
                context.SaveChanges();

                return new CreatedAtRouteResult("userCreado", new { id = user.Id }, user);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = context.Usuarios.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            context.Usuarios.Remove(user);
            context.SaveChanges();
            return Ok(user);
        }
    }
}
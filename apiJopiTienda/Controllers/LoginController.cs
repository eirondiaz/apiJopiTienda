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
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext context;
        public LoginController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario user)
        {
            var userr = context.Usuarios.FirstOrDefault(x => x.Correo == user.Correo && x.Contraseña == user.Contraseña);

            if (userr != null)
            {
                return Ok(userr);
            }

            return NotFound("Usuario o contraseña no valido");
        }
    }
}
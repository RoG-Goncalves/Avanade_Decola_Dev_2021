using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //<summary>
        //teste
        //</sumary>


        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModeInput loginViewModeInput)
        {
            return Ok(loginViewModeInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModeInput loginViewModeInput)
        {
            return Created("", loginViewModeInput);
        }
    }
}

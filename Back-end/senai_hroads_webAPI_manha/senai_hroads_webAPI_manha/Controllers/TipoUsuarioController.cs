using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webAPI_manha.Domains;
using senai_hroads_webAPI_manha.Interfaces;
using senai_hroads_webAPI_manha.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _TipoUsuarioRepository { get; set; }

        public TipoUsuarioController()
        {
            _TipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [Authorize(Roles = "2")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoUsuarioRepository.Listar());
        }



        [Authorize(Roles = "2")]
        [HttpGet("{idTipoUsuario}")]
        public IActionResult BuscarPorId(int idTipoUsuario)
        {
            return Ok(_TipoUsuarioRepository.BuscarPorId(idTipoUsuario));
        }



        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastrar(TipoUsuario novaTipoUsuario)
        {
            _TipoUsuarioRepository.Cadastrar(novaTipoUsuario);

            return StatusCode(201);
        }



        [Authorize(Roles = "2")]
        [HttpPut("{idTipoUsuario}")]
        public IActionResult AtualizarIdUrl(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizada)
        {
            _TipoUsuarioRepository.AtualizarIdUrl(idTipoUsuario, TipoUsuarioAtualizada);
            return StatusCode(204);
        }



        [Authorize(Roles = "2")]
        [HttpDelete("{idTipoUsuario}")]
        public IActionResult Deletar(int idTipoUsuario)
        {
            _TipoUsuarioRepository.Deletar(idTipoUsuario);

            return StatusCode(204);
        }
    }
}
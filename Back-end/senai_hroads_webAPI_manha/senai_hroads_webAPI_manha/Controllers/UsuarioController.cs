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

    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [Authorize(Roles = "2")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_UsuarioRepository.Listar());
        }



        [Authorize(Roles = "2")]
        [HttpGet("{idUsuario}")]
        public IActionResult BuscarPorId(int idUsuario)
        {
            return Ok(_UsuarioRepository.BuscarPorId(idUsuario));
        }




        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastrar(Usuario novaUsuario)
        {
            _UsuarioRepository.Cadastrar(novaUsuario);

            return StatusCode(201);
        }



        [Authorize(Roles = "2")]
        [HttpPut("{idUsuario}")]
        public IActionResult AtualizarIdUrl(int idUsuario, Usuario UsuarioAtualizada)
        {
            _UsuarioRepository.AtualizarIdUrl(idUsuario, UsuarioAtualizada);
            return StatusCode(204);
        }



        [Authorize(Roles = "2")]
        [HttpDelete("{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {
            _UsuarioRepository.Deletar(idUsuario);

            return StatusCode(204);
        }
    }
}
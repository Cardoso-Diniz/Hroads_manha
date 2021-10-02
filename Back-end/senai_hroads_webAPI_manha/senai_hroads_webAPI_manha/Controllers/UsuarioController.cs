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
    [Produces(" application / json ")]
    [Route(" api / [controlador] ")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_UsuarioRepository.Listar());
        }

        [HttpGet(" {idUsuario} ")]
        public IActionResult BuscarPorId(int idUsuario)
        {
            return Ok(_UsuarioRepository.BuscarPorId(idUsuario));
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario novaUsuario)
        {
            _UsuarioRepository.Cadastrar(novaUsuario);

            return StatusCode(201);
        }

        [HttpPut(" {idUsuario} ")]
        public IActionResult AtualizarIdUrl(int idUsuario, Usuario UsuarioAtualizada)
        {
            _UsuarioRepository.AtualizarIdUrl(idUsuario, UsuarioAtualizada);
            return StatusCode(204);
        }

        [HttpDelete(" {idUsuario} ")]
        public IActionResult Deletar(int idUsuario)
        {
            _UsuarioRepository.Deletar(idUsuario);

            return StatusCode(204);
        }
    }
}
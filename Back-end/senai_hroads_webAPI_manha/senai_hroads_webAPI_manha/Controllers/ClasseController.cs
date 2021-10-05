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

    public class ClasseController : ControllerBase
    {
        private IClasseRepository _classeRepository { get; set; }

        public ClasseController()
        {
            _classeRepository = new ClasseRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_classeRepository.Listar());
        }



        [HttpGet("{idClasse}")]
        public IActionResult BuscarPorId(int idClasse)
        {
            return Ok(_classeRepository.BuscarPorId(idClasse));
        }



        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastrar(Classe novaClasse)
        {
            _classeRepository.Cadastrar(novaClasse);

            return StatusCode( 201 );
        }



        [Authorize(Roles = "2")]
        [HttpPut("{idClasse}")]
        public IActionResult AtualizarIdUrl(int idClasse, Classe classeAtualizada)
        {
            _classeRepository.AtualizarIdUrl(idClasse, classeAtualizada);
            return StatusCode( 204 );
        }



        [Authorize(Roles = "2")]
        [HttpDelete("{idClasse}")]
        public IActionResult Deletar(int idClasse)
        {
            _classeRepository.Deletar(idClasse);

            return StatusCode( 204 );
        }
    }
}
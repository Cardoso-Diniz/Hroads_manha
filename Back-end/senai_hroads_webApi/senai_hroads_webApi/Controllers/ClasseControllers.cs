using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webApi.Interfaces;
using senai_hroads_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Controllers
{
    //Aplicação Json
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class ClasseControllers: ControllerBase
    {
        private IClasseRepository _ClasseRepository { get; set; }

        public ClasseControllers()

        {
            _ClasseRepository = new ClasseRepository();
        }

        [HttpGet]
        //Resultado de uma Ação
        public IActionResult Listar()
        {
            return Ok(_ClasseRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            return Ok(_ClasseRepository.Listar(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar()
        {
           _ClasseRepository.Cadastrar();
            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, ClasseRepository ClasseAtt)
        {
            _ClasseRepository.Atualizar(id, ClasseAtt);
            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _ClasseRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}

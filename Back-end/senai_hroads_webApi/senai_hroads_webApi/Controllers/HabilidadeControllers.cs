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

    public class HabilidadeControllers : ControllerBase
    {
        private IHabilidadeRepository _HabilidadeRepository { get; set; }

        public HabilidadeControllers()

        {
            _HabilidadeRepository = new HabilidadeRepository();
        }

        [HttpGet]
        //Resultado de uma Ação
        public IActionResult Listar()
        {
            return Ok(_HabilidadeRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            return Ok(_HabilidadeRepository.Listar(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar()
        {
            _HabilidadeRepository.Cadastrar();
            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, HabilidadeRepository HabilidadeAtt)
        {
            _HabilidadeRepository.Atualizar(id, HabilidadeAtt);
            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _HabilidadeRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}

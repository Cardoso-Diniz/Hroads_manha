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
    [Route("api/[controller]")]
    [ApiController]

    public class TipoHabilidadeController : ControllerBase
    {
        private ITipoHabilidadeRepository _TipoHabilidadeRepository { get; set; }

        public TipoHabilidadeController()
        {
            _TipoHabilidadeRepository = new TipoHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoHabilidadeRepository.Listar());
        }

        [HttpGet(" {idTipoHabilidade} ")]
        public IActionResult BuscarPorId(int idTipoHabilidade)
        {
            return Ok(_TipoHabilidadeRepository.BuscarPorId(idTipoHabilidade));
        }

        [HttpPost]
        public IActionResult Cadastrar(TipoHabilidade novaTipoHabilidade)
        {
            _TipoHabilidadeRepository.Cadastrar(novaTipoHabilidade);

            return StatusCode(201);
        }

        [HttpPut(" {idTipoHabilidade} ")]
        public IActionResult AtualizarIdUrl(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada)
        {
            _TipoHabilidadeRepository.AtualizarIdUrl(idTipoHabilidade, TipoHabilidadeAtualizada);
            return StatusCode(204);
        }

        [HttpDelete(" {idTipoHabilidade} ")]
        public IActionResult Deletar(int idTipoHabilidade)
        {
            _TipoHabilidadeRepository.Deletar(idTipoHabilidade);

            return StatusCode(204);
        }
    }
}
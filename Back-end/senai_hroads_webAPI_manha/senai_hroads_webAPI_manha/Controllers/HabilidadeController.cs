﻿using Microsoft.AspNetCore.Authorization;
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

    public class HabilidadeController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadeController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar(int id)
        {
            return Ok(_habilidadeRepository.Listar(id));
        }



        [HttpGet("{idHabilidade}")]
        public IActionResult BuscarPorId(int idHabilidade)
        {
            return Ok(_habilidadeRepository.BuscarPorId(idHabilidade));
        }



        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastrar(Habilidade novaHabilidade)
        {
            _habilidadeRepository.Cadastrar(novaHabilidade);

            return StatusCode(201);
        }



        [Authorize(Roles = "2")]
        [HttpPut("{idHabilidade}")]
        public IActionResult AtualizarIdUrl(int idHabilidade, Habilidade HabilidadeAtualizada)
        {
            _habilidadeRepository.AtualizarIdUrl(idHabilidade, HabilidadeAtualizada);
            return StatusCode(204);
        }



        [Authorize(Roles = "2")]
        [HttpDelete("{idHabilidade}")]
        public IActionResult Deletar(int idHabilidade)
        {
            _habilidadeRepository.Deletar(idHabilidade);

            return StatusCode(204);
        }
    }
}
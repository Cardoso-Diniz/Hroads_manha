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

    public class PersonagemController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

        public PersonagemController()
        {
            _personagemRepository = new PersonagemRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_personagemRepository.Listar());
        }




        [Authorize]
        [HttpGet("{idPersonagem}")]
        public IActionResult BuscarPorId(int idPersonagem)
        {
            return Ok(_personagemRepository.BuscarPorId(idPersonagem));
        }



        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Personagem novaPersonagem)
        {
            _personagemRepository.Cadastrar(novaPersonagem);

            return StatusCode(201);
        }



        [Authorize(Roles = "2")]
        [HttpPut("{idPersonagem}")]
        public IActionResult AtualizarIdUrl(int idPersonagem, Personagem PersonagemAtualizada)
        {
            _personagemRepository.AtualizarIdUrl(idPersonagem, PersonagemAtualizada);
            return StatusCode(204);
        }



        [Authorize(Roles = "2")]
        [HttpDelete("{idPersonagem}")]
        public IActionResult Deletar(int idPersonagem)
        {
            _personagemRepository.Deletar(idPersonagem);

            return StatusCode(204);
        }
    }
}
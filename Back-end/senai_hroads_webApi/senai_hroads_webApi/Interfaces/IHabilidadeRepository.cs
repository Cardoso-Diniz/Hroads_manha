using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface IHabilidadeRepository
    {
        List<HabilidadeDomain> Listar();
        HabilidadeDomain Buscar(int id);
        void Deletar(int id);
        void Atualizar(int id, HabilidadeDomain HabilidadeAtt);
        void Cadastrar(HabilidadeDomain HabilidadeNova);
    }
}

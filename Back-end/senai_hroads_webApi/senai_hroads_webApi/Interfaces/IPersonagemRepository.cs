using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface IPersonagemRepository
    {
        List<PersonagemDomain> Listar();
        PersonagemDomain Buscar(int id);
        void Deletar(int id);
        void Atualizar(int id, PersonagemDomain PersonagemAtt);
        void Cadastrar(PersonagemDomain PersonagenNovo);
    }
}

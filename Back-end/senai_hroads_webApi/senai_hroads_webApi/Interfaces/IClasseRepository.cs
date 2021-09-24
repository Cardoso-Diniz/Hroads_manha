using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface IClasseRepository
    {
        List<ClasseDomain> Listar(int id);
        ClasseDomain Buscar(int id);
        void Deletar(int id);
        void Atualizar(int id, ClasseDomain ClasseAtt);
        void Cadastrar(ClasseDomain ClasseNova);
        void Cadastrar();
        void Atualizar(int id, ClasseRepository classeAtt);
        object Listar();
    }
}
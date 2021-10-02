using senai_hroads_webAPI_manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> Listar();
        Classe BuscarPorId(int idClasse);
        void AtualizarIdUrl(int idClasse, Classe classeAtualizada);
        void Cadastrar(Classe novaClasse);
        void Deletar(int idClasse);
    }
}

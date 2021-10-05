using senai_hroads_webAPI_manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar(int id);
        Habilidade BuscarPorId(int idHabilidade);
        void AtualizarIdUrl(int idHabilidade, Habilidade HabilidadeAtualizada);
        void Cadastrar(Habilidade novaHabilidade);
        void Deletar(int idHabilidade);
    }
}

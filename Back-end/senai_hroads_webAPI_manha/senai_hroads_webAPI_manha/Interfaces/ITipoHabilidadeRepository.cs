using senai_hroads_webAPI_manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();
        TipoHabilidade BuscarPorId(int idTipoHabilidade);
        void AtualizarIdUrl(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada);
        void Cadastrar(TipoHabilidade novaTipoHabilidade);
        void Deletar(int idTipoHabilidade);
    }
}

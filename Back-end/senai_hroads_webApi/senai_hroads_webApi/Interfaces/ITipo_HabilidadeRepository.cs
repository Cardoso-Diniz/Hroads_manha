using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface ITipo_HabilidadeRepository
    {
        List<Tipo_HabilidadeDomain> ListarTodos();
        Tipo_HabilidadeDomain BuscarPorId(int IdTipoHabilidade);
        void Cadastrar(Tipo_HabilidadeDomain NovoTipoHabilidade);
        void Atualizar(int IdIdTipoHabilidade, Tipo_HabilidadeDomain TipoHabilidadeAtt);
        void Deletar(int IdTipoHabilidade);
    }
}

using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuarioDomain> ListarTodos();
        TipoUsuarioDomain BuscarPorId(int IdTipoUsuario);
        void Cadastrar(TipoUsuarioDomain NovoTipoUsuario);
        void Atualizar(int IdTipoUsuario, TipoUsuarioDomain TipoUsuarioAtt);
        void Deletar(int IdTipoUsuario);
    }
}

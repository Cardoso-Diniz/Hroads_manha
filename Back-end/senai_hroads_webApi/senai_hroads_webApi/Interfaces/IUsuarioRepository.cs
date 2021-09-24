using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        UsuarioDomain BuscarPorEmailSenha(string Email, string Senha);
        List<UsuarioDomain> ListarTodos();
        UsuarioDomain BuscarPorId(int IdUsuario);
        void Cadastrar(UsuarioDomain NovoUsuario);
        void Atualizar(int IdUsuario, UsuarioDomain UsuarioAtt);
        void Deletar(int IdUsuario);
    }
}

using senai_hroads_webAPI_manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        Usuario BuscarPorId(int idUsuario);
        void AtualizarIdUrl(int idUsuario, Usuario UsuarioAtualizada);
        void Cadastrar(Usuario novaUsuario);
        void Deletar(int idUsuario);
        Usuario Login(string email, string senha);
    }
}

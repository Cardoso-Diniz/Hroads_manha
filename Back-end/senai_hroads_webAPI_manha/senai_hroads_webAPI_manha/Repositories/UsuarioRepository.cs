using senai_hroads_webAPI_manha.Contexts;
using senai_hroads_webAPI_manha.Domains;
using senai_hroads_webAPI_manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idUsuario, Usuario UsuarioAtualizada)
        {
            Usuario UsuarioBuscada = ctx.Usuarios.Find(idUsuario);

            if (UsuarioAtualizada.NomeJogador != null && UsuarioAtualizada.Email != null && UsuarioAtualizada.Senha != null)
            {

                UsuarioBuscada.NomeJogador = UsuarioAtualizada.NomeJogador;
                UsuarioBuscada.Email = UsuarioAtualizada.Email;
                UsuarioBuscada.Senha = UsuarioAtualizada.Senha;
            }

            ctx.Usuarios.Update(UsuarioBuscada);

            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int idUsuario)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == idUsuario);
        }

        public void Cadastrar(Usuario novaUsuario)
        {
            ctx.Usuarios.Update(novaUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int idUsuario)
        {
            Usuario UsuarioBuscada = ctx.Usuarios.Find(idUsuario);

            ctx.Usuarios.Remove(UsuarioBuscada);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }
        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.Email == email && e.Senha == senha);
        }
    }
}

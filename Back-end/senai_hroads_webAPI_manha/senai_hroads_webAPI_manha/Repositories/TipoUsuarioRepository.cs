using senai_hroads_webAPI_manha.Contexts;
using senai_hroads_webAPI_manha.Domains;
using senai_hroads_webAPI_manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizada)
        {
            TipoUsuario TipoUsuarioBuscada = ctx.TipoUsuarios.Find(idTipoUsuario);

            if (TipoUsuarioAtualizada.IdUsuario != null && TipoUsuarioAtualizada.Titulo != null)
            {

                TipoUsuarioBuscada.IdUsuario = TipoUsuarioAtualizada.IdUsuario;
                TipoUsuarioBuscada.Titulo = TipoUsuarioAtualizada.Titulo;
            }

            ctx.TipoUsuarios.Update(TipoUsuarioBuscada);

            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int idTipoUsuario)
        {
            return ctx.TipoUsuarios.FirstOrDefault(e => e.IdTipoUsuario == idTipoUsuario);
        }

        public void Cadastrar(TipoUsuario novaTipoUsuario)
        {
            ctx.TipoUsuarios.Update(novaTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            TipoUsuario TipoUsuarioBuscada = ctx.TipoUsuarios.Find(idTipoUsuario);

            ctx.TipoUsuarios.Remove(TipoUsuarioBuscada);

            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}


using senai_hroads_webAPI_manha.Contexts;
using senai_hroads_webAPI_manha.Domains;
using senai_hroads_webAPI_manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idPersonagem, Personagem PersonagemAtualizada)
        {
            Personagem PersonagemBuscada = ctx.Personagems.Find(idPersonagem);
            if (PersonagemAtualizada.IdClasse != null && PersonagemAtualizada.Nome != null && PersonagemAtualizada.CapMana != null && PersonagemAtualizada.CapVida != null && PersonagemAtualizada.DataAtt != null && PersonagemAtualizada.DataCriacao != null)
            {
                PersonagemBuscada.IdClasse = PersonagemAtualizada.IdClasse;
                PersonagemBuscada.Nome = PersonagemAtualizada.Nome;
                PersonagemBuscada.CapMana = PersonagemAtualizada.CapMana;
                PersonagemBuscada.CapVida = PersonagemAtualizada.CapVida;
                PersonagemBuscada.DataAtt = PersonagemAtualizada.DataAtt;
                PersonagemBuscada.DataCriacao = PersonagemAtualizada.DataCriacao;
            }

            ctx.Personagems.Update(PersonagemBuscada);

            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int idPersonagem)
        {
            return ctx.Personagems.FirstOrDefault(e => e.IdPersonagem == idPersonagem);
        }

        public void Cadastrar(Personagem novaPersonagem)
        {
            ctx.Personagems.Update(novaPersonagem);
            ctx.SaveChanges();
        }

        public void Deletar(int idPersonagem)
        {
            Personagem PersonagemBuscada = ctx.Personagems.Find(idPersonagem);

            ctx.Personagems.Remove(PersonagemBuscada);

            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }
    }
}

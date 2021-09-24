using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        projetoContext ctx = new projetoContext();
        public void Atualizar(int id, PersonagemDomain PersonagemAtualizada)
        {
            PersonagemDomain PersonagemBuscada = Buscar(id);

            if (PersonagemBuscada.DescricaoPersonagem != null)
            {
                PersonagemBuscada.PersonagemPersonagem = PersonagemAtualizada.DescricaoPersonagem;
            }
            else if (PersonagemBuscada.NomePersonagem != null)
            {
                PersonagemBuscada.NomePersonagem = PersonagemAtualizada.NomePersonagem;
            }
            else if (PersonagemBuscada.Mana != 0)
            {
                PersonagemBuscada.Mana = PersonagemAtualizada.Mana;
            }
            else if (PersonagemBuscada.Vida != 0)
            {
                PersonagemBuscada.Vida = PersonagemAtualizada.Vida;
            }

            ctx.Personagems.Update(PersonagemBuscada);

            ctx.SaveChanges();
        }

        //Buscar
        public PersonagemDomain Buscar(int id)
        {
            return ctx.Personagems.FirstOrDefault(C => C.IdPersonagem == id);
        }

        public void Cadastrar(PersonagemDomain PersonagemNova)
        {
            ctx.Personagems.Add(PersonagemNova);

            ctx.SaveChanges();
        }

        //Delete
        public void Deletar(int id)
        {
            PersonagemDomain PersonagemBuscada = Buscar(id);

            ctx.Personagems.Remove(PersonagemBuscada);

            ctx.SaveChanges();
        }
        //Listar Personagem
        public List<PersonagemDomain> Listar()
        {
            return ctx.Personagems.Include(C => C.Personagens).Include(C => C.StatusPersonagens).ToList();
        }
    }
}
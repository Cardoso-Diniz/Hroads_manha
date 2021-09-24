using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        projetoContext ctx = new projetoContext();
        public void Atualizar(int id, ClasseDomain ClasseAtualizada)
        {
            ClasseDomain ClasseBuscada = Buscar(id);

            if (ClasseBuscada.idClasse != null)
            {
                ClasseBuscada.idClasse = ClasseAtualizada.idClasse;
            }
            else if (ClasseBuscada.NomeClasse != null)
            {
                ClasseBuscada.NomeClasse = ClasseAtualizada.NomeClasse;
            }

            ctx.Classes.Update(ClasseBuscada);

            ctx.SaveChanges();
        }

        //Buscar
        public ClasseDomain Buscar(int id)
        {
            return ctx.Classes.FirstOrDefault(C => C.IdClasse == id);
        }

        public void Cadastrar(ClasseDomain ClasseNova)
        {
            ctx.Classes.Add(ClasseNova);

            ctx.SaveChanges();
        }

        //Delete
        public void Deletar(int id)
        {
            ClasseDomain ClasseBuscada = Buscar(id);

            ctx.Classes.Remove(ClasseBuscada);

            ctx.SaveChanges();
        }
        //Listar Classe
        public List<ClasseDomain> Listar()
        {
            return ctx.Classes.Include(C => C.Personagens).Include(C => C.StatusPersonagens).ToList();
        }
    }
}
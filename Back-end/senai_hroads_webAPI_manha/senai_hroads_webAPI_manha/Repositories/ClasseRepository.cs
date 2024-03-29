﻿using senai_hroads_webAPI_manha.Contexts;
using senai_hroads_webAPI_manha.Domains;
using senai_hroads_webAPI_manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI_manha.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idClasse, Classe classeAtualizada)
        {
            Classe classeBuscada = ctx.Classes.Find(idClasse);

            if (classeAtualizada.NomeClasse != null)
            {
                classeBuscada.NomeClasse = classeAtualizada.NomeClasse;
            }

            ctx.Classes.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Classe BuscarPorId(int idClasse)
        {
            return ctx.Classes.FirstOrDefault(e => e.IdClasse == idClasse);
        }

        public void Cadastrar(Classe novaClasse)
        {
            ctx.Classes.Update(novaClasse);
            ctx.SaveChanges();
        }

        public void Deletar(int idClasse)
        {
            Classe classeBuscada = ctx.Classes.Find(idClasse);

            ctx.Classes.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}

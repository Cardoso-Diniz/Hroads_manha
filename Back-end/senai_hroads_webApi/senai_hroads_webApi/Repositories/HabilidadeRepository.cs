using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Repositories
{
    public class HabilidadeRepository : HabilidadeDomain
    {
        projetoContext ctx = new projetoContext();
        public void Atualizar(int id, HabilidadeDomain HabilidadeAtualizada)
        {
            HabilidadeDomain HabilidadeBuscada = Buscar(id);

            if HabilidadeBuscada.nomeHabilidade == null)
            {
            else if (HabilidadeBuscada.idHabilidade != null)
                {
                    HabilidadeBuscada.idHabilidade = HabilidadeAtualizada.idHabilidade;
                }
                else if (HabilidadeBuscada.idTipoHabilidade != null)
                {
                    HabilidadeBuscada.idTipoHabilidade = HabilidadeAtualizada.idTipoHabilidade;
                }
                else if (HabilidadeBuscada.nomeHabilidade != null)
                {
                    HabilidadeBuscada.nomeHabilidade = HabilidadeAtualizada.nomeHabilidade;
                }
                else if (HabilidadeBuscada.DescricaoHabilidade != null)
                {
                    HabilidadeBuscada.DescricaoHabilidade = HabilidadeAtualizada.DescricaoHabilidade;
                }

                ctx.Classes.Update(HabilidadeBuscada);

                ctx.SaveChanges();
            }
        }
    }
}

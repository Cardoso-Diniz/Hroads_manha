using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Domains
{
    public class HabilidadeDomain
    {
        public int idHabilidade { get; set; }
        public int idTipoHabilidade { get; set; }
        public string nomeHabilidade { get; set; }
        public object DescricaoHabilidade { get; set; }
    }
}

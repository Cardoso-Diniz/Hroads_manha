using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Domains
{
    public class PersonagemDomain
    {
        public int idPersonagem { get; set; }
        public int idClasse { get; set; }
        public string nome { get; set; }
        public string capMana { get; set; }
        public string capVida { get; set; }
        public DateTime dataAtt { get; set; }
        public DateTime dataCriacao { get; set; }
        public object PersonagemPersonagem { get; internal set; }
        public object DescricaoPersonagem { get; internal set; }
        public object NomePersonagem { get; internal set; }
        public int Mana { get; internal set; }
        public object Vida { get; internal set; }
    }
}

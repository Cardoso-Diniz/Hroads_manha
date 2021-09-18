using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Domains
{
    public class UsuarioDomain
    {
        public int idUsuario { get; set; }
        public string nomeJogador { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}

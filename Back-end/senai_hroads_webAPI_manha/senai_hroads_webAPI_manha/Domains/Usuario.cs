using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webAPI_manha.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            TipoUsuarios = new HashSet<TipoUsuario>();
        }

        public int IdUsuario { get; set; }
        public string NomeJogador { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<TipoUsuario> TipoUsuarios { get; set; }
    }
}

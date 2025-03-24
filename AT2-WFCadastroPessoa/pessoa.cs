using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class pessoa
    {
     public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? TipoTelefone { get; set; }

        public bool? PossuiFilhos { get; set; }

        public string? Codigo { get; set; }

        public static List<pessoa> ListaPessoa = new List<pessoa>();
    }
}

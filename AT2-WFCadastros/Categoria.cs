using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public class Categoria
    {
        public Categoria(int codigo, string? nome, string? descricao, string? status, DateTime datadeCadastro)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Status = status;
            DatadeCadastro = datadeCadastro;
        }

        public Categoria() { }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Status { get; set; }
        public DateTime DatadeCadastro { get; set; }

        public static List<Categoria> ListadeCadastro = new List<Categoria>();
    
    }
}

    


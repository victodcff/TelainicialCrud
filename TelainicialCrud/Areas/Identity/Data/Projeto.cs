using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TelainicialCrud.Areas.Identity.Data;

namespace TelainicialCrud.Areas.Identity.Data
{
    public class Projeto
    {
        [Key]
        public int IdProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int QuantPessoas { get; set; }
    }
    }
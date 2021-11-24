using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidariedade.Models
{
    public class Ocorrencia
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public Cidade Cidade { get; set; } 
    }
}

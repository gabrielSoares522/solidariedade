﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidariedade.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get;set; }
        public string Sigla { get; set; }
        public List<Cidade> Cidades { get; set; }
    }
}

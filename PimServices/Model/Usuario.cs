﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Ativo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }       
    }
}
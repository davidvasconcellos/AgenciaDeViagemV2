﻿using DigitalViagem.Enum;
using System;

namespace DigitalViagem.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public Situacao Situacao { get; set; }
    }
}

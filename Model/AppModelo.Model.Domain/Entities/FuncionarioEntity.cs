﻿using System;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Sexo { get; set; }
        public string Cpf { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string TelefoneContato { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }

    }
}

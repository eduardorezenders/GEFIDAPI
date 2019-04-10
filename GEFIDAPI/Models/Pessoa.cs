using System;

namespace GEFIDAPI.Models
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public int IdCliente { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime? DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public string IdGenero { get; set; }
        public string Cpf { get; set; }
        public string Arquivo { get; set; }
        public string Facebook { get; set; }
        public string Whatsapp { get; set; }
    }
}
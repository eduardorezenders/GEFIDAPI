using System;

namespace GEFIDAPI.Models
{
    public class Pessoa
    {
        public int idPessoa { get; set; }
        public int idCliente { get; set; }
        public string nomeCompleto { get; set; }
        public DateTime? dataNascimento { get; set; }
        public bool ativo { get; set; }
        public string idGenero { get; set; }
        public string cpf { get; set; }
        public string arquivo { get; set; }
        public string facebook { get; set; }
        public string whatsapp { get; set; }
    }
}
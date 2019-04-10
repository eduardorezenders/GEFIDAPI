using System;

namespace GEFIDAPI.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeTitular { get; set; }
        public string Login { get; set; }
        public DateTime DtCadastro { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public bool Ativo { get; set; }
        public string Chaveapi { get; set; }
        public string Facebook { get; set; }
        public string Sfacebook { get; set; }
        public string Whatsapp { get; set; }
        public string Swhatsapp { get; set; }
    }
}
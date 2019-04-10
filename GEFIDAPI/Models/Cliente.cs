using System;

namespace GEFIDAPI.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string razaoSocial { get; set; }
        public string nomeTitular { get; set; }
        public string login { get; set; }
        public DateTime dtCadastro { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public bool ativo { get; set; }
        public string chaveapi { get; set; }
        public string facebook { get; set; }
        public string sfacebook { get; set; }
        public string whatsapp { get; set; }
        public string swhatsapp { get; set; }
    }
}
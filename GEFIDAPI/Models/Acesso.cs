using System.ComponentModel.DataAnnotations;

namespace GEFIDAPI.Models
{
    public class Acesso
    {
        [Key]
        public int IdLogin { get; set; }
        public int IdGrupo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int IdCliente { get; set; }
    }
}
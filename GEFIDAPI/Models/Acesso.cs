using System.ComponentModel.DataAnnotations;

namespace GEFIDAPI.Models
{
    public class Acesso
    {
        [Key]
        public int idLogin { get; set; }
        public int idGrupo { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idCliente { get; set; }
    }
}
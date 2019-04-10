using System.Collections.Generic;

namespace GEFIDAPI.Models
{
    interface IPessoaRepositorio
    {
        IEnumerable<Pessoa> All { get; }
        Pessoa Find(int id);
        Pessoa Insert(Pessoa item);
        void Update(Pessoa item);
        void Delete(int id);
    }
}

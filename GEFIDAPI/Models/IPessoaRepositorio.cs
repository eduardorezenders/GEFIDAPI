using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEFIDAPI.Models
{
    interface IClienteRepositorio
    {
        IEnumerable<Cliente> All { get; }
        Cliente Find(int id);
        Cliente Insert(Cliente item);
        void Update(Cliente item);
        void Delete(int id);
    }
}

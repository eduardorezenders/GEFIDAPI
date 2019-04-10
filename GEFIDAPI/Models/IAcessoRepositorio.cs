using System.Collections.Generic;

namespace GEFIDAPI.Models
{
    public interface IAcessoRepositorio
    {
        IEnumerable<Acesso> All { get; }
        Acesso Find(string id);
        Acesso Insert(Acesso item);
        bool Update(Acesso item);
        void Delete(int id);
    }
}

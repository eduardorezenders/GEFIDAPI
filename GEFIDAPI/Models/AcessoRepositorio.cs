using System;
using System.Collections.Generic;

namespace GEFIDAPI.Models
{
    public class AcessoRepositorio : IAcessoRepositorio
    {
        private List<Acesso> _acessos;

        public AcessoRepositorio()
        {
            InicializaDados();
        }

        private void InicializaDados()
        {
            _acessos = DalHelper.GetAcessos();
        }

        public IEnumerable<Acesso> All
        {
            get { return _acessos; }
        }

        public Acesso Find(string id)
        {
            return DalHelper.GetAcesso(id);
        }

        public Acesso Insert(Acesso item)
        {
            if (item != null)
            {
                DalHelper.InsertAcesso(item);
            }
            return item;
        }

        public bool Update(Acesso acesso)
        {
            bool addResult = false;
            if (acesso != null)
            {
                DalHelper.UpdateAcesso(acesso);
                addResult = true;
            }
            return addResult;
        }

        public void Delete(int id)
        {
            DalHelper.DeleteAcesso(id);
        }
    }
}
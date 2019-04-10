using GEFIDAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace GEFIDAPI.Controllers
{
    public class AcessoController : ApiController
    {
        private readonly IAcessoRepositorio _acessoRepositorio;

        public AcessoController()
        {
            AcessoRepositorio _acessoRepositorio = new AcessoRepositorio();
        }

        [HttpGet]
        public IEnumerable<Acesso> List()
        {
            return _acessoRepositorio.All;
        }

        public Acesso GetAcesso(string id)
        {
            Acesso acesso = _acessoRepositorio.Find(id);
            if (acesso == null)
            {
                acesso = null;
            }
            return acesso;
        }

        [HttpPost()]
        public Acesso Post([FromBody]Acesso acesso)
        {
            _acessoRepositorio.Insert(acesso);
            return acesso;
        }

        [HttpPut()]
        public bool Put(int id, [FromBody]Acesso acesso)
        {
            acesso.IdLogin = id;
            bool Result = _acessoRepositorio.Update(acesso);
            return Result;
        }

        [HttpDelete()]
        public void Delete(int id)
        {
            _acessoRepositorio.Delete(id);
        }
    }
}

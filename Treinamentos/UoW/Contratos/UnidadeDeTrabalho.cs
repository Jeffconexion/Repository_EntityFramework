using Infraestrutura.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UoW.Contratos
{
    /*
     * É possível acrescentar outras coisas relacionado 
     * a transação de banco.
     */
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {

        private readonly AppDataContext _banco;

        public UnidadeDeTrabalho(AppDataContext banco)
        {
            _banco = banco;
        }

        public void Commit()
        {
            _banco.SaveChanges();
        }

        public void Dispose()
        {
            _banco.Dispose();
        }
    }
}

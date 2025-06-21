using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ConsultaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ConsultaService.svc or ConsultaService.svc.cs at the Solution Explorer and start debugging.
    public class ConsultaService : IConsulta
    {
        private ConsultaRep rep = new ConsultaRep();


        public void Cadastrar(Consulta obj)
        {
            rep.Cadastrar(obj);
        }

        public Consulta Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public IQueryable<Consulta> Buscar(Dentista dentista)
        {
            return rep.Buscar(dentista);
        }

        public List<Consulta> Buscar(Dentista dentista,DateTime data)
        {
            return rep.Buscar(dentista, data);
        }


        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Consulta objNovo)
        {
            rep.Editar(objNovo);
        }
    }
}

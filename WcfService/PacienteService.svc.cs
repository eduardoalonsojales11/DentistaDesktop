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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PacienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PacienteService.svc or PacienteService.svc.cs at the Solution Explorer and start debugging.
    public class PacienteService : IPaciente
    {
        private PacienteRep rep = new PacienteRep();
                   
        
        public void Cadastrar(Paciente obj)
        {
            rep.Cadastrar(obj);
        }

        public Paciente Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public List<Paciente> Listar()
        {
            return rep.Listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Paciente objNovo)
        {
            rep.Editar(objNovo);
        }
    }
    
}
    


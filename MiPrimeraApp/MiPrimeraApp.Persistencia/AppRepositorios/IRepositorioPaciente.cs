using System.Collections.Generic;
using MiPrimeraApp.Dominio;

namespace MiPrimeraApp.Persistencia
{
    public interface IRepositorioPaciente
    {
         IEnumerable<Paciente> GetAllPaciente(); //Listar los pacientes
         Paciente AddPaciente(Paciente paciente); //Crear paciente
         Paciente GetPaciente(int idPaciente); //Consultar paciente desde un Id
    }
}
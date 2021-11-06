using System.Collections.Generic;
using System.Linq;
using MiPrimeraApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MiPrimeraApp.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext();

    //Método para crear paciente
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges(); //Almacena los cambios en la base de datos
            return pacienteAdicionado.Entity;
        }
    
    //Método para generar la lista de pacientes
    IEnumerable<Paciente> IRepositorioPaciente.GetAllPaciente()
    {
        return _appContext.Pacientes;
    }

    //Método para buscar un paciente a partir de un Id
    Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
    {
        return _appContext.Pacientes.Find(idPaciente);
    }


    }
}
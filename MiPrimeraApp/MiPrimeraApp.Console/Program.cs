using System;
using System.Collections.Generic;
using MiPrimeraApp.Dominio;
using MiPrimeraApp.Persistencia;

namespace MiPrimeraApp.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();

        static void Main(string[] args)
        {
            Console.WriteLine("...");
            //AddPaciente();
            //BuscarPaciente(1);
            //MostrarPaciente();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Luz Adriana",
                Apellidos = "Gallego Alzate",
                NumeroTelefono = "6068779671",
                Genero = Genero.Femenino,
                Direccion = "Calle 58F N 7A 05",
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1996,11,25)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPaciente()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPaciente();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
            }
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
        }


    }
}
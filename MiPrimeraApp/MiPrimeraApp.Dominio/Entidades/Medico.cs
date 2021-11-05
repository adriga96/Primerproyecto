namespace MiPrimeraApp.Dominio
{
    ///<summary> Class <c> Medico </c>
    ///Modela un médico del equipo
    ///</summary>
    public class Medico : Persona
    {
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
        public string Registro {get; set;}
    }
}
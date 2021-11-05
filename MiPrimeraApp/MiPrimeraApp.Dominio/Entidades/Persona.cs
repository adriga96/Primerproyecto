namespace MiPrimeraApp.Dominio
{
    public class Persona
    {
        //Identificador único de cada persona
        //Métodos Get y set
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string NumeroTelefono {get; set;}
        public Genero Genero {get; set;}
    }
}
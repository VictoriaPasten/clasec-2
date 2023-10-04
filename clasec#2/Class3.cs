using System;

namespace POOVidejuegos
{
    public class Asistente:Personas
    {
        
        public string Afp { get; set; }
        public double Porcentaje { get; set; }
     
        public Asistente() { }
        public Asistente(string nombre, string rut,string afp, double porcentaje)
            :base(nombre, rut)
        {
            Afp = afp;
            Porcentaje = porcentaje;
        }
    }
}

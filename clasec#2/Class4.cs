using System;

namespace POOVidejuegos
{
    public class Personas
    {
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public Personas() { }

        public Personas(string nombre, string rut)
        {
            Nombre = nombre;
            Rut = rut;
        }
        public override string ToString()
        {
            return "\n R.U.T:" + Rut + "Nombre:" + Nombre;
        }
    }
}



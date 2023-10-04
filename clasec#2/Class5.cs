using System;

namespace POOVidejuegos
{
    public  class Evento
    {
        public int Código {  get; set; }
        public string Nombre {  get; set; }
        List<Personas> Personas;

        public Evento()
        {
            Personas = new List<Personas>();
        }
        public Evento(int código, string nombre)
        {
            Código = código;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return "Código:"+Código;
        }
    }
}

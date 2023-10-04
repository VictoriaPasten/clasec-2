using System;


namespace POOVidejuegos
{
    public class Jugador : Personas
    {

        public string Juego { get; set; }
        public string NickName { get; set; }
        public Jugador() { }

        public Jugador(string nombre, string rut, string juego, string nickname)
            : base(nombre, rut)
        {
            Juego = juego;
            NickName = nickname;
            
        }
    }

}

using System;

namespace Lab14_Ejer2_Repaso
{
    public class Cancion
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }

        public Cancion()
        {
            Nombre = string.Empty;
            Artista = string.Empty;
            Duracion = TimeSpan.Zero;
        }
    }
}

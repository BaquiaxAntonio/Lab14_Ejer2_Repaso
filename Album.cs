using System;
using System.Collections.Generic;

namespace Lab14_Ejer2_Repaso
{
    public class Album
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public List<Cancion> Canciones { get; set; } 
        public DateTime FechaPublicacion { get; set; }

        public Album()
        {
            Titulo = string.Empty;
            Artista = string.Empty;
            Canciones = new List<Cancion>();
            FechaPublicacion = DateTime.Now;
        }
    }
}

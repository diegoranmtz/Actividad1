using System;

namespace Actividad1
{
    class Tramite
    {

        public Tramite() { }
        public Tramite(Perro perro, Usuario usuario) { realizarAdopcion(perro, usuario); }

        public int folio { get; set; }
        public void realizarAdopcion(Perro perro, Usuario usuario)
        {
            Console.WriteLine("Estimado: " + usuario.nombre + "\nHaz adoptado a " + perro.nombre);
            Console.WriteLine("Saludos.");
            Console.ReadLine();
        }
    }
}
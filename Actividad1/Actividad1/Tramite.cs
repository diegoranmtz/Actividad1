using System;

namespace Actividad1
{
    class Tramite
    {

        public int folio { get; set; }
        private Perro perro { get; set; }
        private Usuario usuario { get; set; }
     
        public Tramite() { }
        public Tramite(Perro perro, Usuario usuario) {
            this.perro = perro;
            this.usuario = usuario;
            
            realizarAdopcion(perro, usuario); 
        }
        
        public void realizarAdopcion(Perro perro, Usuario usuario)
        {
            Console.WriteLine("Estimado: " + usuario.nombre + "\nHaz adoptado a " + perro.nombre);
            Console.WriteLine("Con la cantidad de : " + usuario.dinero.cantidad + "Pesos en " + perro.sucursal.direccion);
            
            Console.WriteLine("Saludos.");
            Console.ReadLine();
        }
    }
}

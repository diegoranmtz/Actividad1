using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Perro perro = new Perro();

            Console.WriteLine("¿Cúal es tu nombre?");
            usuario.nombre = Console.ReadLine();
            Console.WriteLine("¿Y el del perrito?");
            perro.nombre = Console.ReadLine();
            Console.WriteLine("¿cuanto dinero es?");
            usuario.dinero.cantidad = Console.ReadLine();
            
            Console.WriteLine("¿que tipo de dinero es?");
            usuario.dinero.tipo = Console.ReadLine();
            
            
            Console.WriteLine("¿donde está la sucursal?");
            perro.sucursal.direccion = Console.ReadLine();
            Tramite tramite = new Tramite(perro, usuario);
        }
    }
}

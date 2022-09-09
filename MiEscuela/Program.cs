using System;

namespace MiEscuela
{
    class MiClasePrueba
    {
        protected int pruebaA;
    }
    class Program : MiClasePrueba
    {
        public static void ImprimirMensajeEnPantalla( string mensaje)
        {
            Console.WriteLine("Respuesta del sistema: ");
            Console.WriteLine(mensaje);
        }
        /*public static void ImprimirMensajePrueba()
        {
            Console.WriteLine("Mensaje de prueba");
        }*/
        static void Main(string[] args)
        {
            Console.Title = "Sistema de administracion escolar";
            Profesor prof = new Profesor();
            string resp = prof.Checar();
            ImprimirMensajeEnPantalla(resp);
            
            Console.WriteLine("Preciona 0 para mostrar mensaje de prueba");
            int x = Int32.Parse(Console.ReadLine());
            if(x == 0)
            {
                ImprimirMensajeEnPantalla("Mensaje de prueba");
            }
            Console.ReadKey();
            //Profesor nuevoProfesor = new Profesor();
            //nuevoProfesor.id = 0;

            /*Program prueba = new Program();
            prueba.pruebaA = 1;*/
        }
    }
}

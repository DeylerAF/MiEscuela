using System;

namespace MiEscuela
{
    class MiClasePrueba
    {
        protected int pruebaA;
    }
    class Program : MiClasePrueba
    {
        public static void ImprimirMensajeEnPantalla( string mensaje, bool guardar = false)
        {
            Console.WriteLine("Respuesta del sistema: ");
            Console.WriteLine(mensaje);
            if (guardar)
            {
                //Guardar en BD el mensaje
            }
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

            string nombreEstudiante = "Pepito";
            string gradoGrupo = "5A";
            Estudiante estudiante = new Estudiante(nombreEstudiante, gradoGrupo);
            estudiante = null;
            
            // Materia miMateria = new Materia();
            //Program miProgram = new Program();

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

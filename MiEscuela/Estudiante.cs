using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    class Estudiante
    {
        #region Atributos
        private int id;
        private string matr;
        string nombre;
        string gradoGrupo;
        bool estatus;
        #endregion

        #region Propiedades
        public int Id { get; }
        public string Matr { get; }
        public string Nombre { get; set; }
        public string GradoGrupo { get; set; }
        public bool Estatus { get; set; }
        #endregion

        #region Metodos
        public string Registrar()
        {
            // registro en la BD
            string resp = "Alumno Registrado";
            return resp;
        }

        public string DarDeBaja()
        {
            this.Estatus = false;
            //Editar en BD el registro en
            //EditarRegistroEnBD()
            string respuesta = "Alumno dado de baja";
            return respuesta;
        }
        #endregion
    }
}

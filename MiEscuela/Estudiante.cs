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

        public string DarDeBaja(string motivo = "")
        {
            this.Estatus = false;
            //Editar en BD el registro, agregar motivo
            string respuesta = "";
            if (motivo != "")
            {
                respuesta = "Alumno dado de baja. Motivo " + motivo;
            }
            else
            {
                respuesta = "Alumno dado de baja";
            }

            return respuesta;
        }

        public void DarDeBaja(string cveUsuario, string pwd, string motivo)
        {
            //Consultar que el usuario cuente con los permisos requeridos
            //VerificarUsuario(cveUsuario, pwd)
            //Si usuario verificado :
            //Eliminar el registro del estudiante
            //Guardar el movimiento en un log
        }
        #endregion

        #region Constructor
        public Estudiante(string nombre, string gradoGrupo)
        {
            this.nombre = nombre;
            GradoGrupo = gradoGrupo;
        }
        public Estudiante(bool estatus)
        {
            Estatus = estatus;
            Nombre = "";
        }
        #endregion
    }


}

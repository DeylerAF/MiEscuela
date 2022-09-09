using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    public enum FrecuenciaPago
    {
        Quincenal,
        Mensual,
        Bimestral
    }
    public class Empleado
    {
        #region Atributos
        private int id;
        private string nombre;
        private bool activo;
        private int edad;
        private string nac;
        private decimal pago;
        #endregion

        #region Propiedades
        public int Id
        {
            get
            {
                return id;
            }

        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public bool Activo { get; set; }
        public int Edad { get; set; }
        public string Nac { get; set; }
        public string Pago { get; }
        #endregion

        #region Metodos
        public void CalcularPAgo()
        {

        }
        #endregion

        #region Constructor
        public Empleado()
        {
            this.Activo = true;
        }
        public Empleado(string Nombre)
        {
            Nombre = nombre;
            this.Activo = true;
        }
        #endregion
    }
}

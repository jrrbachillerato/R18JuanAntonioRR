using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace R18E01JuanAntonioRR
{
    public class Examen
    {
        // CONSTANTES
        private const string ASIGNATURA_DEFAULT = "Programación";
        private const float NOTA_DEFAULT = 0;

        // CAMPOS | MIEMBROS
        private string _asignatura;
        private float _nota;
        //private string _calificacion;

        // CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Examen()
        {
            _asignatura= ASIGNATURA_DEFAULT;
            _nota= NOTA_DEFAULT;
        }
        /// <summary>
        /// Instanciación del objeto Examen
        /// </summary>
        /// <param name="asignatura"></param>
        public Examen(string asignatura)
        {
            //_asignatura=asignatura; // ¡ERROR! Si hacemos esto se pierde la protección del campo al poder introducir una asignatura desde fuera sin validar
            Asignatura = asignatura;
            _nota = NOTA_DEFAULT;
        }
        /// <summary>
        /// Instanciación del objeto Examen
        /// </summary>
        /// <param name="asignatura"></param>
        /// <param name="nota"></param>
        public Examen(string asignatura, float nota)
        {
            Asignatura= asignatura;
            Nota = nota;
        }
        // PROPIEDADES
        public string Asignatura
        {
            get
            {
                return _asignatura;
            }
            set
            {
                ValidarAsignatura(value);
                _asignatura=value;
            }
        }
        public float Nota
        {
            get
            {
                return _nota;
            }
            set
            {
                ValidarNota(value);
                _nota=value;
            }
        }
        public string Calificacion
        {
            get // Solo lectura
            {
                return CalcularCalificacion(Nota);
            }
        }

        // MÉTODOS PÚBLICOS Y PRIVADOS
        private void ValidarAsignatura(string asignatura)
        {
            // TODO:Falta implementar el método ValidarAsignatura

            // CONSTANTES

            // VARIABLES

            // INICIALIZACIÓN

            // ENTRADA

            // PROCESO 

            // SALIDA

        }
        private void ValidarNota(float value)
        {
            // TODO:Falta implementar el método ValidarNota

            // CONSTANTES

            // VARIABLES

            // INICIALIZACIÓN

            // ENTRADA

            // PROCESO 

            // SALIDA
        }
        private string CalcularCalificacion(float nota)
        {

            // TODO:Falta implementar el método CalcularCalificacion

            // CONSTANTES

            // VARIABLES

            // INICIALIZACIÓN

            // ENTRADA

            // PROCESO 

            // SALIDA
            throw new NotImplementedException();
        }



    }
}

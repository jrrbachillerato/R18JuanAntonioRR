using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R18E02JuanAntonioRR
{
    public class Producto
    {
        // CONSTANTES
        private const float PRECIO_MIN = 50;        // POR DEFECTO SON PRIVADOS
        private const float PRECIO_MAX = 350;
        private const float IVA = 0.21F;

        private const string NOMBRE_DEFAULT = "Desconocido";
        private const float PRECIO_DEFAULT = 0;

        // CAMPOS | MIEMBROS
        private string _nombre;
        private float _precio;

        #region CONSTRUCTORES
        /// <summary>
        /// Instanciación del objeto Producto
        /// </summary>
        public Producto()
        {
            _nombre = NOMBRE_DEFAULT;
            _precio = PRECIO_DEFAULT;
        }
        public Producto(string nombre)
        {
            Nombre = nombre;
            _precio = PRECIO_DEFAULT;
        }
        public Producto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        #endregion

        #region PROPIEDADES
        public string Nombre
        {
            get
            {
                if (_nombre == NOMBRE_DEFAULT)
                {
                    throw new ArgumentException("El nombre del producto no ha sido inicializado");
                }
                return _nombre;
            }
            set
            {
                ValidarNombre(value);
                _nombre = value;
            }
        }
        public float Precio
        {
            get
            { 
                if(_precio == PRECIO_DEFAULT)
                {
                    throw new ArgumentException("El precio del producto no está establecido");
                }
                return _precio;
            }
            set
            {
                ValidarPrecio(value);
                _precio = value;
            }
        }
        public float PrecioIva
        {
            get
            {
                return CalcularPrecioIva();
            }
        }
        #endregion

        #region MÉTODOS PÚBLICOS

        #endregion

        #region MÉTODOS PRIVADOS
        private void ValidarNombre(string nombreProducto)
        {
            // TODO:Falta implementar método ValidarNombre
        }
        private void ValidarPrecio(float precio)
        {
            // TODO:Falta implementar método ValidarPrecio
        }
        private float CalcularPrecioIva()
        {
            return Precio * (1 + IVA);
        }
        #endregion
    }
}

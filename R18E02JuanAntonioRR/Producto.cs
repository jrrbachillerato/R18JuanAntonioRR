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

        // CAMPOS | MIEMBROS
        private string _nombre;
        private float _precio;

        #region CONSTRUCTORES

        #endregion

        #region PROPIEDADES
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public float Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public float PrecioIva
        {
            get
            {
                return 0;
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

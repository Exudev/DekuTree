using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolDeku
{
    public class Nodo
    {
        #region Plantilla
        private Object _datos;
        private Nodo _nodoIzquierdo;
        private Nodo _nodoDerecho;
        #endregion

        #region Construtores
        public Nodo()
        {
            _nodoDerecho = _nodoIzquierdo = null;
        }
        public Nodo(Object datos)
        {
            this._datos = datos;
            _nodoDerecho = _nodoIzquierdo = null;
        }
        public Nodo(Nodo derecho, Nodo izquierdo, Object Valor)
        {
            this._nodoDerecho = derecho;
            this._nodoIzquierdo = izquierdo;
            this._datos = Valor;

        }
        #endregion

        #region  Propiedades Nodo
        //Nodo Izquierdo
        public Nodo NodoIzquierd { get => _nodoIzquierdo; set => _nodoIzquierdo = value; }
        //Nodo Derecho
        public Nodo NodoDerecho { get => _nodoDerecho; set => _nodoDerecho = value; }
        //Datos
        public Object Datos { get =>_datos; set => _datos= value; }
        #endregion
    }
}


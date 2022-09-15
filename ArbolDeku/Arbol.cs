using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArbolDeku
{
    public class Arbol
    {
        #region Campos de clase
        //Insercion en cola 
        private string precedencia = "+-*/^";
        private string[] delimitadores = { "+", "-", "*", "/", "^" };
        private string[] operandosArray;
        private string[] operadoresArray;
        private Queue colaExpresion;

        //Creacion del arbol
        private string token;
        private string operadorTemp;
        private int i = 0;
        private Stack pilaOperadores;
        private Stack pilaOperandos;
        private Stack pilaDot;
        private Nodo raiz = null;
        public Nodo nodoDot { get; set; }
        //propiedades para recorridos
        public string cadenaPreorden { get; set; }
        public string cadenaInorden { get; set; }
        public string cadenaPostorden {get; set;}
        #endregion

        #region Constructores
        public Arbol()
        {
            pilaOperadores = new Stack();
            pilaOperandos = new Stack();
            pilaDot = new Stack();
            colaExpresion = new Queue();
        }
        #endregion

        #region  Insercion en cola
        public void InsertarEnCola(string expresion)
        {
            operandosArray = expresion.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);
            operadoresArray = expresion.Split(operandosArray, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; colaExpresion.Count < operandosArray.Length + (operadoresArray.Length - 1); i++)
            {
                colaExpresion.Enqueue(operandosArray[i]);
                colaExpresion.Enqueue(operadoresArray[i]);


            }
            colaExpresion.Enqueue(operandosArray[operandosArray.Length - 1]);

        }
        #endregion

        #region Arbol 
        public Nodo CrearArbol()
        {
            while (colaExpresion.Count != 0)
            {
                token = (string)colaExpresion.Dequeue();
                    if (precedencia.IndexOf(token) < 0)
                {
                    pilaOperandos.Push(new Nodo(token));
                    pilaDot.Push(new Nodo($"nodo{++i}[label=\"{token}\"]"));
                }
                    else
                {
                    if (pilaOperadores.Count != 0)

                    {
                        operadorTemp = (string)pilaOperadores.Peek();
                        while (pilaOperadores.Count!=0 && precedencia.IndexOf(operadorTemp) >=precedencia.IndexOf(token))

                        {
                            GuardaSubArbol();
                            if (pilaOperadores.Count != 0)
                            {
                                operadorTemp = (string)pilaOperadores.Peek();
                            }
                        }
                    }
                    pilaOperadores.Push(token);
                }
            }
            raiz = (Nodo)pilaOperandos.Peek();
            nodoDot = (Nodo)pilaDot.Peek();
            while (pilaOperadores.Count != 0)
            {
                GuardaSubArbol();
                raiz = (Nodo)pilaOperandos.Peek();
                nodoDot = (Nodo)pilaDot.Peek();
            }
            return raiz;
        }

        private void GuardaSubArbol()
        {
            Nodo derecho = (Nodo)pilaOperandos.Pop();
            Nodo izquierdo = (Nodo)pilaOperandos.Pop();
            pilaOperandos.Push(new Nodo(derecho, izquierdo, pilaOperadores.Peek()));

            Nodo derechoG = (Nodo)pilaDot.Pop();
            Nodo izquierdoG = (Nodo)pilaDot.Pop();
            pilaDot.Push(new Nodo(derechoG, izquierdoG, $"nodo{++i}[label=\"{pilaOperadores.Pop()}\"]"));

        }
        #endregion

        #region Recorridos 
        //PREORDEN 
        public string InsertaPre(Nodo arbol)
        {
            if (arbol != null )
            {
                cadenaPreorden += arbol.Datos + " ";
                InsertaPre(arbol.NodoIzquierd);
                InsertaPre(arbol.NodoDerecho);
            }
            return cadenaPreorden;
        }

        //INORDEN 
        public string InsertaIn(Nodo arbol)
        {
            if (arbol != null)
            {   
                InsertaIn(arbol.NodoIzquierd);
                cadenaInorden += arbol.Datos + " ";
                InsertaIn(arbol.NodoDerecho);
            }
            return cadenaInorden;
        }
        //POSTORDEN 
        public string InsertaPost(Nodo arbol)
        {
            if (arbol != null)
            {
               
                InsertaPost(arbol.NodoIzquierd);
                InsertaPost(arbol.NodoDerecho); 
                cadenaPostorden += arbol.Datos + " ";
            }
            return cadenaPostorden;
        }
        #endregion 

        public void Limpiar()
        {
            cadenaPreorden = "";
            cadenaInorden = "";
            cadenaPostorden = "";

        }
    }
}

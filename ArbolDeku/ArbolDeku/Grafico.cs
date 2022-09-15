using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace ArbolDeku
{
    public class Grafico
    {

        #region Campos de clase 
        private Nodo arbol;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private string command = @"/c Batch.bat";
        private int i, j;
        #endregion

            #region Constructores
           public Grafico(Nodo arbol)
        {
            this.arbol = arbol;
        }
        #endregion
        #region funciones para grafico
        public void DrawTree()
        {
            CreateFileDot();
            ExecuteDot();
        }

        private string CreateFileDot()
        {
            string cadenaDot = "";
            StartFileDot(arbol,ref cadenaDot);
            using (StreamWriter archivo = new StreamWriter(path + @"\Arbol.dot"))
            {
                archivo.WriteLine(cadenaDot);
                archivo.Close();
            }
            return cadenaDot;
        }

        private void StartFileDot(Nodo arbol, ref string cadenaDot)
        {
            if (arbol != null)
            {
                cadenaDot += "digraph Grafico {\nnode [style= bold, fillcolor = gray]; \n";
                Recorrido(arbol, ref cadenaDot);
                cadenaDot += "\n}";
            }
        }

        private void Recorrido(Nodo arbol, ref string cadenaDot)
        {
            if (arbol != null)
            {
                cadenaDot += $"{arbol.Datos}\n";
                if (arbol.NodoIzquierd != null)
           
                {
                    i = arbol.Datos.ToString().IndexOf("[");
                    j = arbol.NodoIzquierd.Datos.ToString().IndexOf("[");
                    cadenaDot += $"{arbol.Datos.ToString().Remove(i)}->{arbol.NodoIzquierd.Datos.ToString().Remove(j)};\n";
                }
                if(arbol.NodoDerecho != null)
                {
                    i = arbol.Datos.ToString().IndexOf("[");
                    j = arbol.NodoDerecho.Datos.ToString().IndexOf("[");
                    cadenaDot += $"{arbol.Datos.ToString().Remove(i)}->{arbol.NodoDerecho.Datos.ToString().Remove(j)};\n";
                }
                Recorrido(arbol.NodoIzquierd, ref cadenaDot);
                Recorrido(arbol.NodoDerecho, ref cadenaDot);
            }
        }

        private void ExecuteDot()

        {
            Directory.SetCurrentDirectory(path);
            using (Process proceso = new Process())
            {
                ProcessStartInfo Info = new ProcessStartInfo("cmd", command);
                Info.CreateNoWindow = true;
                proceso.StartInfo = Info;
                proceso.Start();
                proceso.WaitForExit();
                proceso.Close();
            }
        }
        #endregion



    }
}

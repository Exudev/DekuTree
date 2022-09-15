using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolDeku
{
    public partial class Form1 : Form
    {
        private Nodo raiz;
        private Arbol arbol;
        Grafico grafico;
        public Form1()
        {
            InitializeComponent();
            arbol = new Arbol();
        }

        private void btngraficar_Click(object sender, EventArgs e)
        {
            if (txtbox_graficar.Text != "")
            {
                arbol.InsertarEnCola(txtbox_graficar.Text);
                raiz = arbol.CrearArbol();
                arbol.Limpiar();
                lblPre.Text = arbol.InsertaPre(raiz);
                lbln.Text = arbol.InsertaIn(raiz);
                lblpost.Text = arbol.InsertaPost(raiz);
                grafico = new Grafico(arbol.nodoDot);
                grafico.DrawTree();
                ShowTree();
            }
            else
            {
                MessageBox.Show("Debes ingresar una expresion aritmetica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowTree()
        {
            if (File.Exists(@"C:\Users\pablo\Imagen.png"))
            {
                using (FileStream img = new FileStream(@"C:\Users\pablo\Imagen.png", FileMode.Open, FileAccess.Read))
                {
                    pbgrafica.Image = Bitmap.FromStream(img);
                }
                
            }
            else
            {
                MessageBox.Show("No se ha podido abrir el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pbgrafica.Refresh();
        }

        private void lblpreorden_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

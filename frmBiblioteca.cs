using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryPeraltaRoureTP1
{
    public partial class frmBiblioteca : Form
    {       
        StreamReader leer = new StreamReader("./LIBRO.txt", true);
        public String linea ;
        public String[,] campos = new string[20, 5];
        public int i = 0;
        char separador = Convert.ToChar(",");
        public int indiceRecorrido = 0;
        public int contador = 0;

        public frmBiblioteca()
        {
            InitializeComponent();
             
        }

        

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            string[] vecLibro = leer.ReadLine().Split(separador);
            while (!leer.EndOfStream)
            {
                if (i < 20)
                {
                    campos[i, 0] = vecLibro[0];
                    campos[i, 1] = vecLibro[1];
                    campos[i, 2] = vecLibro[2];
                    campos[i, 3] = vecLibro[3];
                    campos[i, 4] = vecLibro[4];

                   
                    NombreEditorial(i);
                    
                    NombreDistribuidora(i);
                    i++;

                }
            }
            leer.Close();


            lblCodigoMostrar.Text = campos[0, 0];
            lblLibroMostrar.Text = campos[0, 1];
            lblEditorialMostrar.Text = campos[0, 2];
            lblAutorMostar.Text = campos[0, 3];
            lblCodigoMostrar.Text = campos[0, 4];


            btnVolver.Enabled = false;

        }
        private void NombreEditorial(int iMatriz)
        {

            StreamReader LectorEditorial = new StreamReader("./EDITORIAL.txt");

            while (!LectorEditorial.EndOfStream)
            {
                
                string[] vecEditorial = LectorEditorial.ReadLine().Split(separador);

                if (vecEditorial[0] == campos[iMatriz, 2])
                {
                    campos[iMatriz, 2] = vecEditorial[1];
                }
            }
            LectorEditorial.Close();
        }
        private void NombreDistribuidora(int iMatriz)
        {
             
            StreamReader LectorDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");

            while (!LectorDistribuidora.EndOfStream)
            {
                string[] vecDistribuidora = LectorDistribuidora.ReadLine().Split(separador);

                if (vecDistribuidora[0] == campos[iMatriz, 4])
                {
                    campos[iMatriz, 4] = vecDistribuidora[1];
                }
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            contador++;

            lblCodigoMostrar.Text = campos[contador, 0];
            lblLibroMostrar.Text = campos[contador, 1];
            lblEditorialMostrar.Text = campos[contador, 2];
            lblAutorMostar.Text = campos[contador, 3];
            lblCodigoMostrar.Text = campos[contador, 4];

            btnVolver.Enabled = true;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            contador--;


            if (contador >= 0)
            {
                lblCodigoMostrar.Text = campos[contador, 0];
                lblLibroMostrar.Text = campos[contador, 1];
                lblEditorialMostrar.Text = campos[contador, 2];
                lblAutorMostar.Text = campos[contador, 3];
                lblCodigoMostrar.Text = campos[contador, 4];


            }
            else if (contador == 0)
            {
                btnVolver.Enabled = false;
            }

            if (contador < 20)
            {
                MessageBox.Show("Esos son todos");
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Abrir_archivo_BMP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtTextos.Clear();
            OpenFileBMP.ShowDialog();
            string Nombre = OpenFileBMP.FileName;
            string fileExt =System.IO.Path.GetExtension(OpenFileBMP.FileName);
            Bitmap picBMPorg;
            if (fileExt == ".bmp" || fileExt == ".Bmp")
            {
                FileInfo xFile = new FileInfo(Nombre);
                picBMPorg = new Bitmap(Nombre, true);
                picBMP.Image = Image.FromFile(Nombre);
                txtTextos.Text = "-------------------------------" + Environment.NewLine;
                txtTextos.Text += "Nombre : " + fileExt + Environment.NewLine;
                txtTextos.Text += "Direccion : " + Nombre + Environment.NewLine;
                txtTextos.Text += "Tamaño : " + xFile.Length + " Bytes. " + Environment.NewLine;
                txtTextos.Text += "Ancho : " + picBMPorg.Width + " Pixeles <---> Resolucion : " + picBMPorg.HorizontalResolution + Environment.NewLine;
                txtTextos.Text += "Alto : " + picBMPorg.Height + " Pixeles <---> Resolucion : " + picBMPorg.VerticalResolution + Environment.NewLine;
                txtTextos.Text += "-------------------------------" + Environment.NewLine;
            }
            else
            {
                txtTextos.Text = "Archivo de imagen no permitido solo .BMP";
            }


        }
    }
}

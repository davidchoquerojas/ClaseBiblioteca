using BIBLIOTECA.Datos;
using BIBLIOTECA.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            Biblioteca oBiblioteca = new Biblioteca
            {
                Direccion = txt_direccion.Text,
                Email = txt_mail.Text,
                IdBiblioteca = 0,
                NomBiblioteca = txt_nombre.Text,
                Telefono = txt_telefono.Text
            };

            int respuesta = new BibliotecaDatos().grabarBiblioteca(oBiblioteca);
            if (respuesta == 1) {
                MessageBox.Show("Biblioteca Grabado");
            }
            else
            {
                MessageBox.Show("Biblioteca no Grabado");
            }
        }
    }
}

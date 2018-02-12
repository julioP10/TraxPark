using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TraxPark.Windows
{
    public partial class Tar_TarifaGeneral : DevExpress.XtraEditors.XtraForm
    {
        public Tar_TarifaGeneral()
        {
            InitializeComponent();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtToleranciaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtToleranciaSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Limpiar() 
        {
            txtDescripcion.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            txtToleranciaEntrada.Text = string.Empty;
            txtToleranciaSalida.Text = string.Empty;
        }
        private void gcTarifaGeneral_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch 
            {
                Limpiar();
            }
        }

        private void sbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
       
    }
}
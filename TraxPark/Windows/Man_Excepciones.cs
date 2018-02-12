using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TraxPark.Srv_TraxPark;

namespace TraxPark.Windows
{
    public partial class Man_Excepciones : DevExpress.XtraEditors.XtraForm
    {
        public Man_Excepciones()
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

        private void Limpiar() 
        {
            txtDescripcion.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            ceEstado.Checked = false;
        }

        private void gcExcepciones_Click(object sender, EventArgs e)
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
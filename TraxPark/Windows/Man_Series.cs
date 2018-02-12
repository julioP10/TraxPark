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
    public partial class Man_Series : DevExpress.XtraEditors.XtraForm
    {
        public Man_Series()
        {
            InitializeComponent();
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorrelativo_KeyPress(object sender, KeyPressEventArgs e)
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
            txtCorrelativo.Text = string.Empty;
            txtSerie.Text = string.Empty;
            ceEstado.Checked = false;
        }

        private void gcSeries_Click(object sender, EventArgs e)
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
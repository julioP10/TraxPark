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
    public partial class Man_Equipos : DevExpress.XtraEditors.XtraForm
    {
        public Man_Equipos()
        {
            InitializeComponent();
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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
             txtIP.Text = string.Empty;
             ceEstado.Checked = false;
        }

        private void gcEquipos_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch {
                Limpiar();
            }
        }

        private void sbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Man_Equipos_Load(object sender, EventArgs e)
        {
            MessageBox.Show(":D");
        }

        
    }
}
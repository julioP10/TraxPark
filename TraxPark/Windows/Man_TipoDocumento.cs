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
    public partial class Man_TipoDocumento : DevExpress.XtraEditors.XtraForm
    {
        public Man_TipoDocumento()
        {
            InitializeComponent();
        }

        private void Limpiar() {
            // rddlTipoDocumento
            txtDescripcion.Text = string.Empty;
            ceEstado.Checked = false;
        }
        private void gcTipoDocumento_Click(object sender, EventArgs e)
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
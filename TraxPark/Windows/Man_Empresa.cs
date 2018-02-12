using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace TraxPark.Windows
{
    public partial class Man_Empresa : DevExpress.XtraEditors.XtraForm
    {
        private static Man_Empresa m_FormDefInstance;
        public static Man_Empresa DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Man_Empresa();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Man_Empresa()
        {
            InitializeComponent();
        }

        private void TxtRuc_Enter(object sender, EventArgs e)
        {
            TxtRuc.TextBoxElement.TextBoxItem.BackColor = Color.LightYellow;
        }

        private void TxtRuc_Leave(object sender, EventArgs e)
        {
            TxtRuc.TextBoxElement.TextBoxItem.BackColor = Color.White; 
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
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

        private void txtTiempoContratado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTiempoConsumido_KeyPress(object sender, KeyPressEventArgs e)
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
            TxtRuc.Text = String.Empty;
            txtRazonSocial.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            ceContratarTiempo.Checked = false;
            txtTiempoContratado.Text = String.Empty;
            txtTiempoConsumido.Text = string.Empty;
            /*
             rdtpFechaInicial
             rdtpFechaFinal
             */
        }
        private void gcEmpresa_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch 
            {
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        
        
        

        //private void gridControl1_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawLine(Pens.SteelBlue, new Point(e.ClipRectangle.X, e.ClipRectangle.Y), new Point(e.ClipRectangle.X, e.ClipRectangle.Height));
        //    e.Graphics.DrawLine(Pens.SteelBlue, new Point(e.ClipRectangle.X, e.ClipRectangle.Y), new Point(e.ClipRectangle.Width, e.ClipRectangle.Y));
        //    e.Graphics.DrawLine(Pens.SteelBlue, new Point(e.ClipRectangle.X, e.ClipRectangle.Height - 1), new Point(e.ClipRectangle.Width, e.ClipRectangle.Height - 1));
        //    e.Graphics.DrawLine(Pens.SteelBlue, new Point(e.ClipRectangle.Width - 2, e.ClipRectangle.Y), new Point(e.ClipRectangle.Width - 2, e.ClipRectangle.Height));
        //}

       

       
        
        
        
       
       

       

       
      

        

       
    }
}
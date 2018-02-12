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
    public partial class Man_Clientes : DevExpress.XtraEditors.XtraForm
    {
        private static Man_Clientes m_FormDefInstance;
        public static Man_Clientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)    
                    m_FormDefInstance = new Man_Clientes();
                    return m_FormDefInstance;  
            }
            set
            {
                m_FormDefInstance = value;         
            }
        }

        private DCGTEC Servicio;
        public Man_Clientes()
        {
            Servicio = new DCGTEC();
            InitializeComponent();
        }

        private void sbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar() 
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            rddlTarifa.SelectedValue = 0;
            ceEstado.Checked = false;
        }

        private void gcCliente_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {
                Limpiar();
            }
        }

        private void sbNuevo_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
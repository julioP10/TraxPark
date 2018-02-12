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
    public partial class Man_Usuarios : DevExpress.XtraEditors.XtraForm
    {
        private static Man_Usuarios m_FormDefInstance;
        public static Man_Usuarios DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Man_Usuarios();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Man_Usuarios()
        {
            InitializeComponent();
        }

        private void Man_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar() 
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtConfirmarContraseña.Text = string.Empty;
            //rddlTipoUsuario
            ceEstado.Checked = false;
        } 
        private void gcUsuario_Click(object sender, EventArgs e)
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
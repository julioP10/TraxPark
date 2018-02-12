using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TraxPark.Srv_TraxPark;
using System.Threading.Tasks;

namespace TraxPark.Windows
{
    public partial class Man_Configuracion : DevExpress.XtraEditors.XtraForm
    {
        private static Man_Configuracion m_FormDefInstance;
        public static Man_Configuracion DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Man_Configuracion();
                else m_FormDefInstance.BringToFront();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private DCGTEC Servicio;
        string IP;
        int LlenarComboCam = 0;
        
        public Man_Configuracion()
        {
            InitializeComponent();
            Servicio = new DCGTEC();
            IP = Program.ObtenerDireccionIP();
        }

        private void LlenarcbTarifaDef()
        {
            try
            {
                LlenarComboCam = 0;
                var Tar = Servicio.Traer_Tarifa(null, null, null, null, null, null, null, null, null, null, null, "1", null, null, "4");
                if (Tar.Length > 0)
                {
                    rddlTarDef.DataSource = Tar;
                    rddlTarDef.ValueMember = "Id";
                    rddlTarDef.DisplayMember = "Descripcion";
                }
                LlenarcbTarifaCam();
                LlenarComboCam = 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarcbTarifaCam()
        {
            try
            {
                var Tar = Servicio.Traer_Tarifa(rddlTarDef.SelectedValue.ToString(), null, null, null, null, null, null, null, null, null, null, "1", null, null, "5");
                if (Tar.Length > 0)
                {
                    rddlTarCam.DataSource = Tar;
                    rddlTarCam.ValueMember = "Id";
                    rddlTarCam.DisplayMember = "Descripcion";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarConfiguracion()
        {
            try
            {
                var Conf = Servicio.Traer_Configuracion(null, null, null, null, null, null, null, null, null, null, null, "4");
                if (Conf.Length > 0)
                {
                    lblID.Text = Conf[0].Id;
                    TxtRuc.Text = Conf[0].RUC;
                    txtRazonSocial.Text = Conf[0].RazonSocial;
                    txtDireccion.Text = Conf[0].Direccion;
                    txtSede.Text = Conf[0].Sede;
                    txtUbicacion.Text = Conf[0].Ubicacion;
                    txtCapacidad.Text = Conf[0].Capacidad;
                    rddlTarDef.SelectedValue = Conf[0].TarifaDefecto.ToString();
                    rddlTarCam.SelectedValue = Conf[0].TarifaCambio.ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Man_Configuracion_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarcbTarifaDef();
                LlenarConfiguracion();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbBuscarRUC_Click(object sender, EventArgs e)
        {
           
        }

        private void rddlTarDef_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LlenarComboCam == 1) LlenarcbTarifaCam();
        }

        private void sbAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRuc.Text.Trim().Equals(""))
                {
                    epError.SetError(TxtRuc, "Campo Obligatorio");
                    return;
                }
                else epError.SetError(TxtRuc, "");

                if (TxtRuc.TextLength < 11)
                {
                    epError.SetError(TxtRuc, "Dato Inválido");
                    return;
                }
                else epError.SetError(TxtRuc, "");

                if (txtRazonSocial.Text.Trim().Equals(""))
                {
                    epError.SetError(txtRazonSocial, "Campo Obligatorio");
                    return;
                }
                else epError.SetError(txtRazonSocial, "");

                if (txtDireccion.Text.Trim().Equals(""))
                {
                    epError.SetError(txtDireccion, "Campo Obligatorio");
                    return;
                }
                else epError.SetError(txtDireccion, "");

                if (txtSede.Text.Trim().Equals(""))
                {
                    epError.SetError(txtSede, "Campo Obligatorio");
                    return;
                }
                else epError.SetError(txtSede, "");

                if (txtUbicacion.Text.Trim().Equals(""))
                {
                    epError.SetError(txtUbicacion, "Campo Obligatorio");
                    return;
                }
                else epError.SetError(txtUbicacion, "");

                if (txtCapacidad.Text.Trim().Equals(""))
                {
                    epError.SetError(txtCapacidad, "Campo Obligatorio");
                    return;
                }
                else epError.SetError(txtCapacidad, "");

                if (lblID.Text.Equals(""))
                {
                    Servicio.Man_Configuracion(null,TxtRuc.Text,txtRazonSocial.Text,txtDireccion.Text,txtSede.Text,txtUbicacion.Text,txtCapacidad.Text,rddlTarDef.SelectedValue.ToString(),rddlTarCam.SelectedValue.ToString(),null,IP,"1");
                    XtraMessageBox.Show("SE GUARDÓ CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    return;
                }
                else
                {
                    Servicio.Man_Configuracion(lblID.Text, TxtRuc.Text, txtRazonSocial.Text, txtDireccion.Text, txtSede.Text, txtUbicacion.Text, txtCapacidad.Text, rddlTarDef.SelectedValue.ToString(), rddlTarCam.SelectedValue.ToString(), null, IP, "2");
                    XtraMessageBox.Show("SE ACTUALIZÓ CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LlenarcbTarifaDef();
                LlenarConfiguracion();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 

            //BLOQUEAR LETRAS
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //BLOQUEAR SIMBOLOS
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //ACEPTAMOS EL RESTO
            else
            {
                e.Handled = true;
            }
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 

            //BLOQUEAR LETRAS
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //BLOQUEAR SIMBOLOS
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //ACEPTAMOS EL RESTO
            else
            {
                e.Handled = true;
            }
        }

        private void txtCapacidad_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        

       

       

    }
}
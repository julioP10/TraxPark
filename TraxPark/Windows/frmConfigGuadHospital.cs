using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ZKExtended.dcg.service;
using ZKExtended.dcg.entity;

namespace ZKExtended
{
    public partial class frmConfigGuadHospital : DevExpress.XtraEditors.XtraForm
    {
        private static frmConfigGuadHospital m_FormDefInstance;
        public static frmConfigGuadHospital DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmConfigGuadHospital();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        TurnoService turSrv;
        bool nuevo;
        public frmConfigGuadHospital()
        {
            InitializeComponent();
            turSrv = new TurnoService();
            nuevo = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                if (nuevo)
                {
                    guardarConfigGuardia();
                }
                else
                {
                    actualizaConfigGuardia();
                }
                
            }
        }

        private void actualizaConfigGuardia()
        {
          try
            {
              turSrv.actualizaTurnos(txtCodigo.Text,txtAlias.Text,cmbTipoDia.SelectedValue.ToString(),
                  cmbIncidencia.SelectedValue.ToString(),cmbHorario.SelectedValue.ToString(),
                  txtComentario.Text,cmbVariante.SelectedValue.ToString());
              lblMensaje.Text = "Actualizado Correctamente";
              llenaListaConfigTurnos();
              limpiaCajas();
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);               
            }          

        }

        private bool valida()
        {
            bool ok = true;
            epErrorVacio.ClearErrors();
            if (txtCodigo.Text == "")
            {
                epErrorVacio.SetError(txtCodigo, "Debe Escribir un Codigo");
                ok = false;
            }
            if (txtAlias.Text == "")
            {
                epErrorVacio.SetError(txtAlias, "Debe Escribir un Alias");
                ok = false;
            }
            return ok;
        }

        private void guardarConfigGuardia()
        {
            try
            {
                turSrv.guardaTurnos(txtCodigo.Text,txtAlias.Text,cmbTipoDia.SelectedValue.ToString(),
                    cmbIncidencia.SelectedValue.ToString(),cmbHorario.SelectedValue.ToString(),txtComentario.Text,cmbVariante.SelectedValue.ToString());
                lblMensaje.Text = "Guardado Correctamente";
                llenaListaConfigTurnos();
                limpiaCajas();
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);               
            }
        }

        private void limpiaCajas()
        {
            txtCodigo.Text = "";
            txtAlias.Text = "";
            txtComentario.Text = "";
            cmbHorario.SelectedIndex = 0;
            cmbIncidencia.SelectedIndex = 0;
            cmbTipoDia.SelectedIndex = 0;
            cmbVariante.SelectedIndex = 0;
            lblMensaje.Text = "";

          
        }

        private void frmConfigGuadHospital_Load(object sender, EventArgs e)
        {
            
            llenaListaConfigTurnos();
            llenaCombos();
        }

        private void llenaCombos()
        {
            cargaCmbTipoDia();
            cargaCmbIncidencia();
            cargaCmbHorario();
            cargaCmbVariante();
        }

        private void cargaCmbVariante()
        {
            try
            {
                cmbVariante = turSrv.cargaCmbVariante(cmbVariante);
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void cargaCmbHorario()
        {
            try
            {
                cmbHorario = turSrv.cargaCmbHorario(cmbHorario);
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void cargaCmbIncidencia()
        {
            try
            {
                cmbIncidencia = turSrv.cargaCmbIncidencia(cmbIncidencia);
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void cargaCmbTipoDia()
        {
            try
            {
                cmbTipoDia = turSrv.cargaCmbTipoDia(cmbTipoDia);
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void llenaListaConfigTurnos()
        {
            try
            {
                lvTurnos.BeginUpdate();
                lvTurnos = turSrv.llenaListaTurnos(lvTurnos);
                lvTurnos.EndUpdate();
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);               
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            txtCodigo.Text = txtCodigo.Text.PadLeft(4, '0');
        }

        private void tsBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                if (nuevo)
                {
                    guardarConfigGuardia();
                }
                else
                {
                    actualizaConfigGuardia();
                }

            }
        }

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            limpiaCajas();
            nuevo = true;
        }

        private void lvTurnos_ItemMouseClick(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            nuevo = false;
            int indexito = lvTurnos.SelectedIndex;
            cargaDatosLista(lvTurnos.Items[indexito].Text);
        }

        private void cargaDatosLista(string indexito)
        {
            try
            {
                Turno tur = turSrv.devuelveTurno(indexito);
                devuelveDatosCajas(tur);
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void devuelveDatosCajas(Turno tur)
        {
            txtCodigo.Text = tur.tur_codigo;
            txtAlias.Text = tur.tur_alias;
            txtComentario.Text = tur.tur_observacion;
            cmbHorario.SelectedValue = tur.tur_horario;
            cmbIncidencia.SelectedValue = tur.tur_incidencia;
            cmbTipoDia.SelectedValue = tur.tur_tipoDia;
            cmbVariante.SelectedValue = tur.tur_variante;
        }

        private void tsBtnBorrar_Click(object sender, EventArgs e)
        {
            eliminaTurno();
        }

        private void eliminaTurno()
        {
            try
            {
                turSrv.eliminaTurno(txtCodigo.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void tsBtnSigui_Click(object sender, EventArgs e)
        {

        }



    }
}
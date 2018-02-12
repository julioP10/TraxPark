using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ZKExtended.dcg.service;

namespace ZKExtended
{
    public partial class frmListadoTurno : DevExpress.XtraEditors.XtraForm
    {
        private static frmListadoTurno m_FormDefInstance;
        public static frmListadoTurno DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmListadoTurno();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        TurnoService turSrv;
        public frmListadoTurno()
        {
            InitializeComponent();
            turSrv = new TurnoService();
        }

        private void frmListadoTurno_Load(object sender, EventArgs e)
        {
            cargaCmbMes();
            cargaCmbAnio();
        }

        private void cargaCmbAnio()
        {
            for (int i = DateTime.Now.Year; i > 1999; i--)
            {
                cmbAnio.Items.Add(i.ToString());
            }
            cmbAnio.Text = string.Format("{0:yyyy}", DateTime.Now);
        }

        private void cargaCmbMes()
        {
            try
            {
                cmbMes = turSrv.cargaCmbMeses(cmbMes);
                cmbMes.SelectedValue = string.Format("{0:MM}", DateTime.Now);
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void cargaListado()
        {
            try
            {
                ssmEspera.ShowWaitForm();
                lvTurno = turSrv.llenaListado(lvTurno,cmbMes.SelectedValue.ToString(),
                    cmbAnio.Text);
                lblCantidad.Text = " Total Registros = " + lvTurno.Items.Count;
                
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            procesarturnos();
        }

        private void procesarturnos()
        {
            try
            {
                ssmEspera.ShowWaitForm();
                turSrv.procesaTurnos(cmbMes.SelectedValue.ToString(),cmbAnio.Text);                
                ssmEspera.CloseWaitForm();
                XtraMessageBox.Show("Completado Correctamente");
            }
            catch (Exception exp)
            {
                ssmEspera.CloseWaitForm();
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargaListado();
            ssmEspera.CloseWaitForm();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}
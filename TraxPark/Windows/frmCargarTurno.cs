using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel = Microsoft.Office.Interop.Excel;
using ZKExtended.dcg.service;

namespace ZKExtended
{
    public partial class frmCargarTurno : DevExpress.XtraEditors.XtraForm
    {
        private static frmCargarTurno m_FormDefInstance;
        public static frmCargarTurno DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmCargarTurno();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlHoja;
        TurnoService turSrv;
        public frmCargarTurno()
        {
            InitializeComponent();
            turSrv = new TurnoService();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (ofdCargaTurno.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = ofdCargaTurno.FileName;
                mostrarDatosExcel(ofdCargaTurno.FileName);
                btnAceptar.Enabled = true;
                
            }
        }

        private void mostrarDatosExcel(string ruta)
        {
            if (File.Exists(ruta))
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(ruta);
                foreach (Microsoft.Office.Interop.Excel.Worksheet hoja in xlWorkBook.Worksheets)
                {
                    cmbHojas.Items.Add(hoja.Name);
                }
                cmbHojas.SelectedIndex = 0;
            }  
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarTurno();

        }

        private void cargarTurno()
        {
            try
            {
                frmProgreso frmPRoges = new frmProgreso();
                frmPRoges.xlSheet = xlHoja;
                frmPRoges.cantRegistros = xlHoja.UsedRange.Rows.Count;
                if (frmPRoges.ShowDialog() == DialogResult.OK)
                {
                    XtraMessageBox.Show("Cargado Correctamente");
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.Message);
               
            }
        }

        private void cargaTurnos()
        {
            try
            {
                turSrv.cargaTurnos(xlHoja);
                //   abreListado();
                XtraMessageBox.Show("Guardado Correctamente");
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }

        private void abreListado()
        {
            frmPrincipal auxPrincipal = (frmPrincipal)this.MdiParent;
            frmListadoTurno frmListado = new frmListadoTurno();
            frmListado.MdiParent = auxPrincipal;
            frmListado.Show();
        }

        private void cmbHojas_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ofdCargaTurno.FileName != "")
            {
                xlHoja = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(cmbHojas.SelectedIndex + 1);
                txtCantReg.Text = (xlHoja.UsedRange.Rows.Count-1).ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrarExcel();
            txtRuta.Text = "";
            txtCantReg.Text = "";
        }

        private void frmCargarTurno_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarExcel();
        }

        public void cerrarExcel()
        {
            var misValue = Type.Missing;
            try
            {
                if (xlWorkBook != null && xlApp != null)
                {
                    xlWorkBook.Close(false, misValue, misValue);
                    xlWorkBook = null;

                }
                if (xlApp != null)
                {
                    xlApp.Quit();
                    xlApp = null;
                }

            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.Message);               
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantReg_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCargarTurno_Load(object sender, EventArgs e)
        {

        }


    }
}
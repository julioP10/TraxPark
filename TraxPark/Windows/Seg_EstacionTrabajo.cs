using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TraxPark.Srv_TraxPark;
using Telerik.WinControls.UI;

namespace TraxPark.Windows
{
    public partial class Seg_EstacionTrabajo : DevExpress.XtraEditors.XtraForm
    {
        private static Seg_EstacionTrabajo m_FormDefInstance;
        public static Seg_EstacionTrabajo DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Seg_EstacionTrabajo();
                else m_FormDefInstance.BringToFront();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private DCGTEC Servicio;
        DataTable Usu;
        string IP;
        int ContarActivos;

        public Seg_EstacionTrabajo()
        {
            InitializeComponent();
            Servicio = new DCGTEC();
            Usu = Program.Usuario;
            IP = Program.ObtenerDireccionIP();
        }

        private void LlenarGrillaEstacion()
        {
            try
            {
                var Est = Servicio.Traer_Estacion(null, null, null, null, null, null, null, null, null, null, "1", "2", null, "4");
                gcEstacionTrabajo.DataSource = Est;
                gvEstacionTrabajo.Columns[0].Visible = false;
                gvEstacionTrabajo.Columns[2].Visible = false;
                gvEstacionTrabajo.Columns[3].Visible = false;
                gvEstacionTrabajo.Columns[4].Visible = false;
                gvEstacionTrabajo.Columns[5].Visible = false;
                gvEstacionTrabajo.Columns[7].Visible = false;
                gvEstacionTrabajo.Columns[10].Visible = false;
                gvEstacionTrabajo.BestFitColumns();

                for (int i = 0; i < gvEstacionTrabajo.RowCount; i++)
                {
                    int CheckEst = Convert.ToInt32(gvEstacionTrabajo.GetFocusedRowCellValue("Estado"));
                    if (CheckEst == 1) ContarActivos++;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaImpresora()
        {
            foreach (string NombresImp in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                rddlImpresora.Items.Add(NombresImp);
            }
        }

        private void Seg_EstacionTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                CargaImpresora();
                LlenarGrillaEstacion();
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

        private void Limpiar()
        {
            txtDescripcion.Text = string.Empty;
            txtNroAutenticacion.Text = string.Empty;
            txtNroMaqRegistradora.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtPiePagina.Text = string.Empty;
            txtSerieBoleta.Text = string.Empty;
            txtSerieFactura.Text = string.Empty;
            cbExcepcion.Checked = false;
            cbEstado.Checked = false;
        }

        private void gcEstacionTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                lblID.Text = gvEstacionTrabajo.GetFocusedRowCellValue("Id").ToString();
                txtDescripcion.Text = gvEstacionTrabajo.GetFocusedRowCellValue("Descripcion").ToString();
                txtNroAutenticacion.Text = gvEstacionTrabajo.GetFocusedRowCellValue("NroAutorizacion").ToString();
                txtNroMaqRegistradora.Text = gvEstacionTrabajo.GetFocusedRowCellValue("NroMaquinaReg").ToString();
                txtProducto.Text = gvEstacionTrabajo.GetFocusedRowCellValue("Producto").ToString();
                txtPiePagina.Text = gvEstacionTrabajo.GetFocusedRowCellValue("PiePagina").ToString();
                rddlImpresora.Text = string.Empty;
                rddlImpresora.SelectedText = gvEstacionTrabajo.GetFocusedRowCellValue("Impresora").ToString();
                txtSerieBoleta.Text = gvEstacionTrabajo.GetFocusedRowCellValue("SerieBoleta").ToString();
                txtSerieFactura.Text = gvEstacionTrabajo.GetFocusedRowCellValue("SerieFactura").ToString();
                int CheckEst = Convert.ToInt32(gvEstacionTrabajo.GetFocusedRowCellValue("Estado"));
                if (CheckEst == 1) cbEstado.Checked = true;
                else cbEstado.Checked = false;
                int CheckExcep = Convert.ToInt32(gvEstacionTrabajo.GetFocusedRowCellValue("Excepcion"));
                if(CheckExcep == 0) cbExcepcion.Checked = false;
                else cbExcepcion.Checked = true;
            }
            catch
            {
                Limpiar();
            }
        }

        private void txtNroAutenticacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sbNuevo_Click(object sender, EventArgs e)
        {
            CargaImpresora();
            LlenarGrillaEstacion();
            lblID.Text = string.Empty;
            Limpiar();
            txtDescripcion.Focus();
        }

        private void sbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text.Equals(""))
                {
                    XtraMessageBox.Show("SELECCIONE UN REGISTRO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (XtraMessageBox.Show("¿Está seguro que desea eliminar este registro del sistema?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Excepcion;
                        if (cbExcepcion.Checked) Excepcion = "1";
                        else Excepcion = "0";
                        Servicio.Man_Estacion(lblID.Text, txtDescripcion.Text, txtNroAutenticacion.Text, txtNroMaqRegistradora.Text, txtProducto.Text, txtPiePagina.Text, rddlImpresora.Text, Excepcion, txtSerieBoleta.Text, txtSerieFactura.Text, "3", null, IP, "2");
                        XtraMessageBox.Show("SE ELIMINÓ CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaImpresora();
                        LlenarGrillaEstacion();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvEstacionTrabajo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (gvEstacionTrabajo.RowCount > 0)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        //if (Privilegio == 0)
                        //{
                            if (XtraMessageBox.Show("¿Está seguro que desea eliminar este registro del sistema?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string Excepcion;
                                if (cbExcepcion.Checked) Excepcion = "1";
                                else Excepcion = "0";
                                Servicio.Man_Estacion(lblID.Text, txtDescripcion.Text, txtNroAutenticacion.Text, txtNroMaqRegistradora.Text, txtProducto.Text, txtPiePagina.Text, rddlImpresora.Text, Excepcion, txtSerieBoleta.Text, txtSerieFactura.Text, "3", null, IP, "2");
                                XtraMessageBox.Show("SE ELIMINÓ CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        //}
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
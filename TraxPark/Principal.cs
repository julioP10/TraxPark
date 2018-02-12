using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using TraxPark.Windows;

namespace TraxPark
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //DataTable DatosUsuario = Program.Usuario;
            //alertMensaje.Show(this, "", "Bienvenido \nEmpresa :" + "DCGTEC" + "\nUsuario :" + DatosUsuario.Rows[0][1]);
            //bsiEmpresa.Caption = "Empresa : " + "DCGTEC";
            //bsiUsuario.Caption = "Usuario : " + DatosUsuario.Rows[0][1];
            //this.Refresh();
        }

        private void bbParamSist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Man_Configuracion.DefInstance.MdiParent = this;
            Man_Configuracion.DefInstance.Show();
        }

        private void bbEstacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Seg_EstacionTrabajo.DefInstance.MdiParent = this;
            Seg_EstacionTrabajo.DefInstance.Show();
        }

        private void rbBtnGestEmp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Man_Empresa.DefInstance.MdiParent = this;
             Man_Empresa.DefInstance.Show();
        }
    }
}
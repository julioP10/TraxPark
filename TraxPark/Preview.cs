using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TraxPark.Windows;

namespace TraxPark
{
    public partial class Preview : DevExpress.XtraEditors.XtraForm
    {

        public Preview()
        {
            InitializeComponent();

        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            Principal auxPrincipal = (Principal)this.MdiParent;
            auxPrincipal.ribPagConex.Visible = false;
            auxPrincipal.ribPagVentana.Visible = false;
            auxPrincipal.ribPagConfig.Visible = false;
        }

        private void frmPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal auxPrincipal = (Principal)this.MdiParent;
            auxPrincipal.ribPagConex.Visible = true;
            auxPrincipal.ribPagVentana.Visible = true;
            auxPrincipal.ribPagConfig.Visible = true;
        }
    }
}
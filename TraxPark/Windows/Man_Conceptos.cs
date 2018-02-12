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
    public partial class Man_Conceptos : DevExpress.XtraEditors.XtraForm
    {

        public Man_Conceptos()
        {
            InitializeComponent();
        }

        private void sbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

    }
}
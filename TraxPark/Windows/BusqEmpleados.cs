using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TraxPark.Windows
{
    public partial class BusqEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public string CodigoEmp { set; get; }

        public BusqEmpleados()
        {
            InitializeComponent();
        }

        private void txtPalabra_EditValueChanged(object sender, EventArgs e)
       {
            if (txtPalabra.Text.Length > 1)
            {
                MessageBox.Show("sd","sdsds");

            }
        }

        private void lvlResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lvlResultado.FocusedItem.Index;
            this.CodigoEmp = lvlResultado.Items[index].SubItems[0].Text;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
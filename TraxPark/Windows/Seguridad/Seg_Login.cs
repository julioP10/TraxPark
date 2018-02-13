using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraxPark.Windows.Seguridad
{
    public partial class Seg_Login : Form
    {
        public Seg_Login()
        {
            InitializeComponent();
        }

        public string PrimeraLetraMayúscula(string Texto)
        {
            return Texto.Substring(0, 1).ToUpper() + Texto.Substring(1);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            BtnProceso.Visible = true;
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            TxtUsuario.TextBoxElement.TextBoxItem.BackColor = Color.LightYellow;
        }
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            TxtUsuario.TextBoxElement.TextBoxItem.BackColor = Color.White;
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            TxtContraseña.TextBoxElement.TextBoxItem.BackColor = Color.White;
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            TxtContraseña.TextBoxElement.TextBoxItem.BackColor = Color.LightYellow;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea salir del sistema?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void Seg_Login_Load(object sender, EventArgs e)
        {
           // string Dia = Convert.ToString(DateTime.Today.ToString("dddd"));
          //string Mes = Convert.ToString(DateTime.Now.ToString("MMMM"));

           // LblFecha.Text = PrimeraLetraMayúscula(Dia) + " " + DateTime.Now.Day + " de " + PrimeraLetraMayúscula(Mes) + " del " + DateTime.Now.Year;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Linq;
using System.Data;
using System.Net;
using TraxPark.Windows;
using TraxPark.Srv_TraxPark;
using DevExpress.XtraEditors;
using TraxPark.Windows.Seguridad;

namespace TraxPark
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Foggy");

            int Iniciar = 0;
            DCGTEC Servicio = new DCGTEC();

            try
            {
                //var Conf = Servicio.Traer_Configuracion(null, null, null, null, null, null, null, null, null, null, null, "4");
                //if (Conf.Length == 0)
                //{
                //    using (Man_Configuracion FrmConf = new Man_Configuracion())
                //    {
                //        if (FrmConf.ShowDialog() != DialogResult.OK) Iniciar = 1;
                //    }
                //}

                //var Estacion = Servicio.Traer_Estacion(null, null, null, null, null, null, null, null, null, null, "1", null, null, "4");
                //if (Estacion.Length == 0)
                //{
                //    using (Seg_EstacionTrabajo FrmEst = new Seg_EstacionTrabajo())
                //    {
                //        if (FrmEst.ShowDialog() != DialogResult.OK) Iniciar = 1;
                //    }
                //}

                //var TipUsu = Servicio.Traer_TipoUsuario(null, null, "1", null, null, "4");
                //if (TipUsu.Length == 0)
                //{
                //    using (Seg_TipoUsuario FrmTipUsu = new Seg_TipoUsuario())
                //    {
                //        if (FrmTipUsu.ShowDialog() != DialogResult.OK) Iniciar = 1;
                //    }
                //}

                ////var Perf = Servicio.Traer_Perfil(null, null, null, null, null, "4");
                ////if (Perf.Length == 0)
                ////{
                ////    using (Seg_PerfilUsuario FrmPerf = new Seg_PerfilUsuario())
                ////    {
                ////        if (FrmPerf.ShowDialog() != DialogResult.OK) Iniciar = 1;
                ////    }
                ////}

                //var Usu = Servicio.Traer_Usuario(null, null, null, null, null, null, "1", null, null, "4");
                //if (Usu.Length == 0)
                //{
                //    using (Man_Usuarios FrmUsu = new Man_Usuarios())
                //    {
                //        if (FrmUsu.ShowDialog() != DialogResult.OK) Iniciar = 1;
                //    }
                //}

                if (Iniciar == 0)
                {
                    using (Seg_Login Login = new Seg_Login())
                    {
                        if (Login.ShowDialog() == DialogResult.OK) Application.Run(new Principal());
                        else Application.Exit();
                    }
                }
                else Application.Exit();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region "Utiles"
        public static string ObtenerDireccionIP()
        {
            string localIP = string.Empty;
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily.ToString() == "InterNetwork")
                    localIP = ip.ToString();
            return localIP;
        }
        #endregion

        #region "Variables Globales"
        public static DataTable Usuario { get; set; }
        #endregion
    }
}
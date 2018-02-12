using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ZKExtended.dcg.service;

namespace ZKExtended.dcg.window
{
    public partial class fmrExtra : DevExpress.XtraEditors.XtraForm
    {
        public fmrExtra()
        {
            InitializeComponent();
        }


        private static fmrExtra m_FormDefInstance;
        public static fmrExtra DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new fmrExtra();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void fmrExtra_Load(object sender, EventArgs e)
        {

        }
    }
}
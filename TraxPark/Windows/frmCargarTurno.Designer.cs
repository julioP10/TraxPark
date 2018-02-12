namespace ZKExtended
{
    partial class frmCargarTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarTurno));
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCantReg = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHojas = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCargarArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.txtRuta = new DevExpress.XtraEditors.TextEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.ofdCargaTurno = new System.Windows.Forms.OpenFileDialog();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantReg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHojas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(12, 94);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 32;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtCantReg);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cmbHojas);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnCargarArchivo);
            this.groupControl1.Controls.Add(this.txtRuta);
            this.groupControl1.Controls.Add(this.lblEstado);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 141);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Seleccion de Archivo";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtCantReg
            // 
            this.txtCantReg.Location = new System.Drawing.Point(121, 80);
            this.txtCantReg.Name = "txtCantReg";
            this.txtCantReg.Properties.ReadOnly = true;
            this.txtCantReg.Size = new System.Drawing.Size(87, 20);
            this.txtCantReg.TabIndex = 20;
            this.txtCantReg.EditValueChanged += new System.EventHandler(this.txtCantReg_EditValueChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(15, 110);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "La primera fila es titulo de las columnas";
            this.checkEdit1.Size = new System.Drawing.Size(220, 19);
            this.checkEdit1.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Cantidad Registros :";
            // 
            // cmbHojas
            // 
            this.cmbHojas.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbHojas.Location = new System.Drawing.Point(121, 55);
            this.cmbHojas.Name = "cmbHojas";
            this.cmbHojas.Size = new System.Drawing.Size(158, 21);
            this.cmbHojas.TabIndex = 16;
            this.cmbHojas.ThemeName = "VisualStudio2012Light";
            this.cmbHojas.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbHojas_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Seleccionar Hoja :";
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(333, 24);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(20, 20);
            this.btnCargarArchivo.TabIndex = 11;
            this.btnCargarArchivo.Text = "...";
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(15, 25);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Properties.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(309, 20);
            this.txtRuta.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(21, 60);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 8;
            // 
            // ofdCargaTurno
            // 
            this.ofdCargaTurno.AddExtension = false;
            this.ofdCargaTurno.DefaultExt = "xls";
            this.ofdCargaTurno.Filter = "Libro de Excel 97- 2003 (*.xls)|*.xls|Libro de Excel  (*.xlsx)|*.xlsx*";
            this.ofdCargaTurno.InitialDirectory = "Escritorio";
            this.ofdCargaTurno.RestoreDirectory = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(273, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 25);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(187, 147);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 25);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Importar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCargarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 182);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCargarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCargarTurno_FormClosed);
            this.Load += new System.EventHandler(this.frmCargarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantReg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHojas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCargarArchivo;
        private DevExpress.XtraEditors.TextEdit txtRuta;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private System.Windows.Forms.OpenFileDialog ofdCargaTurno;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Telerik.WinControls.UI.RadDropDownList cmbHojas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCantReg;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
namespace ZKExtended
{
    partial class frmConfigGuadHospital
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigGuadHospital));
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Codigo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Nombre");
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAnt = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSigui = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.lvTurnos = new Telerik.WinControls.UI.RadListView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbVariante = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.cmbHorario = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbIncidencia = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoDia = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.epErrorVacio = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVariante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIncidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAnt,
            this.tsBtnSigui,
            this.toolStripSeparator1,
            this.tsBtnGuardar,
            this.tsBtnNuevo,
            this.tsBtnBorrar,
            this.toolStripSeparator2,
            this.tsBtnCerrar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(527, 55);
            this.toolStrip2.TabIndex = 50;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsBtnAnt
            // 
            this.tsBtnAnt.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAnt.Image")));
            this.tsBtnAnt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAnt.Name = "tsBtnAnt";
            this.tsBtnAnt.Size = new System.Drawing.Size(54, 52);
            this.tsBtnAnt.Text = "Anterior";
            this.tsBtnAnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnAnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnAnt.ToolTipText = "Nuevo Usuario";
            // 
            // tsBtnSigui
            // 
            this.tsBtnSigui.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSigui.Image")));
            this.tsBtnSigui.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSigui.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSigui.Name = "tsBtnSigui";
            this.tsBtnSigui.Size = new System.Drawing.Size(54, 52);
            this.tsBtnSigui.Text = "Anterior";
            this.tsBtnSigui.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnSigui.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnSigui.ToolTipText = "Nuevo Usuario";
            this.tsBtnSigui.Click += new System.EventHandler(this.tsBtnSigui_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsBtnGuardar
            // 
            this.tsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGuardar.Image")));
            this.tsBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardar.Name = "tsBtnGuardar";
            this.tsBtnGuardar.Size = new System.Drawing.Size(53, 52);
            this.tsBtnGuardar.Text = "Guardar";
            this.tsBtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnGuardar.ToolTipText = "Nuevo Usuario";
            this.tsBtnGuardar.Click += new System.EventHandler(this.tsBtnGuardar_Click);
            // 
            // tsBtnNuevo
            // 
            this.tsBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevo.Image")));
            this.tsBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevo.Name = "tsBtnNuevo";
            this.tsBtnNuevo.Size = new System.Drawing.Size(46, 52);
            this.tsBtnNuevo.Text = "Nuevo";
            this.tsBtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnNuevo.ToolTipText = "Nuevo Usuario";
            this.tsBtnNuevo.Click += new System.EventHandler(this.tsBtnNuevo_Click);
            // 
            // tsBtnBorrar
            // 
            this.tsBtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBorrar.Image")));
            this.tsBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBorrar.Name = "tsBtnBorrar";
            this.tsBtnBorrar.Size = new System.Drawing.Size(43, 52);
            this.tsBtnBorrar.Text = "Borrar";
            this.tsBtnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnBorrar.ToolTipText = "Nuevo Usuario";
            this.tsBtnBorrar.Click += new System.EventHandler(this.tsBtnBorrar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsBtnCerrar
            // 
            this.tsBtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCerrar.Image")));
            this.tsBtnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCerrar.Name = "tsBtnCerrar";
            this.tsBtnCerrar.Size = new System.Drawing.Size(43, 52);
            this.tsBtnCerrar.Text = "Cerrar";
            this.tsBtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCerrar.ToolTipText = "Cerrar";
            this.tsBtnCerrar.Click += new System.EventHandler(this.tsBtnCerrar_Click);
            // 
            // lvTurnos
            // 
            this.lvTurnos.AllowEdit = false;
            this.lvTurnos.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Codigo";
            listViewDetailColumn1.Width = 60F;
            listViewDetailColumn2.HeaderText = "Nombre";
            listViewDetailColumn2.Width = 130F;
            this.lvTurnos.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2});
            this.lvTurnos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvTurnos.ItemSpacing = -1;
            this.lvTurnos.Location = new System.Drawing.Point(0, 55);
            this.lvTurnos.Name = "lvTurnos";
            this.lvTurnos.Size = new System.Drawing.Size(196, 284);
            this.lvTurnos.TabIndex = 65;
            this.lvTurnos.ThemeName = "Windows8";
            this.lvTurnos.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvTurnos.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lvTurnos_ItemMouseClick);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.cmbVariante);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtComentario);
            this.groupControl1.Controls.Add(this.cmbHorario);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cmbIncidencia);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cmbTipoDia);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAlias);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCodigo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(196, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 236);
            this.groupControl1.TabIndex = 66;
            this.groupControl1.Text = "Configurar Guardias Hospitalarias";
            // 
            // cmbVariante
            // 
            this.cmbVariante.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbVariante.Location = new System.Drawing.Point(85, 80);
            this.cmbVariante.MaxDropDownItems = 6;
            this.cmbVariante.Name = "cmbVariante";
            this.cmbVariante.Size = new System.Drawing.Size(234, 21);
            this.cmbVariante.TabIndex = 14;
            this.cmbVariante.ThemeName = "VisualStudio2012Light";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Variante :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 185);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Comentario :";
            // 
            // txtComentario
            // 
            this.txtComentario.EditValue = "";
            this.txtComentario.Location = new System.Drawing.Point(85, 180);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(234, 45);
            this.txtComentario.TabIndex = 11;
            //this.txtComentario.UseOptimizedRendering = true;
            // 
            // cmbHorario
            // 
            //this.cmbHorario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbHorario.Location = new System.Drawing.Point(85, 155);
            this.cmbHorario.MaxDropDownItems = 6;
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(234, 21);
            this.cmbHorario.TabIndex = 10;
            this.cmbHorario.ThemeName = "VisualStudio2012Light";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Horario :";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbIncidencia.Location = new System.Drawing.Point(85, 130);
            this.cmbIncidencia.MaxDropDownItems = 6;
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(234, 21);
            this.cmbIncidencia.TabIndex = 8;
            this.cmbIncidencia.ThemeName = "VisualStudio2012Light";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Incidencia :";
            // 
            // cmbTipoDia
            // 
            this.cmbTipoDia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbTipoDia.Location = new System.Drawing.Point(85, 105);
            this.cmbTipoDia.MaxDropDownItems = 6;
            this.cmbTipoDia.Name = "cmbTipoDia";
            this.cmbTipoDia.Size = new System.Drawing.Size(234, 21);
            this.cmbTipoDia.TabIndex = 6;
            this.cmbTipoDia.ThemeName = "VisualStudio2012Light";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tipo de Dia :";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(85, 55);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(88, 20);
            this.txtAlias.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Alias :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Codigo :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(440, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(359, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
            this.btnAceptar.TabIndex = 67;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(211, 301);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 69;
            // 
            // epErrorVacio
            // 
            this.epErrorVacio.ContainerControl = this;
            // 
            // frmConfigGuadHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 339);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lvTurnos);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmConfigGuadHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfigGuadHospital_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVariante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIncidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorVacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtnAnt;
        private System.Windows.Forms.ToolStripButton tsBtnSigui;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripButton tsBtnNuevo;
        private System.Windows.Forms.ToolStripButton tsBtnBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnCerrar;
        private Telerik.WinControls.UI.RadListView lvTurnos;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAlias;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private Telerik.WinControls.UI.RadDropDownList cmbTipoDia;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtComentario;
        private Telerik.WinControls.UI.RadDropDownList cmbHorario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Telerik.WinControls.UI.RadDropDownList cmbIncidencia;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider epErrorVacio;
        private Telerik.WinControls.UI.RadDropDownList cmbVariante;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
﻿namespace TraxPark.Windows
{
    partial class Seg_EstacionTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seg_EstacionTrabajo));
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.txtNroAutenticacion = new Telerik.WinControls.UI.RadTextBox();
            this.txtNroMaqRegistradora = new Telerik.WinControls.UI.RadTextBox();
            this.gcEstacionTrabajo = new DevExpress.XtraGrid.GridControl();
            this.gvEstacionTrabajo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbEstado = new Telerik.WinControls.UI.RadCheckBox();
            this.rddlImpresora = new Telerik.WinControls.UI.RadDropDownList();
            this.cbExcepcion = new Telerik.WinControls.UI.RadCheckBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerieFactura = new Telerik.WinControls.UI.RadTextBox();
            this.txtSerieBoleta = new Telerik.WinControls.UI.RadTextBox();
            this.txtPiePagina = new Telerik.WinControls.UI.RadTextBox();
            this.txtProducto = new Telerik.WinControls.UI.RadTextBox();
            this.nbcOpciones = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.sbNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.sbSalir = new DevExpress.XtraEditors.SimpleButton();
            this.sbEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbModificar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroAutenticacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroMaqRegistradora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstacionTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstacionTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlImpresora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcepcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieBoleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiePagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcOpciones)).BeginInit();
            this.nbcOpciones.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(517, 27);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(167, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtNroAutenticacion
            // 
            this.txtNroAutenticacion.Location = new System.Drawing.Point(517, 53);
            this.txtNroAutenticacion.MaxLength = 20;
            this.txtNroAutenticacion.Name = "txtNroAutenticacion";
            this.txtNroAutenticacion.Size = new System.Drawing.Size(167, 20);
            this.txtNroAutenticacion.TabIndex = 1;
            this.txtNroAutenticacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroAutenticacion_KeyPress);
            // 
            // txtNroMaqRegistradora
            // 
            this.txtNroMaqRegistradora.Location = new System.Drawing.Point(517, 79);
            this.txtNroMaqRegistradora.MaxLength = 20;
            this.txtNroMaqRegistradora.Name = "txtNroMaqRegistradora";
            this.txtNroMaqRegistradora.Size = new System.Drawing.Size(167, 20);
            this.txtNroMaqRegistradora.TabIndex = 2;
            // 
            // gcEstacionTrabajo
            // 
            this.gcEstacionTrabajo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcEstacionTrabajo.Location = new System.Drawing.Point(2, 19);
            this.gcEstacionTrabajo.MainView = this.gvEstacionTrabajo;
            this.gcEstacionTrabajo.Name = "gcEstacionTrabajo";
            this.gcEstacionTrabajo.Size = new System.Drawing.Size(360, 431);
            this.gcEstacionTrabajo.TabIndex = 1;
            this.gcEstacionTrabajo.TabStop = false;
            this.gcEstacionTrabajo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEstacionTrabajo});
            this.gcEstacionTrabajo.Click += new System.EventHandler(this.gcEstacionTrabajo_Click);
            // 
            // gvEstacionTrabajo
            // 
            this.gvEstacionTrabajo.GridControl = this.gcEstacionTrabajo;
            this.gvEstacionTrabajo.Name = "gvEstacionTrabajo";
            this.gvEstacionTrabajo.OptionsBehavior.Editable = false;
            this.gvEstacionTrabajo.OptionsView.ShowAutoFilterRow = true;
            this.gvEstacionTrabajo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvEstacionTrabajo_KeyDown);
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(530, 266);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(60, 18);
            this.cbEstado.TabIndex = 8;
            this.cbEstado.Text = "Estado";
            // 
            // rddlImpresora
            // 
            this.rddlImpresora.Location = new System.Drawing.Point(517, 157);
            this.rddlImpresora.Name = "rddlImpresora";
            this.rddlImpresora.Size = new System.Drawing.Size(167, 20);
            this.rddlImpresora.TabIndex = 5;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.rddlImpresora.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).EnableElementShadow = true;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.rddlImpresora.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Enabled = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rddlImpresora.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Enabled = true;
            // 
            // cbExcepcion
            // 
            this.cbExcepcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExcepcion.Location = new System.Drawing.Point(530, 290);
            this.cbExcepcion.Name = "cbExcepcion";
            this.cbExcepcion.Size = new System.Drawing.Size(130, 18);
            this.cbExcepcion.TabIndex = 9;
            this.cbExcepcion.Text = "Controla Excepción";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(415, 209);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 17);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Serie de Factura :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(421, 183);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 17);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Serie de Boleta :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(449, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 17);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Impresora :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(428, 131);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Pie de Pagina :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(455, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 17);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Producto :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(379, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Nro. Maq. Registradora :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(404, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Nro. Autenticación :";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(-35, 238);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 10;
            this.lblID.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(440, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 17);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Descripción :";
            // 
            // txtSerieFactura
            // 
            this.txtSerieFactura.Location = new System.Drawing.Point(517, 209);
            this.txtSerieFactura.MaxLength = 4;
            this.txtSerieFactura.Name = "txtSerieFactura";
            this.txtSerieFactura.Size = new System.Drawing.Size(167, 20);
            this.txtSerieFactura.TabIndex = 7;
            // 
            // txtSerieBoleta
            // 
            this.txtSerieBoleta.Location = new System.Drawing.Point(517, 183);
            this.txtSerieBoleta.MaxLength = 4;
            this.txtSerieBoleta.Name = "txtSerieBoleta";
            this.txtSerieBoleta.Size = new System.Drawing.Size(167, 20);
            this.txtSerieBoleta.TabIndex = 6;
            // 
            // txtPiePagina
            // 
            this.txtPiePagina.Location = new System.Drawing.Point(517, 131);
            this.txtPiePagina.MaxLength = 100;
            this.txtPiePagina.Name = "txtPiePagina";
            this.txtPiePagina.Size = new System.Drawing.Size(167, 20);
            this.txtPiePagina.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(517, 105);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(167, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // nbcOpciones
            // 
            this.nbcOpciones.ActiveGroup = this.nbgMail;
            this.nbcOpciones.Controls.Add(this.navBarGroupControlContainer1);
            this.nbcOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.nbcOpciones.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMail});
            this.nbcOpciones.Location = new System.Drawing.Point(813, 19);
            this.nbcOpciones.Name = "nbcOpciones";
            this.nbcOpciones.NavigationPaneGroupClientHeight = 320;
            this.nbcOpciones.OptionsNavPane.ExpandedWidth = 160;
            this.nbcOpciones.Size = new System.Drawing.Size(160, 431);
            this.nbcOpciones.TabIndex = 1;
            this.nbcOpciones.TabStop = true;
            this.nbcOpciones.Text = "navBarControl1";
            this.nbcOpciones.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Glass Oceans");
            // 
            // nbgMail
            // 
            this.nbgMail.Caption = "OPCIONES";
            this.nbgMail.ControlContainer = this.navBarGroupControlContainer1;
            this.nbgMail.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.nbgMail.Expanded = true;
            this.nbgMail.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.nbgMail.GroupClientHeight = 80;
            this.nbgMail.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nbgMail.Name = "nbgMail";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.sbNuevo);
            this.navBarGroupControlContainer1.Controls.Add(this.sbSalir);
            this.navBarGroupControlContainer1.Controls.Add(this.sbEliminar);
            this.navBarGroupControlContainer1.Controls.Add(this.sbModificar);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(156, 329);
            this.navBarGroupControlContainer1.TabIndex = 1;
            this.navBarGroupControlContainer1.TabStop = true;
            // 
            // sbNuevo
            // 
            this.sbNuevo.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbNuevo.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbNuevo.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbNuevo.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbNuevo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbNuevo.Appearance.Options.UseBackColor = true;
            this.sbNuevo.Appearance.Options.UseBorderColor = true;
            this.sbNuevo.Appearance.Options.UseFont = true;
            this.sbNuevo.Appearance.Options.UseForeColor = true;
            this.sbNuevo.Appearance.Options.UseImage = true;
            this.sbNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("sbNuevo.Image")));
            this.sbNuevo.Location = new System.Drawing.Point(24, 16);
            this.sbNuevo.Name = "sbNuevo";
            this.sbNuevo.Size = new System.Drawing.Size(110, 35);
            this.sbNuevo.TabIndex = 0;
            this.sbNuevo.Text = "NUEVO";
            this.sbNuevo.Click += new System.EventHandler(this.sbNuevo_Click);
            // 
            // sbSalir
            // 
            this.sbSalir.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbSalir.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbSalir.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbSalir.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSalir.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbSalir.Appearance.Options.UseBackColor = true;
            this.sbSalir.Appearance.Options.UseBorderColor = true;
            this.sbSalir.Appearance.Options.UseFont = true;
            this.sbSalir.Appearance.Options.UseForeColor = true;
            this.sbSalir.Appearance.Options.UseImage = true;
            this.sbSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbSalir.Image = ((System.Drawing.Image)(resources.GetObject("sbSalir.Image")));
            this.sbSalir.Location = new System.Drawing.Point(24, 376);
            this.sbSalir.Name = "sbSalir";
            this.sbSalir.Size = new System.Drawing.Size(110, 35);
            this.sbSalir.TabIndex = 3;
            this.sbSalir.Text = "SALIR";
            this.sbSalir.Click += new System.EventHandler(this.sbSalir_Click);
            // 
            // sbEliminar
            // 
            this.sbEliminar.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbEliminar.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbEliminar.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbEliminar.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbEliminar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbEliminar.Appearance.Options.UseBackColor = true;
            this.sbEliminar.Appearance.Options.UseBorderColor = true;
            this.sbEliminar.Appearance.Options.UseFont = true;
            this.sbEliminar.Appearance.Options.UseForeColor = true;
            this.sbEliminar.Appearance.Options.UseImage = true;
            this.sbEliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("sbEliminar.Image")));
            this.sbEliminar.Location = new System.Drawing.Point(24, 144);
            this.sbEliminar.Name = "sbEliminar";
            this.sbEliminar.Size = new System.Drawing.Size(110, 35);
            this.sbEliminar.TabIndex = 2;
            this.sbEliminar.Text = "ELIMINAR";
            this.sbEliminar.Click += new System.EventHandler(this.sbEliminar_Click);
            // 
            // sbModificar
            // 
            this.sbModificar.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbModificar.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbModificar.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbModificar.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbModificar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbModificar.Appearance.Options.UseBackColor = true;
            this.sbModificar.Appearance.Options.UseBorderColor = true;
            this.sbModificar.Appearance.Options.UseFont = true;
            this.sbModificar.Appearance.Options.UseForeColor = true;
            this.sbModificar.Appearance.Options.UseImage = true;
            this.sbModificar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbModificar.Image = ((System.Drawing.Image)(resources.GetObject("sbModificar.Image")));
            this.sbModificar.Location = new System.Drawing.Point(24, 80);
            this.sbModificar.Name = "sbModificar";
            this.sbModificar.Size = new System.Drawing.Size(110, 35);
            this.sbModificar.TabIndex = 1;
            this.sbModificar.Text = "GUARDAR";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcEstacionTrabajo);
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.nbcOpciones);
            this.groupControl1.Controls.Add(this.txtNroMaqRegistradora);
            this.groupControl1.Controls.Add(this.cbEstado);
            this.groupControl1.Controls.Add(this.txtNroAutenticacion);
            this.groupControl1.Controls.Add(this.rddlImpresora);
            this.groupControl1.Controls.Add(this.txtProducto);
            this.groupControl1.Controls.Add(this.cbExcepcion);
            this.groupControl1.Controls.Add(this.txtPiePagina);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtSerieBoleta);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtSerieFactura);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(975, 452);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // Seg_EstacionTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 452);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 452);
            this.Name = "Seg_EstacionTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTACION DE TRABAJO";
            this.Load += new System.EventHandler(this.Seg_EstacionTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroAutenticacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroMaqRegistradora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstacionTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstacionTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlImpresora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcepcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieBoleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiePagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcOpciones)).EndInit();
            this.nbcOpciones.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtDescripcion;
        private Telerik.WinControls.UI.RadTextBox txtNroAutenticacion;
        private Telerik.WinControls.UI.RadTextBox txtNroMaqRegistradora;
        private DevExpress.XtraNavBar.NavBarControl nbcOpciones;
        private DevExpress.XtraNavBar.NavBarGroup nbgMail;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton sbNuevo;
        private DevExpress.XtraEditors.SimpleButton sbSalir;
        private DevExpress.XtraEditors.SimpleButton sbEliminar;
        private DevExpress.XtraEditors.SimpleButton sbModificar;
        private Telerik.WinControls.UI.RadTextBox txtPiePagina;
        private Telerik.WinControls.UI.RadTextBox txtProducto;
        private Telerik.WinControls.UI.RadTextBox txtSerieFactura;
        private Telerik.WinControls.UI.RadTextBox txtSerieBoleta;
        private DevExpress.XtraGrid.GridControl gcEstacionTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEstacionTrabajo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Telerik.WinControls.UI.RadCheckBox cbExcepcion;
        private DevExpress.XtraEditors.LabelControl lblID;
        private Telerik.WinControls.UI.RadDropDownList rddlImpresora;
        private Telerik.WinControls.UI.RadCheckBox cbEstado;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
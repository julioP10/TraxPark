namespace TraxPark.Windows
{
    partial class Man_Excepciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Excepciones));
            this.gcExcepciones = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ceEstado = new Telerik.WinControls.UI.RadCheckBox();
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTiempo = new Telerik.WinControls.UI.RadTextBox();
            this.txtMonto = new Telerik.WinControls.UI.RadTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.sbNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.sbSalir = new DevExpress.XtraEditors.SimpleButton();
            this.sbEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbModificar = new DevExpress.XtraEditors.SimpleButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gcExcepciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcExcepciones
            // 
            this.gcExcepciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcExcepciones.Location = new System.Drawing.Point(18, 183);
            this.gcExcepciones.MainView = this.gridView1;
            this.gcExcepciones.Name = "gcExcepciones";
            this.gcExcepciones.Size = new System.Drawing.Size(323, 211);
            this.gcExcepciones.TabIndex = 1;
            this.gcExcepciones.TabStop = false;
            this.gcExcepciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcExcepciones.Click += new System.EventHandler(this.gcExcepciones_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcExcepciones;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.ceEstado);
            this.radGroupBox1.Controls.Add(this.txtDescripcion);
            this.radGroupBox1.Controls.Add(this.labelControl6);
            this.radGroupBox1.Controls.Add(this.labelControl5);
            this.radGroupBox1.Controls.Add(this.txtTiempo);
            this.radGroupBox1.Controls.Add(this.txtMonto);
            this.radGroupBox1.Controls.Add(this.labelControl4);
            this.radGroupBox1.Controls.Add(this.labelControl3);
            this.radGroupBox1.Controls.Add(this.labelControl2);
            this.radGroupBox1.Controls.Add(this.labelControl1);
            this.radGroupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Datos de la Excepción";
            this.radGroupBox1.Location = new System.Drawing.Point(18, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(323, 154);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Datos de la Excepción";
            // 
            // ceEstado
            // 
            this.ceEstado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceEstado.Location = new System.Drawing.Point(108, 126);
            this.ceEstado.Name = "ceEstado";
            this.ceEstado.Size = new System.Drawing.Size(60, 18);
            this.ceEstado.TabIndex = 3;
            this.ceEstado.Text = "Estado";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(108, 31);
            this.txtDescripcion.MaxLength = 20;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(193, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 17);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "minutos";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(193, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 17);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "soles";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTiempo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(108, 94);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(75, 20);
            this.txtTiempo.TabIndex = 2;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(108, 62);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(75, 20);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(51, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 17);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tiempo :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(57, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Monto :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(27, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción :";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgMail;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMail});
            this.navBarControl1.Location = new System.Drawing.Point(357, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneGroupClientHeight = 320;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 151;
            this.navBarControl1.Size = new System.Drawing.Size(151, 413);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.TabStop = true;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Glass Oceans");
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
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(147, 338);
            this.navBarGroupControlContainer1.TabIndex = 0;
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
            this.sbNuevo.Location = new System.Drawing.Point(18, 15);
            this.sbNuevo.Name = "sbNuevo";
            this.sbNuevo.Size = new System.Drawing.Size(110, 35);
            this.sbNuevo.TabIndex = 0;
            this.sbNuevo.Text = "NUEVO";
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
            this.sbSalir.Location = new System.Drawing.Point(18, 286);
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
            this.sbEliminar.Location = new System.Drawing.Point(18, 127);
            this.sbEliminar.Name = "sbEliminar";
            this.sbEliminar.Size = new System.Drawing.Size(110, 35);
            this.sbEliminar.TabIndex = 2;
            this.sbEliminar.Text = "ELIMINAR";
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
            this.sbModificar.Location = new System.Drawing.Point(18, 70);
            this.sbModificar.Name = "sbModificar";
            this.sbModificar.Size = new System.Drawing.Size(110, 35);
            this.sbModificar.TabIndex = 1;
            this.sbModificar.Text = "MODIFICAR";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Controls.Add(this.gcExcepciones);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(357, 413);
            this.radPanel1.TabIndex = 0;
            // 
            // Man_Excepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 413);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Man_Excepciones";
            this.Text = "Mant_Excepción";
            ((System.ComponentModel.ISupportInitialize)(this.gcExcepciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcExcepciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Telerik.WinControls.UI.RadTextBox txtTiempo;
        private Telerik.WinControls.UI.RadTextBox txtMonto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgMail;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton sbNuevo;
        private DevExpress.XtraEditors.SimpleButton sbSalir;
        private DevExpress.XtraEditors.SimpleButton sbEliminar;
        private DevExpress.XtraEditors.SimpleButton sbModificar;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Telerik.WinControls.UI.RadCheckBox ceEstado;
    }
}
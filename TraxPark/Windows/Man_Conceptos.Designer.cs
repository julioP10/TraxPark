namespace TraxPark.Windows
{
    partial class Man_Conceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Conceptos));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ceEstado = new Telerik.WinControls.UI.RadCheckBox();
            this.rddlTipo = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.gcConceptos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.nbcOpciones = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.sbNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.sbSalir = new DevExpress.XtraEditors.SimpleButton();
            this.sbEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbModificar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbcOpciones)).BeginInit();
            this.nbcOpciones.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.ceEstado);
            this.radGroupBox1.Controls.Add(this.rddlTipo);
            this.radGroupBox1.Controls.Add(this.labelControl2);
            this.radGroupBox1.Controls.Add(this.labelControl1);
            this.radGroupBox1.Controls.Add(this.txtDescripcion);
            this.radGroupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Datos Concepto";
            this.radGroupBox1.Location = new System.Drawing.Point(19, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(370, 136);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Datos Concepto";
            // 
            // ceEstado
            // 
            this.ceEstado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceEstado.Location = new System.Drawing.Point(150, 104);
            this.ceEstado.Name = "ceEstado";
            this.ceEstado.Size = new System.Drawing.Size(60, 18);
            this.ceEstado.TabIndex = 2;
            this.ceEstado.Text = "Estado";
            // 
            // rddlTipo
            // 
            this.rddlTipo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddlTipo.Location = new System.Drawing.Point(123, 67);
            this.rddlTipo.Name = "rddlTipo";
            this.rddlTipo.Size = new System.Drawing.Size(155, 20);
            this.rddlTipo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(80, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tipo :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(38, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Descripción :";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(123, 32);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TabStop = false;
            // 
            // gcConceptos
            // 
            this.gcConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcConceptos.Location = new System.Drawing.Point(19, 165);
            this.gcConceptos.MainView = this.gridView1;
            this.gcConceptos.Name = "gcConceptos";
            this.gcConceptos.Size = new System.Drawing.Size(370, 200);
            this.gcConceptos.TabIndex = 2;
            this.gcConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcConceptos;
            this.gridView1.Name = "gridView1";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.nbcOpciones);
            this.radPanel1.Controls.Add(this.gcConceptos);
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(567, 379);
            this.radPanel1.TabIndex = 0;
            // 
            // nbcOpciones
            // 
            this.nbcOpciones.ActiveGroup = this.nbgMail;
            this.nbcOpciones.Controls.Add(this.navBarGroupControlContainer1);
            this.nbcOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.nbcOpciones.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMail});
            this.nbcOpciones.Location = new System.Drawing.Point(406, 0);
            this.nbcOpciones.Name = "nbcOpciones";
            this.nbcOpciones.NavigationPaneGroupClientHeight = 320;
            this.nbcOpciones.OptionsNavPane.ExpandedWidth = 161;
            this.nbcOpciones.Size = new System.Drawing.Size(161, 379);
            this.nbcOpciones.TabIndex = 1;
            this.nbcOpciones.TabStop = true;
            this.nbcOpciones.Text = "navBarControl1";
            this.nbcOpciones.UseWaitCursor = true;
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
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(157, 305);
            this.navBarGroupControlContainer1.TabIndex = 0;
            this.navBarGroupControlContainer1.UseWaitCursor = true;
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
            this.sbNuevo.Location = new System.Drawing.Point(23, 15);
            this.sbNuevo.Name = "sbNuevo";
            this.sbNuevo.Size = new System.Drawing.Size(110, 35);
            this.sbNuevo.TabIndex = 0;
            this.sbNuevo.Text = "NUEVO";
            this.sbNuevo.UseWaitCursor = true;
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
            this.sbSalir.Location = new System.Drawing.Point(23, 257);
            this.sbSalir.Name = "sbSalir";
            this.sbSalir.Size = new System.Drawing.Size(110, 35);
            this.sbSalir.TabIndex = 3;
            this.sbSalir.Text = "SALIR";
            this.sbSalir.UseWaitCursor = true;
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
            this.sbEliminar.Location = new System.Drawing.Point(23, 128);
            this.sbEliminar.Name = "sbEliminar";
            this.sbEliminar.Size = new System.Drawing.Size(110, 35);
            this.sbEliminar.TabIndex = 2;
            this.sbEliminar.Text = "ELIMINAR";
            this.sbEliminar.UseWaitCursor = true;
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
            this.sbModificar.Location = new System.Drawing.Point(23, 71);
            this.sbModificar.Name = "sbModificar";
            this.sbModificar.Size = new System.Drawing.Size(110, 35);
            this.sbModificar.TabIndex = 1;
            this.sbModificar.Text = "MODIFICAR";
            this.sbModificar.UseWaitCursor = true;
            // 
            // Man_Conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 379);
            this.Controls.Add(this.radPanel1);
            this.Name = "Man_Conceptos";
            this.Text = "Man_Conceptos";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbcOpciones)).EndInit();
            this.nbcOpciones.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Telerik.WinControls.UI.RadTextBox txtDescripcion;
        private DevExpress.XtraGrid.GridControl gcConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private DevExpress.XtraNavBar.NavBarControl nbcOpciones;
        private DevExpress.XtraNavBar.NavBarGroup nbgMail;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton sbNuevo;
        private DevExpress.XtraEditors.SimpleButton sbSalir;
        private DevExpress.XtraEditors.SimpleButton sbEliminar;
        private DevExpress.XtraEditors.SimpleButton sbModificar;
        private Telerik.WinControls.UI.RadDropDownList rddlTipo;
        private Telerik.WinControls.UI.RadCheckBox ceEstado;

    }
}
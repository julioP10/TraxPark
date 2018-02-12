namespace TraxPark.Windows
{
    partial class Man_Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Comprobante));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.nbcOpciones = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.sbNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.sbSalir = new DevExpress.XtraEditors.SimpleButton();
            this.sbEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbModificar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcOpciones)).BeginInit();
            this.nbcOpciones.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radCheckBox2);
            this.radGroupBox1.Controls.Add(this.radCheckBox1);
            this.radGroupBox1.Controls.Add(this.radTextBoxControl1);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Datos del Comprobante";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(280, 109);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Datos del Comprobante";
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox2.Location = new System.Drawing.Point(107, 81);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(60, 18);
            this.radCheckBox2.TabIndex = 3;
            this.radCheckBox2.Text = "Estado";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox1.Location = new System.Drawing.Point(107, 57);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(45, 18);
            this.radCheckBox1.TabIndex = 2;
            this.radCheckBox1.Text = "RUC";
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBoxControl1.Location = new System.Drawing.Point(108, 30);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(133, 20);
            this.radTextBoxControl1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(23, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(80, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Descripción :";
            // 
            // nbcOpciones
            // 
            this.nbcOpciones.ActiveGroup = this.nbgMail;
            this.nbcOpciones.Controls.Add(this.navBarGroupControlContainer1);
            this.nbcOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.nbcOpciones.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMail});
            this.nbcOpciones.Location = new System.Drawing.Point(306, 0);
            this.nbcOpciones.Name = "nbcOpciones";
            this.nbcOpciones.NavigationPaneGroupClientHeight = 320;
            this.nbcOpciones.OptionsNavPane.ExpandedWidth = 166;
            this.nbcOpciones.Size = new System.Drawing.Size(166, 307);
            this.nbcOpciones.TabIndex = 2;
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
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(162, 233);
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
            this.sbNuevo.Location = new System.Drawing.Point(27, 15);
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
            this.sbSalir.Location = new System.Drawing.Point(27, 182);
            this.sbSalir.Name = "sbSalir";
            this.sbSalir.Size = new System.Drawing.Size(110, 35);
            this.sbSalir.TabIndex = 3;
            this.sbSalir.Text = "SALIR";
            this.sbSalir.UseWaitCursor = true;
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
            this.sbEliminar.Location = new System.Drawing.Point(27, 128);
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
            this.sbModificar.Location = new System.Drawing.Point(27, 71);
            this.sbModificar.Name = "sbModificar";
            this.sbModificar.Size = new System.Drawing.Size(110, 35);
            this.sbModificar.TabIndex = 1;
            this.sbModificar.Text = "MODIFICAR";
            this.sbModificar.UseWaitCursor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 139);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(280, 147);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Man_Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 307);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.nbcOpciones);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Man_Comprobante";
            this.Text = "Man_Comprobante";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcOpciones)).EndInit();
            this.nbcOpciones.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private DevExpress.XtraNavBar.NavBarControl nbcOpciones;
        private DevExpress.XtraNavBar.NavBarGroup nbgMail;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton sbNuevo;
        private DevExpress.XtraEditors.SimpleButton sbSalir;
        private DevExpress.XtraEditors.SimpleButton sbEliminar;
        private DevExpress.XtraEditors.SimpleButton sbModificar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
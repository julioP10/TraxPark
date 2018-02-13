namespace TraxPark.Windows
{
    partial class BusqEmpleados
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbSelect = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPalabra = new DevExpress.XtraEditors.TextEdit();
            this.lvlResultado = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalabra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Buscar Por :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbSelect);
            this.groupControl1.Controls.Add(this.txtPalabra);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(438, 63);
            this.groupControl1.TabIndex = 1;
            // 
            // cmbSelect
            // 
            this.cmbSelect.EditValue = "Codigo";
            this.cmbSelect.Location = new System.Drawing.Point(91, 30);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Properties.AutoComplete = false;
            this.cmbSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSelect.Properties.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Apellidos"});
            this.cmbSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSelect.Size = new System.Drawing.Size(143, 20);
            this.cmbSelect.TabIndex = 3;
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(240, 30);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(187, 20);
            this.txtPalabra.TabIndex = 2;
            this.txtPalabra.EditValueChanged += new System.EventHandler(this.txtPalabra_EditValueChanged);
            // 
            // lvlResultado
            // 
            this.lvlResultado.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvlResultado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvlResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlResultado.FullRowSelect = true;
            this.lvlResultado.GridLines = true;
            this.lvlResultado.Location = new System.Drawing.Point(0, 63);
            this.lvlResultado.Name = "lvlResultado";
            this.lvlResultado.Size = new System.Drawing.Size(438, 150);
            this.lvlResultado.TabIndex = 2;
            this.lvlResultado.UseCompatibleStateImageBehavior = false;
            this.lvlResultado.View = System.Windows.Forms.View.Details;
            this.lvlResultado.SelectedIndexChanged += new System.EventHandler(this.lvlResultado_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 270;
            // 
            // BusqEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 213);
            this.Controls.Add(this.lvlResultado);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BusqEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Empleados";
            this.Load += new System.EventHandler(this.BusqEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalabra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPalabra;
        private System.Windows.Forms.ListView lvlResultado;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSelect;
    }
}
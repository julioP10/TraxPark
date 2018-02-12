namespace TraxPark.Windows
{
    partial class Ven_IngresosEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ven_IngresosEgresos));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rddlConcepto = new Telerik.WinControls.UI.RadDropDownList();
            this.txtImporte = new Telerik.WinControls.UI.RadTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddlConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.labelControl3);
            this.radGroupBox1.Controls.Add(this.rddlConcepto);
            this.radGroupBox1.Controls.Add(this.txtImporte);
            this.radGroupBox1.Controls.Add(this.labelControl2);
            this.radGroupBox1.Controls.Add(this.labelControl1);
            this.radGroupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Datos";
            this.radGroupBox1.Location = new System.Drawing.Point(21, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(302, 127);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Datos";
            // 
            // rddlConcepto
            // 
            this.rddlConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rddlConcepto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddlConcepto.Location = new System.Drawing.Point(113, 75);
            this.rddlConcepto.Name = "rddlConcepto";
            this.rddlConcepto.Size = new System.Drawing.Size(146, 20);
            this.rddlConcepto.TabIndex = 3;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(113, 41);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(103, 20);
            this.txtImporte.TabIndex = 0;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(39, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Concepto :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(48, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Importe :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(226, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "soles";
            // 
            // sbAplicar
            // 
            this.sbAplicar.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbAplicar.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbAplicar.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbAplicar.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAplicar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbAplicar.Appearance.Options.UseBackColor = true;
            this.sbAplicar.Appearance.Options.UseBorderColor = true;
            this.sbAplicar.Appearance.Options.UseFont = true;
            this.sbAplicar.Appearance.Options.UseForeColor = true;
            this.sbAplicar.Appearance.Options.UseImage = true;
            this.sbAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbAplicar.Cursor = System.Windows.Forms.Cursors.Default;
            this.sbAplicar.Image = ((System.Drawing.Image)(resources.GetObject("sbAplicar.Image")));
            this.sbAplicar.Location = new System.Drawing.Point(127, 146);
            this.sbAplicar.Name = "sbAplicar";
            this.sbAplicar.Size = new System.Drawing.Size(95, 35);
            this.sbAplicar.TabIndex = 3;
            this.sbAplicar.Text = "APLICAR";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseImage = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(228, 146);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 35);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "LIMPIAR";
            // 
            // Ven_IngresosEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 193);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbAplicar);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Ven_IngresosEgresos";
            this.Text = "Ven_IngresosEgresos";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddlConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Telerik.WinControls.UI.RadTextBox txtImporte;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Telerik.WinControls.UI.RadDropDownList rddlConcepto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbAplicar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
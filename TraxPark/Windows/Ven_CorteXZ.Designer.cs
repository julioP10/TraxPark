namespace TraxPark.Windows
{
    partial class Ven_CorteXZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ven_CorteXZ));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.sbLimpiar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radTextBoxControl1);
            this.radGroupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Datos del Corte";
            this.radGroupBox1.Location = new System.Drawing.Point(20, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(327, 479);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Datos del Corte";
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.Location = new System.Drawing.Point(16, 21);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(295, 445);
            this.radTextBoxControl1.TabIndex = 0;
            // 
            // sbLimpiar
            // 
            this.sbLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbLimpiar.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbLimpiar.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbLimpiar.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbLimpiar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLimpiar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbLimpiar.Appearance.Options.UseBackColor = true;
            this.sbLimpiar.Appearance.Options.UseBorderColor = true;
            this.sbLimpiar.Appearance.Options.UseFont = true;
            this.sbLimpiar.Appearance.Options.UseForeColor = true;
            this.sbLimpiar.Appearance.Options.UseImage = true;
            this.sbLimpiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("sbLimpiar.Image")));
            this.sbLimpiar.Location = new System.Drawing.Point(132, 497);
            this.sbLimpiar.Name = "sbLimpiar";
            this.sbLimpiar.Size = new System.Drawing.Size(119, 35);
            this.sbLimpiar.TabIndex = 13;
            this.sbLimpiar.Text = "IMPRIMIR";
            // 
            // Ven_CorteXZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 541);
            this.Controls.Add(this.sbLimpiar);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Ven_CorteXZ";
            this.Text = "Ven_CorteXZ";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private DevExpress.XtraEditors.SimpleButton sbLimpiar;

    }
}
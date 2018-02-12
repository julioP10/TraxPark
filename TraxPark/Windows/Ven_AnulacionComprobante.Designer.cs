namespace TraxPark.Windows
{
    partial class Ven_AnulacionComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ven_AnulacionComprobante));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerie = new Telerik.WinControls.UI.RadTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerie2 = new Telerik.WinControls.UI.RadTextBox();
            this.sbAnular = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.rddlTipoDocumento = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo de Documento :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(102, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Serie :";
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(153, 56);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(50, 20);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.TabStop = false;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(212, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(3, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "-";
            // 
            // txtSerie2
            // 
            this.txtSerie2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie2.Location = new System.Drawing.Point(225, 56);
            this.txtSerie2.Name = "txtSerie2";
            this.txtSerie2.Size = new System.Drawing.Size(85, 20);
            this.txtSerie2.TabIndex = 2;
            this.txtSerie2.TabStop = false;
            this.txtSerie2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie2_KeyPress);
            // 
            // sbAnular
            // 
            this.sbAnular.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbAnular.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbAnular.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbAnular.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAnular.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbAnular.Appearance.Options.UseBackColor = true;
            this.sbAnular.Appearance.Options.UseBorderColor = true;
            this.sbAnular.Appearance.Options.UseFont = true;
            this.sbAnular.Appearance.Options.UseForeColor = true;
            this.sbAnular.Appearance.Options.UseImage = true;
            this.sbAnular.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbAnular.Image = ((System.Drawing.Image)(resources.GetObject("sbAnular.Image")));
            this.sbAnular.Location = new System.Drawing.Point(42, 92);
            this.sbAnular.Name = "sbAnular";
            this.sbAnular.Size = new System.Drawing.Size(110, 35);
            this.sbAnular.TabIndex = 3;
            this.sbAnular.Text = "ANULAR";
            // 
            // sbImprimir
            // 
            this.sbImprimir.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbImprimir.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbImprimir.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbImprimir.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbImprimir.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbImprimir.Appearance.Options.UseBackColor = true;
            this.sbImprimir.Appearance.Options.UseBorderColor = true;
            this.sbImprimir.Appearance.Options.UseFont = true;
            this.sbImprimir.Appearance.Options.UseForeColor = true;
            this.sbImprimir.Appearance.Options.UseImage = true;
            this.sbImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("sbImprimir.Image")));
            this.sbImprimir.Location = new System.Drawing.Point(186, 93);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(110, 35);
            this.sbImprimir.TabIndex = 4;
            this.sbImprimir.Text = "IMPRIMIR";
            // 
            // rddlTipoDocumento
            // 
            this.rddlTipoDocumento.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddlTipoDocumento.Location = new System.Drawing.Point(153, 22);
            this.rddlTipoDocumento.Name = "rddlTipoDocumento";
            this.rddlTipoDocumento.Size = new System.Drawing.Size(157, 20);
            this.rddlTipoDocumento.TabIndex = 5;
            // 
            // Ven_AnulacionComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 153);
            this.Controls.Add(this.rddlTipoDocumento);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbAnular);
            this.Controls.Add(this.txtSerie2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Ven_AnulacionComprobante";
            this.Text = "Ven_AnulacionComprobante";
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTipoDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Telerik.WinControls.UI.RadTextBox txtSerie;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Telerik.WinControls.UI.RadTextBox txtSerie2;
        private DevExpress.XtraEditors.SimpleButton sbAnular;
        private DevExpress.XtraEditors.SimpleButton sbImprimir;
        private Telerik.WinControls.UI.RadDropDownList rddlTipoDocumento;
    }
}
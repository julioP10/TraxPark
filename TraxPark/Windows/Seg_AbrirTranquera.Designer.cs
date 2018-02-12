namespace TraxPark.Windows
{
    partial class Seg_AbrirTranquera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seg_AbrirTranquera));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rddlTranquera = new Telerik.WinControls.UI.RadDropDownList();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbAbrir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTranquera)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rddlTranquera);
            this.radGroupBox1.Controls.Add(this.labelControl1);
            this.radGroupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Tranquera";
            this.radGroupBox1.Location = new System.Drawing.Point(19, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(259, 75);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Tranquera";
            // 
            // rddlTranquera
            // 
            this.rddlTranquera.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddlTranquera.Location = new System.Drawing.Point(92, 33);
            this.rddlTranquera.Name = "rddlTranquera";
            this.rddlTranquera.Size = new System.Drawing.Size(125, 20);
            this.rddlTranquera.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tranquera :";
            // 
            // sbAbrir
            // 
            this.sbAbrir.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.sbAbrir.Appearance.BackColor2 = System.Drawing.Color.PowderBlue;
            this.sbAbrir.Appearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.sbAbrir.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAbrir.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbAbrir.Appearance.Options.UseBackColor = true;
            this.sbAbrir.Appearance.Options.UseBorderColor = true;
            this.sbAbrir.Appearance.Options.UseFont = true;
            this.sbAbrir.Appearance.Options.UseForeColor = true;
            this.sbAbrir.Appearance.Options.UseImage = true;
            this.sbAbrir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbAbrir.Image = ((System.Drawing.Image)(resources.GetObject("sbAbrir.Image")));
            this.sbAbrir.Location = new System.Drawing.Point(156, 103);
            this.sbAbrir.Name = "sbAbrir";
            this.sbAbrir.Size = new System.Drawing.Size(110, 35);
            this.sbAbrir.TabIndex = 2;
            this.sbAbrir.Text = "REINICIAR";
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
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(19, 103);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 35);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "ABRIR";
            // 
            // Seg_AbrirTranquera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 153);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbAbrir);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Seg_AbrirTranquera";
            this.Text = "Seg_AbrirTranquera";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddlTranquera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbAbrir;
        private Telerik.WinControls.UI.RadDropDownList rddlTranquera;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
namespace TraxPark.Windows.Seguridad
{
    partial class Seg_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seg_Login));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtContraseña = new Telerik.WinControls.UI.RadTextBox();
            this.TxtEstacion = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnIniciarSesion = new Telerik.WinControls.UI.RadButton();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.BtnProceso = new Telerik.WinControls.UI.RadButton();
            this.LblFecha = new Telerik.WinControls.UI.RadLabel();
            this.BtnCerrar = new Telerik.WinControls.UI.RadButton();
            this.TxtUsuario = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(499, 300);
            this.pictureEdit1.TabIndex = 0;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.CausesValidation = false;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(277, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.ShowToolTips = false;
            this.pictureEdit2.Size = new System.Drawing.Size(183, 69);
            this.pictureEdit2.TabIndex = 1;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(323, 82);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(142, 137);
            this.pictureEdit3.TabIndex = 2;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(163, 133);
            this.TxtContraseña.MaxLength = 15;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.NullText = "Ingresar Contraseña";
            this.TxtContraseña.PasswordChar = '●';
            this.TxtContraseña.ShowClearButton = true;
            this.TxtContraseña.Size = new System.Drawing.Size(165, 21);
            this.TxtContraseña.TabIndex = 2;
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtContraseña.GetChildAt(0).GetChildAt(0))).NullText = "Ingresar Contraseña";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtContraseña.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtEstacion
            // 
            this.TxtEstacion.Enabled = false;
            this.TxtEstacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstacion.Location = new System.Drawing.Point(163, 157);
            this.TxtEstacion.Name = "TxtEstacion";
            this.TxtEstacion.Size = new System.Drawing.Size(165, 21);
            this.TxtEstacion.TabIndex = 5;
            this.TxtEstacion.Text = "ESTACION 01";
            this.TxtEstacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.White;
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(95, 109);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Usuario :";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.White;
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(73, 134);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(85, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Contraseña :";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.White;
            this.radLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(23, 159);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(137, 18);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Estación de Trabajo :";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(23, 228);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Size = new System.Drawing.Size(455, 58);
            this.pictureEdit4.TabIndex = 9;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnIniciarSesion.Image")));
            this.BtnIniciarSesion.Location = new System.Drawing.Point(173, 184);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(147, 30);
            this.BtnIniciarSesion.TabIndex = 3;
            this.BtnIniciarSesion.Text = "   Iniciar Sesión";
            this.BtnIniciarSesion.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BtnProceso
            // 
            this.BtnProceso.AutoSize = true;
            this.BtnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BtnProceso.Enabled = false;
            this.BtnProceso.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProceso.Image = ((System.Drawing.Image)(resources.GetObject("BtnProceso.Image")));
            this.BtnProceso.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnProceso.Location = new System.Drawing.Point(108, 183);
            this.BtnProceso.Name = "BtnProceso";
            this.BtnProceso.Size = new System.Drawing.Size(34, 34);
            this.BtnProceso.TabIndex = 11;
            this.BtnProceso.Visible = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnProceso.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnProceso.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnProceso.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnProceso.GetChildAt(0))).ShadowColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnProceso.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).TopColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).RightColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).BottomColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).LeftShadowColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).TopShadowColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).RightShadowColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).ForeColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).ForeColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).ForeColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).InnerColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).InnerColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).InnerColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).InnerColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnProceso.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.White;
            // 
            // LblFecha
            // 
            this.LblFecha.BackColor = System.Drawing.Color.White;
            this.LblFecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.Gray;
            this.LblFecha.Location = new System.Drawing.Point(151, 82);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(28, 18);
            this.LblFecha.TabIndex = 12;
            this.LblFecha.Text = "----";
            this.LblFecha.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Gray;
            this.BtnCerrar.Location = new System.Drawing.Point(457, 16);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(26, 19);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.TxtUsuario.Location = new System.Drawing.Point(163, 108);
            this.TxtUsuario.MaxLength = 15;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.NullText = "Ingresar Usuario";
            this.TxtUsuario.ShowClearButton = true;
            this.TxtUsuario.Size = new System.Drawing.Size(165, 21);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // Seg_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 300);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.BtnProceso);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtEstacion);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seg_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seg_Login";
            this.Load += new System.EventHandler(this.Seg_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private Telerik.WinControls.UI.RadTextBox TxtContraseña;
        private Telerik.WinControls.UI.RadTextBox TxtEstacion;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private Telerik.WinControls.UI.RadButton BtnIniciarSesion;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton BtnProceso;
        private Telerik.WinControls.UI.RadLabel LblFecha;
        private Telerik.WinControls.UI.RadButton BtnCerrar;
        private Telerik.WinControls.UI.RadTextBox TxtUsuario;
    }
}
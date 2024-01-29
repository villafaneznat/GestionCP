namespace ProyectoSeminario.Windows.Login
{
    partial class IniciarSesionForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelNombreUser = new System.Windows.Forms.Panel();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.IconPictureUser = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelContraseña = new System.Windows.Forms.Panel();
            this.IconPicturePass = new FontAwesome.Sharp.IconPictureBox();
            this.gunaElipseIS = new Guna.UI.WinForms.GunaElipse(this.components);
            this.IniciarSesionBtn = new System.Windows.Forms.Button();
            this.gunaElipsePass = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipseUser = new Guna.UI.WinForms.GunaElipse(this.components);
            this.IconButtonVerPassw = new FontAwesome.Sharp.IconButton();
            this.IconPictureClose = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelNombreUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureUser)).BeginInit();
            this.PanelContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicturePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(520, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Iniciar Sesion";
            // 
            // PanelNombreUser
            // 
            this.PanelNombreUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.PanelNombreUser.Controls.Add(this.textBoxNombreUser);
            this.PanelNombreUser.Controls.Add(this.IconPictureUser);
            this.PanelNombreUser.Location = new System.Drawing.Point(476, 135);
            this.PanelNombreUser.Name = "PanelNombreUser";
            this.PanelNombreUser.Size = new System.Drawing.Size(265, 55);
            this.PanelNombreUser.TabIndex = 10;
            // 
            // textBoxNombreUser
            // 
            this.textBoxNombreUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.textBoxNombreUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.textBoxNombreUser.Location = new System.Drawing.Point(51, 18);
            this.textBoxNombreUser.Name = "textBoxNombreUser";
            this.textBoxNombreUser.Size = new System.Drawing.Size(203, 18);
            this.textBoxNombreUser.TabIndex = 9;
            this.textBoxNombreUser.Text = "Nombre de usuario";
            this.textBoxNombreUser.Enter += new System.EventHandler(this.textBoxNombreUser_Enter);
            this.textBoxNombreUser.Leave += new System.EventHandler(this.textBoxNombreUser_Leave);
            // 
            // IconPictureUser
            // 
            this.IconPictureUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.IconPictureUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.IconPictureUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureUser.Location = new System.Drawing.Point(8, 11);
            this.IconPictureUser.Name = "IconPictureUser";
            this.IconPictureUser.Size = new System.Drawing.Size(32, 32);
            this.IconPictureUser.TabIndex = 8;
            this.IconPictureUser.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.textBoxPassword.Location = new System.Drawing.Point(51, 19);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 18);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.Text = "Contraseña";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // PanelContraseña
            // 
            this.PanelContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.PanelContraseña.Controls.Add(this.textBoxPassword);
            this.PanelContraseña.Controls.Add(this.IconPicturePass);
            this.PanelContraseña.Location = new System.Drawing.Point(476, 243);
            this.PanelContraseña.Name = "PanelContraseña";
            this.PanelContraseña.Size = new System.Drawing.Size(265, 55);
            this.PanelContraseña.TabIndex = 11;
            // 
            // IconPicturePass
            // 
            this.IconPicturePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.IconPicturePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPicturePass.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.IconPicturePass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPicturePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPicturePass.Location = new System.Drawing.Point(7, 11);
            this.IconPicturePass.Name = "IconPicturePass";
            this.IconPicturePass.Size = new System.Drawing.Size(32, 32);
            this.IconPicturePass.TabIndex = 8;
            this.IconPicturePass.TabStop = false;
            // 
            // gunaElipseIS
            // 
            this.gunaElipseIS.Radius = 3;
            this.gunaElipseIS.TargetControl = this.IniciarSesionBtn;
            // 
            // IniciarSesionBtn
            // 
            this.IniciarSesionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.IniciarSesionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSesionBtn.FlatAppearance.BorderSize = 0;
            this.IniciarSesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesionBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionBtn.ForeColor = System.Drawing.Color.White;
            this.IniciarSesionBtn.Location = new System.Drawing.Point(527, 360);
            this.IniciarSesionBtn.Margin = new System.Windows.Forms.Padding(7);
            this.IniciarSesionBtn.Name = "IniciarSesionBtn";
            this.IniciarSesionBtn.Padding = new System.Windows.Forms.Padding(3);
            this.IniciarSesionBtn.Size = new System.Drawing.Size(170, 45);
            this.IniciarSesionBtn.TabIndex = 5;
            this.IniciarSesionBtn.Text = "INICIAR SESION";
            this.IniciarSesionBtn.UseVisualStyleBackColor = false;
            this.IniciarSesionBtn.Click += new System.EventHandler(this.IniciarSesionBtn_Click);
            // 
            // gunaElipsePass
            // 
            this.gunaElipsePass.Radius = 2;
            this.gunaElipsePass.TargetControl = this.PanelContraseña;
            // 
            // gunaElipseUser
            // 
            this.gunaElipseUser.Radius = 2;
            this.gunaElipseUser.TargetControl = this.PanelNombreUser;
            // 
            // IconButtonVerPassw
            // 
            this.IconButtonVerPassw.BackColor = System.Drawing.Color.Transparent;
            this.IconButtonVerPassw.FlatAppearance.BorderSize = 0;
            this.IconButtonVerPassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButtonVerPassw.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IconButtonVerPassw.IconColor = System.Drawing.Color.Gray;
            this.IconButtonVerPassw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconButtonVerPassw.IconSize = 30;
            this.IconButtonVerPassw.Location = new System.Drawing.Point(747, 254);
            this.IconButtonVerPassw.Name = "IconButtonVerPassw";
            this.IconButtonVerPassw.Size = new System.Drawing.Size(41, 32);
            this.IconButtonVerPassw.TabIndex = 14;
            this.IconButtonVerPassw.UseVisualStyleBackColor = false;
            this.IconButtonVerPassw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconButtonVerPassw_MouseDown);
            this.IconButtonVerPassw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconButtonVerPassw_MouseUp);
            // 
            // IconPictureClose
            // 
            this.IconPictureClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconPictureClose.BackColor = System.Drawing.Color.Transparent;
            this.IconPictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconPictureClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.IconPictureClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureClose.IconSize = 22;
            this.IconPictureClose.Location = new System.Drawing.Point(773, 3);
            this.IconPictureClose.Name = "IconPictureClose";
            this.IconPictureClose.Size = new System.Drawing.Size(36, 22);
            this.IconPictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconPictureClose.TabIndex = 13;
            this.IconPictureClose.TabStop = false;
            this.IconPictureClose.Click += new System.EventHandler(this.IconPictureClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 483);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!";
            // 
            // IniciarSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.ControlBox = false;
            this.Controls.Add(this.IconButtonVerPassw);
            this.Controls.Add(this.IconPictureClose);
            this.Controls.Add(this.PanelContraseña);
            this.Controls.Add(this.PanelNombreUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IniciarSesionBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(811, 483);
            this.MinimumSize = new System.Drawing.Size(811, 483);
            this.Name = "IniciarSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IniciarSesionForm_Load);
            this.PanelNombreUser.ResumeLayout(false);
            this.PanelNombreUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureUser)).EndInit();
            this.PanelContraseña.ResumeLayout(false);
            this.PanelContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicturePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IniciarSesionBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox IconPictureUser;
        private System.Windows.Forms.Panel PanelNombreUser;
        private System.Windows.Forms.TextBox textBoxNombreUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private FontAwesome.Sharp.IconPictureBox IconPicturePass;
        private System.Windows.Forms.Panel PanelContraseña;
        private Guna.UI.WinForms.GunaElipse gunaElipseIS;
        private Guna.UI.WinForms.GunaElipse gunaElipsePass;
        private Guna.UI.WinForms.GunaElipse gunaElipseUser;
        private FontAwesome.Sharp.IconPictureBox IconPictureClose;
        private FontAwesome.Sharp.IconButton IconButtonVerPassw;
    }
}
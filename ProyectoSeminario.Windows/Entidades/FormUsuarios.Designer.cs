namespace ProyectoSeminario.Windows.Entidades
{
    partial class FormUsuarios
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
            this.FlowLayoutPanelUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelNombreUser = new System.Windows.Forms.Panel();
            this.txtBuscarProfesional = new System.Windows.Forms.TextBox();
            this.IconPictureUser = new FontAwesome.Sharp.IconPictureBox();
            this.AgregarUsuarioButton = new FontAwesome.Sharp.IconButton();
            this.PanelNombreUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPanelUsuarios
            // 
            this.FlowLayoutPanelUsuarios.AutoScroll = true;
            this.FlowLayoutPanelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FlowLayoutPanelUsuarios.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanelUsuarios.Location = new System.Drawing.Point(0, 65);
            this.FlowLayoutPanelUsuarios.Name = "FlowLayoutPanelUsuarios";
            this.FlowLayoutPanelUsuarios.Padding = new System.Windows.Forms.Padding(10);
            this.FlowLayoutPanelUsuarios.Size = new System.Drawing.Size(773, 383);
            this.FlowLayoutPanelUsuarios.TabIndex = 1;
            // 
            // PanelNombreUser
            // 
            this.PanelNombreUser.BackColor = System.Drawing.Color.White;
            this.PanelNombreUser.Controls.Add(this.txtBuscarProfesional);
            this.PanelNombreUser.Controls.Add(this.IconPictureUser);
            this.PanelNombreUser.Location = new System.Drawing.Point(514, 9);
            this.PanelNombreUser.Name = "PanelNombreUser";
            this.PanelNombreUser.Size = new System.Drawing.Size(246, 45);
            this.PanelNombreUser.TabIndex = 14;
            // 
            // txtBuscarProfesional
            // 
            this.txtBuscarProfesional.BackColor = System.Drawing.Color.White;
            this.txtBuscarProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProfesional.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProfesional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtBuscarProfesional.Location = new System.Drawing.Point(44, 16);
            this.txtBuscarProfesional.Name = "txtBuscarProfesional";
            this.txtBuscarProfesional.Size = new System.Drawing.Size(203, 16);
            this.txtBuscarProfesional.TabIndex = 9;
            this.txtBuscarProfesional.Text = "Buscar usuario...";
            // 
            // IconPictureUser
            // 
            this.IconPictureUser.BackColor = System.Drawing.Color.White;
            this.IconPictureUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureUser.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IconPictureUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureUser.IconSize = 30;
            this.IconPictureUser.Location = new System.Drawing.Point(6, 7);
            this.IconPictureUser.Name = "IconPictureUser";
            this.IconPictureUser.Size = new System.Drawing.Size(32, 32);
            this.IconPictureUser.TabIndex = 8;
            this.IconPictureUser.TabStop = false;
            // 
            // AgregarUsuarioButton
            // 
            this.AgregarUsuarioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.AgregarUsuarioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarUsuarioButton.FlatAppearance.BorderSize = 0;
            this.AgregarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarUsuarioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuarioButton.ForeColor = System.Drawing.Color.White;
            this.AgregarUsuarioButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.AgregarUsuarioButton.IconColor = System.Drawing.Color.White;
            this.AgregarUsuarioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarUsuarioButton.IconSize = 25;
            this.AgregarUsuarioButton.Location = new System.Drawing.Point(338, 9);
            this.AgregarUsuarioButton.Name = "AgregarUsuarioButton";
            this.AgregarUsuarioButton.Padding = new System.Windows.Forms.Padding(2);
            this.AgregarUsuarioButton.Size = new System.Drawing.Size(158, 45);
            this.AgregarUsuarioButton.TabIndex = 13;
            this.AgregarUsuarioButton.Text = "  Agregar Usuario";
            this.AgregarUsuarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarUsuarioButton.UseVisualStyleBackColor = false;
            this.AgregarUsuarioButton.Click += new System.EventHandler(this.AgregarUsuarioButton_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 449);
            this.ControlBox = false;
            this.Controls.Add(this.PanelNombreUser);
            this.Controls.Add(this.AgregarUsuarioButton);
            this.Controls.Add(this.FlowLayoutPanelUsuarios);
            this.Name = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.PanelNombreUser.ResumeLayout(false);
            this.PanelNombreUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelUsuarios;
        private System.Windows.Forms.Panel PanelNombreUser;
        private System.Windows.Forms.TextBox txtBuscarProfesional;
        private FontAwesome.Sharp.IconPictureBox IconPictureUser;
        private FontAwesome.Sharp.IconButton AgregarUsuarioButton;
    }
}
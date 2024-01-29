namespace ProyectoSeminario.Windows.Entidades
{
    partial class FormProfesionales
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
            this.FlowLayoutPanelProfesionales = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelNombreUser = new System.Windows.Forms.Panel();
            this.txtBuscarProfesional = new System.Windows.Forms.TextBox();
            this.IconPictureUser = new FontAwesome.Sharp.IconPictureBox();
            this.AgregarProfesionalButton = new FontAwesome.Sharp.IconButton();
            this.PanelNombreUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPanelProfesionales
            // 
            this.FlowLayoutPanelProfesionales.AutoScroll = true;
            this.FlowLayoutPanelProfesionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FlowLayoutPanelProfesionales.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanelProfesionales.Location = new System.Drawing.Point(0, 68);
            this.FlowLayoutPanelProfesionales.Name = "FlowLayoutPanelProfesionales";
            this.FlowLayoutPanelProfesionales.Padding = new System.Windows.Forms.Padding(10);
            this.FlowLayoutPanelProfesionales.Size = new System.Drawing.Size(773, 428);
            this.FlowLayoutPanelProfesionales.TabIndex = 0;
            // 
            // PanelNombreUser
            // 
            this.PanelNombreUser.BackColor = System.Drawing.Color.White;
            this.PanelNombreUser.Controls.Add(this.txtBuscarProfesional);
            this.PanelNombreUser.Controls.Add(this.IconPictureUser);
            this.PanelNombreUser.Location = new System.Drawing.Point(495, 13);
            this.PanelNombreUser.Name = "PanelNombreUser";
            this.PanelNombreUser.Size = new System.Drawing.Size(246, 45);
            this.PanelNombreUser.TabIndex = 11;
            // 
            // txtBuscarProfesional
            // 
            this.txtBuscarProfesional.BackColor = System.Drawing.Color.White;
            this.txtBuscarProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProfesional.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProfesional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtBuscarProfesional.Location = new System.Drawing.Point(44, 13);
            this.txtBuscarProfesional.Name = "txtBuscarProfesional";
            this.txtBuscarProfesional.Size = new System.Drawing.Size(203, 16);
            this.txtBuscarProfesional.TabIndex = 9;
            this.txtBuscarProfesional.Text = "Buscar profesional...";
            this.txtBuscarProfesional.TextChanged += new System.EventHandler(this.txtBuscarProfesional_TextChanged);
            this.txtBuscarProfesional.Enter += new System.EventHandler(this.txtBuscarProfesional_Enter);
            this.txtBuscarProfesional.Leave += new System.EventHandler(this.txtBuscarProfesional_Leave);
            // 
            // IconPictureUser
            // 
            this.IconPictureUser.BackColor = System.Drawing.Color.White;
            this.IconPictureUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureUser.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IconPictureUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IconPictureUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureUser.IconSize = 30;
            this.IconPictureUser.Location = new System.Drawing.Point(6, 5);
            this.IconPictureUser.Name = "IconPictureUser";
            this.IconPictureUser.Size = new System.Drawing.Size(32, 32);
            this.IconPictureUser.TabIndex = 8;
            this.IconPictureUser.TabStop = false;
            // 
            // AgregarProfesionalButton
            // 
            this.AgregarProfesionalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.AgregarProfesionalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarProfesionalButton.FlatAppearance.BorderSize = 0;
            this.AgregarProfesionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarProfesionalButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProfesionalButton.ForeColor = System.Drawing.Color.White;
            this.AgregarProfesionalButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.AgregarProfesionalButton.IconColor = System.Drawing.Color.White;
            this.AgregarProfesionalButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarProfesionalButton.IconSize = 25;
            this.AgregarProfesionalButton.Location = new System.Drawing.Point(308, 11);
            this.AgregarProfesionalButton.Name = "AgregarProfesionalButton";
            this.AgregarProfesionalButton.Padding = new System.Windows.Forms.Padding(2);
            this.AgregarProfesionalButton.Size = new System.Drawing.Size(158, 45);
            this.AgregarProfesionalButton.TabIndex = 2;
            this.AgregarProfesionalButton.Text = "  Agregar Profesional";
            this.AgregarProfesionalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarProfesionalButton.UseVisualStyleBackColor = false;
            this.AgregarProfesionalButton.Click += new System.EventHandler(this.AgregarProfesionalButton_Click);
            // 
            // FormProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(772, 495);
            this.ControlBox = false;
            this.Controls.Add(this.PanelNombreUser);
            this.Controls.Add(this.AgregarProfesionalButton);
            this.Controls.Add(this.FlowLayoutPanelProfesionales);
            this.Name = "FormProfesionales";
            this.Load += new System.EventHandler(this.FormProfesionales_Load);
            this.PanelNombreUser.ResumeLayout(false);
            this.PanelNombreUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelProfesionales;
        private FontAwesome.Sharp.IconButton AgregarProfesionalButton;
        private System.Windows.Forms.Panel PanelNombreUser;
        private System.Windows.Forms.TextBox txtBuscarProfesional;
        private FontAwesome.Sharp.IconPictureBox IconPictureUser;
    }
}
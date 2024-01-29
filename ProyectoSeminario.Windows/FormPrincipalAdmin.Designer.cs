namespace ProyectoSeminario.Windows
{
    partial class FormPrincipalAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.UsuariosIconButton = new FontAwesome.Sharp.IconButton();
            this.CloseIconButton = new FontAwesome.Sharp.IconButton();
            this.HistoriasIconButton = new FontAwesome.Sharp.IconButton();
            this.PacientesIconButton = new FontAwesome.Sharp.IconButton();
            this.ProfesionalesIconButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelTopLabel = new System.Windows.Forms.Label();
            this.PanelTopIconPicture = new FontAwesome.Sharp.IconPictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTopIconPicture)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.panelMenu.Controls.Add(this.UsuariosIconButton);
            this.panelMenu.Controls.Add(this.CloseIconButton);
            this.panelMenu.Controls.Add(this.HistoriasIconButton);
            this.panelMenu.Controls.Add(this.PacientesIconButton);
            this.panelMenu.Controls.Add(this.ProfesionalesIconButton);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 576);
            this.panelMenu.TabIndex = 0;
            // 
            // UsuariosIconButton
            // 
            this.UsuariosIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosIconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsuariosIconButton.FlatAppearance.BorderSize = 0;
            this.UsuariosIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuariosIconButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosIconButton.ForeColor = System.Drawing.Color.White;
            this.UsuariosIconButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.UsuariosIconButton.IconColor = System.Drawing.Color.White;
            this.UsuariosIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuariosIconButton.IconSize = 36;
            this.UsuariosIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsuariosIconButton.Location = new System.Drawing.Point(0, 320);
            this.UsuariosIconButton.Name = "UsuariosIconButton";
            this.UsuariosIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UsuariosIconButton.Size = new System.Drawing.Size(220, 60);
            this.UsuariosIconButton.TabIndex = 5;
            this.UsuariosIconButton.Text = "Usuarios";
            this.UsuariosIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsuariosIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsuariosIconButton.UseVisualStyleBackColor = true;
            this.UsuariosIconButton.Click += new System.EventHandler(this.UsuariosIconButton_Click);
            // 
            // CloseIconButton
            // 
            this.CloseIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseIconButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseIconButton.FlatAppearance.BorderSize = 0;
            this.CloseIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseIconButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseIconButton.ForeColor = System.Drawing.Color.White;
            this.CloseIconButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.CloseIconButton.IconColor = System.Drawing.Color.White;
            this.CloseIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseIconButton.IconSize = 36;
            this.CloseIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseIconButton.Location = new System.Drawing.Point(0, 516);
            this.CloseIconButton.Name = "CloseIconButton";
            this.CloseIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CloseIconButton.Size = new System.Drawing.Size(220, 60);
            this.CloseIconButton.TabIndex = 4;
            this.CloseIconButton.Text = "Cerrar Sesion";
            this.CloseIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseIconButton.UseVisualStyleBackColor = true;
            this.CloseIconButton.Click += new System.EventHandler(this.CloseIconButton_Click);
            // 
            // HistoriasIconButton
            // 
            this.HistoriasIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoriasIconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoriasIconButton.FlatAppearance.BorderSize = 0;
            this.HistoriasIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoriasIconButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoriasIconButton.ForeColor = System.Drawing.Color.White;
            this.HistoriasIconButton.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.HistoriasIconButton.IconColor = System.Drawing.Color.White;
            this.HistoriasIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HistoriasIconButton.IconSize = 36;
            this.HistoriasIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistoriasIconButton.Location = new System.Drawing.Point(0, 260);
            this.HistoriasIconButton.Name = "HistoriasIconButton";
            this.HistoriasIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HistoriasIconButton.Size = new System.Drawing.Size(220, 60);
            this.HistoriasIconButton.TabIndex = 3;
            this.HistoriasIconButton.Text = "Historias Clínicas";
            this.HistoriasIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistoriasIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HistoriasIconButton.UseVisualStyleBackColor = true;
            this.HistoriasIconButton.Click += new System.EventHandler(this.HistoriasIconButton_Click);
            // 
            // PacientesIconButton
            // 
            this.PacientesIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PacientesIconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PacientesIconButton.FlatAppearance.BorderSize = 0;
            this.PacientesIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PacientesIconButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacientesIconButton.ForeColor = System.Drawing.Color.White;
            this.PacientesIconButton.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.PacientesIconButton.IconColor = System.Drawing.Color.White;
            this.PacientesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PacientesIconButton.IconSize = 36;
            this.PacientesIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PacientesIconButton.Location = new System.Drawing.Point(0, 200);
            this.PacientesIconButton.Name = "PacientesIconButton";
            this.PacientesIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PacientesIconButton.Size = new System.Drawing.Size(220, 60);
            this.PacientesIconButton.TabIndex = 2;
            this.PacientesIconButton.Text = "Pacientes";
            this.PacientesIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PacientesIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PacientesIconButton.UseVisualStyleBackColor = true;
            this.PacientesIconButton.Click += new System.EventHandler(this.PacientesIconButton_Click);
            // 
            // ProfesionalesIconButton
            // 
            this.ProfesionalesIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfesionalesIconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfesionalesIconButton.FlatAppearance.BorderSize = 0;
            this.ProfesionalesIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfesionalesIconButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesionalesIconButton.ForeColor = System.Drawing.Color.White;
            this.ProfesionalesIconButton.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ProfesionalesIconButton.IconColor = System.Drawing.Color.White;
            this.ProfesionalesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProfesionalesIconButton.IconSize = 36;
            this.ProfesionalesIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfesionalesIconButton.Location = new System.Drawing.Point(0, 140);
            this.ProfesionalesIconButton.Name = "ProfesionalesIconButton";
            this.ProfesionalesIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProfesionalesIconButton.Size = new System.Drawing.Size(220, 60);
            this.ProfesionalesIconButton.TabIndex = 1;
            this.ProfesionalesIconButton.Text = "Profesionales";
            this.ProfesionalesIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfesionalesIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfesionalesIconButton.UseVisualStyleBackColor = true;
            this.ProfesionalesIconButton.Click += new System.EventHandler(this.ProfesionalesIconButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 84;
            this.iconPictureBox1.Location = new System.Drawing.Point(58, 27);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(94, 84);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.PanelTop.Controls.Add(this.PanelTopLabel);
            this.PanelTop.Controls.Add(this.PanelTopIconPicture);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(220, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(788, 65);
            this.PanelTop.TabIndex = 1;
            // 
            // PanelTopLabel
            // 
            this.PanelTopLabel.AutoSize = true;
            this.PanelTopLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTopLabel.ForeColor = System.Drawing.Color.White;
            this.PanelTopLabel.Location = new System.Drawing.Point(48, 27);
            this.PanelTopLabel.Name = "PanelTopLabel";
            this.PanelTopLabel.Size = new System.Drawing.Size(38, 13);
            this.PanelTopLabel.TabIndex = 1;
            this.PanelTopLabel.Text = "Home";
            // 
            // PanelTopIconPicture
            // 
            this.PanelTopIconPicture.BackColor = System.Drawing.Color.Transparent;
            this.PanelTopIconPicture.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.PanelTopIconPicture.IconColor = System.Drawing.Color.White;
            this.PanelTopIconPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PanelTopIconPicture.IconSize = 25;
            this.PanelTopIconPicture.Location = new System.Drawing.Point(20, 21);
            this.PanelTopIconPicture.Name = "PanelTopIconPicture";
            this.PanelTopIconPicture.Size = new System.Drawing.Size(25, 27);
            this.PanelTopIconPicture.TabIndex = 0;
            this.PanelTopIconPicture.TabStop = false;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(220, 65);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(788, 511);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(193, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido!";
            // 
            // FormPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 576);
            this.ControlBox = false;
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1024, 592);
            this.MinimumSize = new System.Drawing.Size(1024, 592);
            this.Name = "FormPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipalAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTopIconPicture)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ProfesionalesIconButton;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton HistoriasIconButton;
        private FontAwesome.Sharp.IconButton PacientesIconButton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton CloseIconButton;
        private FontAwesome.Sharp.IconButton UsuariosIconButton;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label PanelTopLabel;
        private FontAwesome.Sharp.IconPictureBox PanelTopIconPicture;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label1;
    }
}
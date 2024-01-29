namespace ProyectoSeminario.Windows.UsersConstrols
{
    partial class uc_usuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblUserName = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblRol = new System.Windows.Forms.Label();
            this.ImgUserIconPicture = new FontAwesome.Sharp.IconPictureBox();
            this.CargarImgBtn = new FontAwesome.Sharp.IconButton();
            this.BorrarImgBtn = new FontAwesome.Sharp.IconButton();
            this.EditUserBtn = new FontAwesome.Sharp.IconButton();
            this.VerPassButton = new FontAwesome.Sharp.IconButton();
            this.DeleteUserBtn = new FontAwesome.Sharp.IconButton();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUserIconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(166, 40);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(256, 37);
            this.LblUserName.TabIndex = 22;
            this.LblUserName.Text = "Nombre de Usuario";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rol.Location = new System.Drawing.Point(263, 179);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(43, 28);
            this.Rol.TabIndex = 25;
            this.Rol.Text = "Rol";
            this.Rol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSize = true;
            this.Contrasena.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contrasena.Location = new System.Drawing.Point(226, 101);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(118, 28);
            this.Contrasena.TabIndex = 19;
            this.Contrasena.Text = "Contraseña";
            this.Contrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.panel2.Location = new System.Drawing.Point(26, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 7);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.panel1.Location = new System.Drawing.Point(23, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 7);
            this.panel1.TabIndex = 29;
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblRol.Location = new System.Drawing.Point(240, 207);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(88, 21);
            this.LblRol.TabIndex = 30;
            this.LblRol.Text = "Profesional";
            this.LblRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgUserIconPicture
            // 
            this.ImgUserIconPicture.BackColor = System.Drawing.Color.White;
            this.ImgUserIconPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ImgUserIconPicture.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ImgUserIconPicture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ImgUserIconPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImgUserIconPicture.IconSize = 121;
            this.ImgUserIconPicture.Location = new System.Drawing.Point(32, 40);
            this.ImgUserIconPicture.Name = "ImgUserIconPicture";
            this.ImgUserIconPicture.Size = new System.Drawing.Size(121, 122);
            this.ImgUserIconPicture.TabIndex = 24;
            this.ImgUserIconPicture.TabStop = false;
            // 
            // CargarImgBtn
            // 
            this.CargarImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.CargarImgBtn.FlatAppearance.BorderSize = 0;
            this.CargarImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarImgBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarImgBtn.ForeColor = System.Drawing.Color.White;
            this.CargarImgBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.CargarImgBtn.IconColor = System.Drawing.Color.White;
            this.CargarImgBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CargarImgBtn.IconSize = 17;
            this.CargarImgBtn.Location = new System.Drawing.Point(28, 181);
            this.CargarImgBtn.Name = "CargarImgBtn";
            this.CargarImgBtn.Size = new System.Drawing.Size(131, 28);
            this.CargarImgBtn.TabIndex = 37;
            this.CargarImgBtn.Text = "Subir";
            this.CargarImgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CargarImgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CargarImgBtn.UseVisualStyleBackColor = false;
            // 
            // BorrarImgBtn
            // 
            this.BorrarImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BorrarImgBtn.FlatAppearance.BorderSize = 0;
            this.BorrarImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarImgBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarImgBtn.ForeColor = System.Drawing.Color.White;
            this.BorrarImgBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BorrarImgBtn.IconColor = System.Drawing.Color.White;
            this.BorrarImgBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarImgBtn.IconSize = 17;
            this.BorrarImgBtn.Location = new System.Drawing.Point(28, 217);
            this.BorrarImgBtn.Name = "BorrarImgBtn";
            this.BorrarImgBtn.Size = new System.Drawing.Size(131, 28);
            this.BorrarImgBtn.TabIndex = 38;
            this.BorrarImgBtn.Text = "Borrar";
            this.BorrarImgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarImgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarImgBtn.UseVisualStyleBackColor = false;
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.EditUserBtn.FlatAppearance.BorderSize = 0;
            this.EditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBtn.ForeColor = System.Drawing.Color.White;
            this.EditUserBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.EditUserBtn.IconColor = System.Drawing.Color.White;
            this.EditUserBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.EditUserBtn.IconSize = 20;
            this.EditUserBtn.Location = new System.Drawing.Point(436, 44);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(87, 31);
            this.EditUserBtn.TabIndex = 39;
            this.EditUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditUserBtn.UseVisualStyleBackColor = false;
            // 
            // VerPassButton
            // 
            this.VerPassButton.BackColor = System.Drawing.Color.Transparent;
            this.VerPassButton.FlatAppearance.BorderSize = 0;
            this.VerPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerPassButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerPassButton.ForeColor = System.Drawing.Color.White;
            this.VerPassButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.VerPassButton.IconColor = System.Drawing.Color.Black;
            this.VerPassButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.VerPassButton.IconSize = 25;
            this.VerPassButton.Location = new System.Drawing.Point(345, 106);
            this.VerPassButton.Name = "VerPassButton";
            this.VerPassButton.Size = new System.Drawing.Size(25, 25);
            this.VerPassButton.TabIndex = 42;
            this.VerPassButton.UseVisualStyleBackColor = false;
            this.VerPassButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VerPassButton_MouseDown);
            this.VerPassButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VerPassButton_MouseUp);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.DeleteUserBtn.FlatAppearance.BorderSize = 0;
            this.DeleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteUserBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteUserBtn.IconColor = System.Drawing.Color.White;
            this.DeleteUserBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.DeleteUserBtn.IconSize = 20;
            this.DeleteUserBtn.Location = new System.Drawing.Point(436, 85);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(87, 31);
            this.DeleteUserBtn.TabIndex = 43;
            this.DeleteUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Enabled = false;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(234, 132);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '•';
            this.PasswordTxt.Size = new System.Drawing.Size(102, 22);
            this.PasswordTxt.TabIndex = 44;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uc_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.VerPassButton);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.BorrarImgBtn);
            this.Controls.Add(this.CargarImgBtn);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.ImgUserIconPicture);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.Contrasena);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 100, 10);
            this.Name = "uc_usuarios";
            this.Size = new System.Drawing.Size(552, 298);
            ((System.ComponentModel.ISupportInitialize)(this.ImgUserIconPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox ImgUserIconPicture;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Label Contrasena;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblRol;
        private FontAwesome.Sharp.IconButton CargarImgBtn;
        private FontAwesome.Sharp.IconButton BorrarImgBtn;
        private FontAwesome.Sharp.IconButton EditUserBtn;
        private FontAwesome.Sharp.IconButton VerPassButton;
        private FontAwesome.Sharp.IconButton DeleteUserBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
    }
}

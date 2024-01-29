namespace ProyectoSeminario.Windows.UsersConstrols
{
    partial class uc_profesionales
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
            this.components = new System.ComponentModel.Container();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblNroDocumento = new System.Windows.Forms.Label();
            this.PictureBoxFirma = new System.Windows.Forms.PictureBox();
            this.LblNroMatricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrarProfesionalBtn = new FontAwesome.Sharp.IconButton();
            this.LblApellido = new System.Windows.Forms.Label();
            this.EditarProfesionalesBtn = new FontAwesome.Sharp.IconButton();
            this.LblProfesion = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(175, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(118, 37);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblNroDocumento.Location = new System.Drawing.Point(38, 193);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(118, 28);
            this.LblNroDocumento.TabIndex = 1;
            this.LblNroDocumento.Text = "12.345.678";
            this.LblNroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxFirma
            // 
            this.PictureBoxFirma.Location = new System.Drawing.Point(511, 141);
            this.PictureBoxFirma.Name = "PictureBoxFirma";
            this.PictureBoxFirma.Size = new System.Drawing.Size(150, 100);
            this.PictureBoxFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxFirma.TabIndex = 3;
            this.PictureBoxFirma.TabStop = false;
            // 
            // LblNroMatricula
            // 
            this.LblNroMatricula.AutoSize = true;
            this.LblNroMatricula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblNroMatricula.Location = new System.Drawing.Point(282, 192);
            this.LblNroMatricula.Name = "LblNroMatricula";
            this.LblNroMatricula.Size = new System.Drawing.Size(72, 28);
            this.LblNroMatricula.TabIndex = 2;
            this.LblNroMatricula.Text = "45895";
            this.LblNroMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de matrícula";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorrarProfesionalBtn
            // 
            this.BorrarProfesionalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BorrarProfesionalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarProfesionalBtn.FlatAppearance.BorderSize = 0;
            this.BorrarProfesionalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarProfesionalBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarProfesionalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BorrarProfesionalBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.BorrarProfesionalBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BorrarProfesionalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarProfesionalBtn.IconSize = 30;
            this.BorrarProfesionalBtn.Location = new System.Drawing.Point(511, 77);
            this.BorrarProfesionalBtn.Name = "BorrarProfesionalBtn";
            this.BorrarProfesionalBtn.Size = new System.Drawing.Size(150, 37);
            this.BorrarProfesionalBtn.TabIndex = 10;
            this.BorrarProfesionalBtn.Text = "Borrar";
            this.BorrarProfesionalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarProfesionalBtn.UseVisualStyleBackColor = false;
            this.BorrarProfesionalBtn.Click += new System.EventHandler(this.BorrarProfesionalBtn_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(175, 34);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(118, 37);
            this.LblApellido.TabIndex = 11;
            this.LblApellido.Text = "Apellido";
            this.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditarProfesionalesBtn
            // 
            this.EditarProfesionalesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.EditarProfesionalesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarProfesionalesBtn.FlatAppearance.BorderSize = 0;
            this.EditarProfesionalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarProfesionalesBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarProfesionalesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EditarProfesionalesBtn.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.EditarProfesionalesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EditarProfesionalesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarProfesionalesBtn.IconSize = 30;
            this.EditarProfesionalesBtn.Location = new System.Drawing.Point(511, 34);
            this.EditarProfesionalesBtn.Name = "EditarProfesionalesBtn";
            this.EditarProfesionalesBtn.Size = new System.Drawing.Size(150, 37);
            this.EditarProfesionalesBtn.TabIndex = 12;
            this.EditarProfesionalesBtn.Text = "Editar";
            this.EditarProfesionalesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarProfesionalesBtn.UseVisualStyleBackColor = false;
            this.EditarProfesionalesBtn.Click += new System.EventHandler(this.EditarProfesionalesBtn_Click);
            // 
            // LblProfesion
            // 
            this.LblProfesion.AutoSize = true;
            this.LblProfesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblProfesion.Location = new System.Drawing.Point(182, 120);
            this.LblProfesion.Name = "LblProfesion";
            this.LblProfesion.Size = new System.Drawing.Size(66, 19);
            this.LblProfesion.TabIndex = 14;
            this.LblProfesion.Text = "Profesion";
            this.LblProfesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 146;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 33);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(146, 151);
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(19, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 5);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.panel2.Location = new System.Drawing.Point(22, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 5);
            this.panel2.TabIndex = 18;
            // 
            // uc_profesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.LblProfesion);
            this.Controls.Add(this.EditarProfesionalesBtn);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.BorrarProfesionalBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictureBoxFirma);
            this.Controls.Add(this.LblNroMatricula);
            this.Controls.Add(this.LblNroDocumento);
            this.Controls.Add(this.LblNombre);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 10, 25);
            this.Name = "uc_profesionales";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(687, 282);
            this.Load += new System.EventHandler(this.uc_profesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblNroDocumento;
        private System.Windows.Forms.PictureBox PictureBoxFirma;
        private System.Windows.Forms.Label LblNroMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BorrarProfesionalBtn;
        private System.Windows.Forms.Label LblApellido;
        private FontAwesome.Sharp.IconButton EditarProfesionalesBtn;
        private System.Windows.Forms.Label LblProfesion;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

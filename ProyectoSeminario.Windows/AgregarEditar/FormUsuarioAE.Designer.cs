namespace ProyectoSeminario.Windows.AgregarEditar
{
    partial class FormUsuarioAE
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
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTXT = new System.Windows.Forms.TextBox();
            this.PassTXT = new System.Windows.Forms.TextBox();
            this.AdministradorRadioButton = new System.Windows.Forms.RadioButton();
            this.ProfesionalRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(49, 235);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 0;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(195, 235);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 1;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol:";
            // 
            // UserNameTXT
            // 
            this.UserNameTXT.Location = new System.Drawing.Point(153, 55);
            this.UserNameTXT.Name = "UserNameTXT";
            this.UserNameTXT.Size = new System.Drawing.Size(100, 20);
            this.UserNameTXT.TabIndex = 5;
            // 
            // PassTXT
            // 
            this.PassTXT.Location = new System.Drawing.Point(116, 94);
            this.PassTXT.Name = "PassTXT";
            this.PassTXT.Size = new System.Drawing.Size(100, 20);
            this.PassTXT.TabIndex = 6;
            // 
            // AdministradorRadioButton
            // 
            this.AdministradorRadioButton.AutoSize = true;
            this.AdministradorRadioButton.Location = new System.Drawing.Point(78, 134);
            this.AdministradorRadioButton.Name = "AdministradorRadioButton";
            this.AdministradorRadioButton.Size = new System.Drawing.Size(88, 17);
            this.AdministradorRadioButton.TabIndex = 7;
            this.AdministradorRadioButton.TabStop = true;
            this.AdministradorRadioButton.Text = "Administrador";
            this.AdministradorRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProfesionalRadioButton
            // 
            this.ProfesionalRadioButton.AutoSize = true;
            this.ProfesionalRadioButton.Location = new System.Drawing.Point(78, 157);
            this.ProfesionalRadioButton.Name = "ProfesionalRadioButton";
            this.ProfesionalRadioButton.Size = new System.Drawing.Size(77, 17);
            this.ProfesionalRadioButton.TabIndex = 8;
            this.ProfesionalRadioButton.TabStop = true;
            this.ProfesionalRadioButton.Text = "Profesional";
            this.ProfesionalRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormUsuarioAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 312);
            this.Controls.Add(this.ProfesionalRadioButton);
            this.Controls.Add(this.AdministradorRadioButton);
            this.Controls.Add(this.PassTXT);
            this.Controls.Add(this.UserNameTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "FormUsuarioAE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTXT;
        private System.Windows.Forms.TextBox PassTXT;
        private System.Windows.Forms.RadioButton AdministradorRadioButton;
        private System.Windows.Forms.RadioButton ProfesionalRadioButton;
    }
}
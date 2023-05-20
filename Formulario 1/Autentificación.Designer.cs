namespace Formulario_1
{
    partial class Autentificación
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
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.LogBtn = new System.Windows.Forms.Button();
            this.mailLabel = new System.Windows.Forms.Label();
            this.MailText = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Es necesario iniciar sesión";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 106);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Nombre de usuario";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(133, 103);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(156, 20);
            this.UserText.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(12, 147);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Contraseña";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(133, 147);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(156, 20);
            this.passText.TabIndex = 4;
            // 
            // LogBtn
            // 
            this.LogBtn.Location = new System.Drawing.Point(355, 147);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(107, 61);
            this.LogBtn.TabIndex = 5;
            this.LogBtn.Text = "Iniciar sesión";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(12, 191);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(93, 13);
            this.mailLabel.TabIndex = 6;
            this.mailLabel.Text = "Correo electrónico";
            // 
            // MailText
            // 
            this.MailText.Location = new System.Drawing.Point(133, 188);
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(156, 20);
            this.MailText.TabIndex = 7;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(355, 101);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(107, 23);
            this.CreateBtn.TabIndex = 8;
            this.CreateBtn.Text = "Crear cuenta";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 47);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(422, 26);
            this.InfoLabel.TabIndex = 9;
            this.InfoLabel.Text = "* El usuario por defecto tiene sólo permisos estándar. Contacte con la administra" +
    "ción de \r\nla aplicación si quiere permisos de administrador";
            // 
            // Autentificación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 220);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.MailText);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Name = "Autentificación";
            this.Text = "Inicio de Sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autentificación_FormClosed);
            this.Load += new System.EventHandler(this.Autentificación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label InfoLabel;
    }
}
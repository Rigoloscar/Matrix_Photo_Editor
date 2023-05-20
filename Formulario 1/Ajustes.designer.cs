namespace Formulario_1
{
    partial class Ajustes
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.MailLbl = new System.Windows.Forms.Label();
            this.NameBtn = new System.Windows.Forms.Button();
            this.PassBtn = new System.Windows.Forms.Button();
            this.MailBtn = new System.Windows.Forms.Button();
            this.DoneLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATOS DEL USUARIO";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 48);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 13);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "NameLbl";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(12, 84);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(44, 13);
            this.PassLbl.TabIndex = 9;
            this.PassLbl.Text = "PassLbl";
            // 
            // MailLbl
            // 
            this.MailLbl.AutoSize = true;
            this.MailLbl.Location = new System.Drawing.Point(12, 119);
            this.MailLbl.Name = "MailLbl";
            this.MailLbl.Size = new System.Drawing.Size(40, 13);
            this.MailLbl.TabIndex = 10;
            this.MailLbl.Text = "MailLbl";
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(221, 43);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(75, 23);
            this.NameBtn.TabIndex = 11;
            this.NameBtn.Text = "cambiar";
            this.NameBtn.UseVisualStyleBackColor = true;
            this.NameBtn.Click += new System.EventHandler(this.NameBtn_Click);
            // 
            // PassBtn
            // 
            this.PassBtn.Location = new System.Drawing.Point(221, 79);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(75, 23);
            this.PassBtn.TabIndex = 12;
            this.PassBtn.Text = "cambiar";
            this.PassBtn.UseVisualStyleBackColor = true;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // MailBtn
            // 
            this.MailBtn.Location = new System.Drawing.Point(221, 114);
            this.MailBtn.Name = "MailBtn";
            this.MailBtn.Size = new System.Drawing.Size(75, 23);
            this.MailBtn.TabIndex = 13;
            this.MailBtn.Text = "cambiar";
            this.MailBtn.UseVisualStyleBackColor = true;
            this.MailBtn.Click += new System.EventHandler(this.MailBtn_Click);
            // 
            // DoneLbl
            // 
            this.DoneLbl.AutoSize = true;
            this.DoneLbl.Location = new System.Drawing.Point(12, 157);
            this.DoneLbl.Name = "DoneLbl";
            this.DoneLbl.Size = new System.Drawing.Size(98, 13);
            this.DoneLbl.TabIndex = 14;
            this.DoneLbl.Text = "Nueva contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(221, 153);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 23);
            this.DoneBtn.TabIndex = 16;
            this.DoneBtn.Text = "Hecho";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 188);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DoneLbl);
            this.Controls.Add(this.MailBtn);
            this.Controls.Add(this.PassBtn);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.MailLbl);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label1);
            this.Name = "Ajustes";
            this.Text = "Ajustes de usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ajustes_FormClosing);
            this.Load += new System.EventHandler(this.Ajustes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label MailLbl;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.Button PassBtn;
        private System.Windows.Forms.Button MailBtn;
        private System.Windows.Forms.Label DoneLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DoneBtn;
    }
}
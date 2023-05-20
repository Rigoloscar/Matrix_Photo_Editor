namespace Formulario_1
{
    partial class Intensidad
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
            this.trackBarRojo = new System.Windows.Forms.TrackBar();
            this.trackBarVerde = new System.Windows.Forms.TrackBar();
            this.trackBarAzul = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAzul)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRojo
            // 
            this.trackBarRojo.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRojo.Location = new System.Drawing.Point(44, 12);
            this.trackBarRojo.Maximum = 255;
            this.trackBarRojo.Name = "trackBarRojo";
            this.trackBarRojo.Size = new System.Drawing.Size(213, 45);
            this.trackBarRojo.TabIndex = 0;
            this.trackBarRojo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRojo.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarVerde
            // 
            this.trackBarVerde.Location = new System.Drawing.Point(44, 42);
            this.trackBarVerde.Maximum = 255;
            this.trackBarVerde.Name = "trackBarVerde";
            this.trackBarVerde.Size = new System.Drawing.Size(213, 45);
            this.trackBarVerde.TabIndex = 1;
            this.trackBarVerde.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVerde.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBarAzul
            // 
            this.trackBarAzul.Location = new System.Drawing.Point(44, 74);
            this.trackBarAzul.Maximum = 255;
            this.trackBarAzul.Name = "trackBarAzul";
            this.trackBarAzul.Size = new System.Drawing.Size(213, 45);
            this.trackBarAzul.TabIndex = 2;
            this.trackBarAzul.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAzul.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Azul";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Intensidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarAzul);
            this.Controls.Add(this.trackBarVerde);
            this.Controls.Add(this.trackBarRojo);
            this.Name = "Intensidad";
            this.Text = "Intensidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAzul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRojo;
        private System.Windows.Forms.TrackBar trackBarVerde;
        private System.Windows.Forms.TrackBar trackBarAzul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
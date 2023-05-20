namespace Formularios
{
    partial class Programa_principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desenfoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.girarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enmarcarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intensificarUnColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoPresentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.userLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.ediciónToolStripMenuItem1,
            this.visualizaciónToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.menúToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Mostrar datos";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.mostrarNFToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem1
            // 
            this.ediciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.enmarcarToolStripMenuItem,
            this.intensificarUnColorToolStripMenuItem,
            this.brilloToolStripMenuItem});
            this.ediciónToolStripMenuItem1.Name = "ediciónToolStripMenuItem1";
            this.ediciónToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem1.Text = "Edición";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativoToolStripMenuItem1,
            this.sepiaToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem1,
            this.desenfoqueToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // negativoToolStripMenuItem1
            // 
            this.negativoToolStripMenuItem1.Name = "negativoToolStripMenuItem1";
            this.negativoToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.negativoToolStripMenuItem1.Text = "Negativo";
            this.negativoToolStripMenuItem1.Click += new System.EventHandler(this.negativoToolStripMenuItem1_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem1
            // 
            this.escalaDeGrisesToolStripMenuItem1.Name = "escalaDeGrisesToolStripMenuItem1";
            this.escalaDeGrisesToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.escalaDeGrisesToolStripMenuItem1.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem1.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem1_Click);
            // 
            // desenfoqueToolStripMenuItem
            // 
            this.desenfoqueToolStripMenuItem.Name = "desenfoqueToolStripMenuItem";
            this.desenfoqueToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.desenfoqueToolStripMenuItem.Text = "Desenfoque";
            this.desenfoqueToolStripMenuItem.Click += new System.EventHandler(this.desenfoqueToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltearToolStripMenuItem1,
            this.recortarToolStripMenuItem1,
            this.girarToolStripMenuItem1});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // voltearToolStripMenuItem1
            // 
            this.voltearToolStripMenuItem1.Name = "voltearToolStripMenuItem1";
            this.voltearToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.voltearToolStripMenuItem1.Text = "Voltear";
            this.voltearToolStripMenuItem1.Click += new System.EventHandler(this.voltearToolStripMenuItem1_Click);
            // 
            // recortarToolStripMenuItem1
            // 
            this.recortarToolStripMenuItem1.Name = "recortarToolStripMenuItem1";
            this.recortarToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.recortarToolStripMenuItem1.Text = "Recortar";
            this.recortarToolStripMenuItem1.Click += new System.EventHandler(this.recortarToolStripMenuItem1_Click);
            // 
            // girarToolStripMenuItem1
            // 
            this.girarToolStripMenuItem1.Name = "girarToolStripMenuItem1";
            this.girarToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.girarToolStripMenuItem1.Text = "Girar";
            this.girarToolStripMenuItem1.Click += new System.EventHandler(this.girarToolStripMenuItem1_Click);
            // 
            // enmarcarToolStripMenuItem
            // 
            this.enmarcarToolStripMenuItem.Name = "enmarcarToolStripMenuItem";
            this.enmarcarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.enmarcarToolStripMenuItem.Text = "Enmarcar";
            this.enmarcarToolStripMenuItem.Click += new System.EventHandler(this.enmarcarToolStripMenuItem_Click);
            // 
            // intensificarUnColorToolStripMenuItem
            // 
            this.intensificarUnColorToolStripMenuItem.Name = "intensificarUnColorToolStripMenuItem";
            this.intensificarUnColorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.intensificarUnColorToolStripMenuItem.Text = "Intensificar un color";
            this.intensificarUnColorToolStripMenuItem.Click += new System.EventHandler(this.intensificarColorToolStripMenuItem_Click);
            // 
            // brilloToolStripMenuItem
            // 
            this.brilloToolStripMenuItem.Name = "brilloToolStripMenuItem";
            this.brilloToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.brilloToolStripMenuItem.Text = "Brillo";
            this.brilloToolStripMenuItem.Click += new System.EventHandler(this.brilloToolStripMenuItem_Click);
            // 
            // visualizaciónToolStripMenuItem
            // 
            this.visualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoPresentaciónToolStripMenuItem});
            this.visualizaciónToolStripMenuItem.Name = "visualizaciónToolStripMenuItem";
            this.visualizaciónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.visualizaciónToolStripMenuItem.Text = "Visualización";
            // 
            // modoPresentaciónToolStripMenuItem
            // 
            this.modoPresentaciónToolStripMenuItem.Name = "modoPresentaciónToolStripMenuItem";
            this.modoPresentaciónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modoPresentaciónToolStripMenuItem.Text = "Modo presentación";
            this.modoPresentaciónToolStripMenuItem.Click += new System.EventHandler(this.modoPresentaciónToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.créditosToolStripMenuItem.Text = "Acerca de ";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesDeUsuarioToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // ajustesDeUsuarioToolStripMenuItem
            // 
            this.ajustesDeUsuarioToolStripMenuItem.Name = "ajustesDeUsuarioToolStripMenuItem";
            this.ajustesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajustesDeUsuarioToolStripMenuItem.Text = "Ajustes de usuario";
            this.ajustesDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ajustesDeUsuarioToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administraciónToolStripMenuItem.Text = "Administración";
            this.administraciónToolStripMenuItem.Click += new System.EventHandler(this.administraciónToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 405);
            this.panel1.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(681, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(107, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Usuario:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(354, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(389, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessiónToolStripMenuItem_Click);
            // 
            // Programa_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Programa_principal";
            this.Text = "Programa principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Programa_principal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoPresentaciónToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem enmarcarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intensificarUnColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem girarToolStripMenuItem1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem desenfoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}


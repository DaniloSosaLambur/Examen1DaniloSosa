namespace DaniloSosa
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosDel1Al100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem,
            this.ejercicio2ToolStripMenuItem,
            this.ejercicio3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primerFormularioToolStripMenuItem});
            this.ejercicio1ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejercicio1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ejercicio1ToolStripMenuItem.Text = "Formulario 1";
            this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio1ToolStripMenuItem_Click);
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarProductoToolStripMenuItem});
            this.ejercicio2ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejercicio2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ejercicio2ToolStripMenuItem.Text = "Formulario 2";
            // 
            // ejercicio3ToolStripMenuItem
            // 
            this.ejercicio3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numerosDel1Al100ToolStripMenuItem});
            this.ejercicio3ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejercicio3ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
            this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ejercicio3ToolStripMenuItem.Text = "Formulario 3";
            // 
            // primerFormularioToolStripMenuItem
            // 
            this.primerFormularioToolStripMenuItem.Name = "primerFormularioToolStripMenuItem";
            this.primerFormularioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.primerFormularioToolStripMenuItem.Text = "Calcular interes";
            this.primerFormularioToolStripMenuItem.Click += new System.EventHandler(this.primerFormularioToolStripMenuItem_Click);
            // 
            // comprarProductoToolStripMenuItem
            // 
            this.comprarProductoToolStripMenuItem.Name = "comprarProductoToolStripMenuItem";
            this.comprarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprarProductoToolStripMenuItem.Text = "Comprar Producto";
            this.comprarProductoToolStripMenuItem.Click += new System.EventHandler(this.comprarProductoToolStripMenuItem_Click);
            // 
            // numerosDel1Al100ToolStripMenuItem
            // 
            this.numerosDel1Al100ToolStripMenuItem.Name = "numerosDel1Al100ToolStripMenuItem";
            this.numerosDel1Al100ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.numerosDel1Al100ToolStripMenuItem.Text = "Numeros del 1 al 100";
            this.numerosDel1Al100ToolStripMenuItem.Click += new System.EventHandler(this.numerosDel1Al100ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 153);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "EJERCICIOS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosDel1Al100ToolStripMenuItem;
    }
}


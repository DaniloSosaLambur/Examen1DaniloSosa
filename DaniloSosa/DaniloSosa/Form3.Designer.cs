namespace DaniloSosa
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.producto1textBox = new System.Windows.Forms.TextBox();
            this.producto2textBox = new System.Windows.Forms.TextBox();
            this.producto3textBox = new System.Windows.Forms.TextBox();
            this.precio1textBox = new System.Windows.Forms.TextBox();
            this.precio2textBox = new System.Windows.Forms.TextBox();
            this.precio3textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el producto 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el producto 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el producto 3:";
            // 
            // producto1textBox
            // 
            this.producto1textBox.Location = new System.Drawing.Point(311, 80);
            this.producto1textBox.Name = "producto1textBox";
            this.producto1textBox.Size = new System.Drawing.Size(100, 20);
            this.producto1textBox.TabIndex = 3;
            // 
            // producto2textBox
            // 
            this.producto2textBox.Location = new System.Drawing.Point(311, 123);
            this.producto2textBox.Name = "producto2textBox";
            this.producto2textBox.Size = new System.Drawing.Size(100, 20);
            this.producto2textBox.TabIndex = 4;
            // 
            // producto3textBox
            // 
            this.producto3textBox.Location = new System.Drawing.Point(311, 168);
            this.producto3textBox.Name = "producto3textBox";
            this.producto3textBox.Size = new System.Drawing.Size(100, 20);
            this.producto3textBox.TabIndex = 5;
            // 
            // precio1textBox
            // 
            this.precio1textBox.Location = new System.Drawing.Point(496, 80);
            this.precio1textBox.Name = "precio1textBox";
            this.precio1textBox.Size = new System.Drawing.Size(100, 20);
            this.precio1textBox.TabIndex = 6;
            // 
            // precio2textBox
            // 
            this.precio2textBox.Location = new System.Drawing.Point(496, 123);
            this.precio2textBox.Name = "precio2textBox";
            this.precio2textBox.Size = new System.Drawing.Size(100, 20);
            this.precio2textBox.TabIndex = 7;
            // 
            // precio3textBox
            // 
            this.precio3textBox.Location = new System.Drawing.Point(496, 168);
            this.precio3textBox.Name = "precio3textBox";
            this.precio3textBox.Size = new System.Drawing.Size(100, 20);
            this.precio3textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "COMPRAR PRODUCTOS";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calcularbutton.Location = new System.Drawing.Point(352, 207);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(94, 45);
            this.Calcularbutton.TabIndex = 12;
            this.Calcularbutton.Text = "Comprar";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Location = new System.Drawing.Point(466, 207);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(87, 45);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(775, 264);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precio3textBox);
            this.Controls.Add(this.precio2textBox);
            this.Controls.Add(this.precio1textBox);
            this.Controls.Add(this.producto3textBox);
            this.Controls.Add(this.producto2textBox);
            this.Controls.Add(this.producto1textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Comprar Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox producto1textBox;
        private System.Windows.Forms.TextBox producto2textBox;
        private System.Windows.Forms.TextBox producto3textBox;
        private System.Windows.Forms.TextBox precio1textBox;
        private System.Windows.Forms.TextBox precio2textBox;
        private System.Windows.Forms.TextBox precio3textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Button Cancelarbutton;
    }
}
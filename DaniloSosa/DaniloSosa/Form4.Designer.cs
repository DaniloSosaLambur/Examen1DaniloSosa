namespace DaniloSosa
{
    partial class Form4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.verbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMEROS DEL 1 AL 100";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(66, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 303);
            this.listBox1.TabIndex = 1;
            // 
            // verbutton
            // 
            this.verbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.verbutton.Location = new System.Drawing.Point(335, 155);
            this.verbutton.Name = "verbutton";
            this.verbutton.Size = new System.Drawing.Size(80, 38);
            this.verbutton.TabIndex = 2;
            this.verbutton.Text = "Ver numeros";
            this.verbutton.UseVisualStyleBackColor = false;
            this.verbutton.Click += new System.EventHandler(this.verbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarbutton.Location = new System.Drawing.Point(335, 220);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(80, 38);
            this.cancelarbutton.TabIndex = 3;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.cancelarbutton;
            this.ClientSize = new System.Drawing.Size(445, 382);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.verbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Numeros del 1 al 100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button verbutton;
        private System.Windows.Forms.Button cancelarbutton;
    }
}
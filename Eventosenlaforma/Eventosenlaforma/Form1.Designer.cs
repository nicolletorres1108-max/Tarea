namespace Eventosenlaforma
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnsaludo = new System.Windows.Forms.Button();
            this.btndespedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(56, 67);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(44, 16);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "label1";
            // 
            // btnsaludo
            // 
            this.btnsaludo.Location = new System.Drawing.Point(330, 46);
            this.btnsaludo.Name = "btnsaludo";
            this.btnsaludo.Size = new System.Drawing.Size(128, 37);
            this.btnsaludo.TabIndex = 1;
            this.btnsaludo.Text = "Saludo";
            this.btnsaludo.UseVisualStyleBackColor = true;
            this.btnsaludo.Click += new System.EventHandler(this.btnsaludo_Click);
            // 
            // btndespedida
            // 
            this.btndespedida.Location = new System.Drawing.Point(330, 104);
            this.btndespedida.Name = "btndespedida";
            this.btndespedida.Size = new System.Drawing.Size(128, 37);
            this.btndespedida.TabIndex = 2;
            this.btndespedida.Text = "Despedida";
            this.btndespedida.UseVisualStyleBackColor = true;
            this.btndespedida.Click += new System.EventHandler(this.btndespedida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.btndespedida);
            this.Controls.Add(this.btnsaludo);
            this.Controls.Add(this.lblmensaje);
            this.Name = "Form1";
            this.Text = "Programa 01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnsaludo;
        private System.Windows.Forms.Button btndespedida;
    }
}


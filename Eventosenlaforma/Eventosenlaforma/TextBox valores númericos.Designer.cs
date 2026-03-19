namespace Eventosenlaforma
{
    partial class TextBox_valores_númericos
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
            this.lbla = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(30, 62);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(19, 16);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "A:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(55, 59);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(125, 22);
            this.txta.TabIndex = 1;
            this.txta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(30, 113);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(19, 16);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "B:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(55, 107);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(125, 22);
            this.txtb.TabIndex = 3;
            this.txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(136, 159);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(44, 16);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(202, 59);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(24, 23);
            this.btnsuma.TabIndex = 5;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(233, 59);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(24, 23);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(233, 106);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(24, 23);
            this.btndividir.TabIndex = 8;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(202, 106);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(24, 23);
            this.btnmulti.TabIndex = 7;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // TextBox_valores_númericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 201);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbla);
            this.Name = "TextBox_valores_númericos";
            this.Text = "TextBox_valores_númericos";
            this.Load += new System.EventHandler(this.TextBox_valores_númericos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnmulti;
    }
}

namespace BalancaPlascar
{
    partial class Balanca
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.lblRespErro = new System.Windows.Forms.Label();
            this.lblRespMovimento = new System.Windows.Forms.Label();
            this.lblRespTara = new System.Windows.Forms.Label();
            this.lblRespPeso = new System.Windows.Forms.Label();
            this.lblRespValorRecebido = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblMovimento = new System.Windows.Forms.Label();
            this.lblTara = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(92, 15);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(217, 27);
            this.txtEntrada.TabIndex = 0;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(12, 18);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(74, 21);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "Entrada";
            // 
            // gbSaida
            // 
            this.gbSaida.BackColor = System.Drawing.SystemColors.Info;
            this.gbSaida.Controls.Add(this.lblRespErro);
            this.gbSaida.Controls.Add(this.lblRespMovimento);
            this.gbSaida.Controls.Add(this.lblRespTara);
            this.gbSaida.Controls.Add(this.lblRespPeso);
            this.gbSaida.Controls.Add(this.lblRespValorRecebido);
            this.gbSaida.Controls.Add(this.lblErro);
            this.gbSaida.Controls.Add(this.lblMovimento);
            this.gbSaida.Controls.Add(this.lblTara);
            this.gbSaida.Controls.Add(this.lblPeso);
            this.gbSaida.Controls.Add(this.lblValorRecebido);
            this.gbSaida.Location = new System.Drawing.Point(16, 85);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(540, 255);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            // 
            // lblRespErro
            // 
            this.lblRespErro.AutoSize = true;
            this.lblRespErro.Location = new System.Drawing.Point(169, 206);
            this.lblRespErro.Name = "lblRespErro";
            this.lblRespErro.Size = new System.Drawing.Size(39, 21);
            this.lblRespErro.TabIndex = 14;
            this.lblRespErro.Text = "Erro";
            // 
            // lblRespMovimento
            // 
            this.lblRespMovimento.AutoSize = true;
            this.lblRespMovimento.Location = new System.Drawing.Point(169, 164);
            this.lblRespMovimento.Name = "lblRespMovimento";
            this.lblRespMovimento.Size = new System.Drawing.Size(100, 21);
            this.lblRespMovimento.TabIndex = 13;
            this.lblRespMovimento.Text = "Movimento";
            // 
            // lblRespTara
            // 
            this.lblRespTara.AutoSize = true;
            this.lblRespTara.Location = new System.Drawing.Point(169, 122);
            this.lblRespTara.Name = "lblRespTara";
            this.lblRespTara.Size = new System.Drawing.Size(45, 21);
            this.lblRespTara.TabIndex = 12;
            this.lblRespTara.Text = "Tara";
            // 
            // lblRespPeso
            // 
            this.lblRespPeso.AutoSize = true;
            this.lblRespPeso.Location = new System.Drawing.Point(169, 80);
            this.lblRespPeso.Name = "lblRespPeso";
            this.lblRespPeso.Size = new System.Drawing.Size(45, 21);
            this.lblRespPeso.TabIndex = 11;
            this.lblRespPeso.Text = "Peso";
            // 
            // lblRespValorRecebido
            // 
            this.lblRespValorRecebido.AutoSize = true;
            this.lblRespValorRecebido.Location = new System.Drawing.Point(169, 38);
            this.lblRespValorRecebido.Name = "lblRespValorRecebido";
            this.lblRespValorRecebido.Size = new System.Drawing.Size(124, 21);
            this.lblRespValorRecebido.TabIndex = 10;
            this.lblRespValorRecebido.Text = "Valor recebido";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(15, 206);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(39, 21);
            this.lblErro.TabIndex = 9;
            this.lblErro.Text = "Erro";
            // 
            // lblMovimento
            // 
            this.lblMovimento.AutoSize = true;
            this.lblMovimento.Location = new System.Drawing.Point(15, 164);
            this.lblMovimento.Name = "lblMovimento";
            this.lblMovimento.Size = new System.Drawing.Size(100, 21);
            this.lblMovimento.TabIndex = 8;
            this.lblMovimento.Text = "Movimento";
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Location = new System.Drawing.Point(15, 122);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(45, 21);
            this.lblTara.TabIndex = 7;
            this.lblTara.Text = "Tara";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(15, 80);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 21);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Location = new System.Drawing.Point(15, 38);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(124, 21);
            this.lblValorRecebido.TabIndex = 3;
            this.lblValorRecebido.Text = "Valor recebido";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(382, 15);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 27);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Balanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 352);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtEntrada);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Balanca";
            this.Text = "Balança Plascar";
            this.Load += new System.EventHandler(this.Balanca_Load);
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.Label lblRespErro;
        private System.Windows.Forms.Label lblRespMovimento;
        private System.Windows.Forms.Label lblRespTara;
        private System.Windows.Forms.Label lblRespPeso;
        private System.Windows.Forms.Label lblRespValorRecebido;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblMovimento;
        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.Button btnEnviar;
    }
}


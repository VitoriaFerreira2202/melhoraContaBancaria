namespace melhoraContaBancaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeTitula = new System.Windows.Forms.TextBox();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSaldoResultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "PARA CONTINUA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(149, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTA BACARIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME DO TITULA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "NUMERO DA CONTA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "SALDO:";
            // 
            // txtNomeTitula
            // 
            this.txtNomeTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNomeTitula.Location = new System.Drawing.Point(277, 54);
            this.txtNomeTitula.Name = "txtNomeTitula";
            this.txtNomeTitula.Size = new System.Drawing.Size(199, 35);
            this.txtNomeTitula.TabIndex = 5;
            // 
            // txtNumConta
            // 
            this.txtNumConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNumConta.Location = new System.Drawing.Point(297, 100);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(199, 35);
            this.txtNumConta.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSaldo.Location = new System.Drawing.Point(130, 159);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(199, 35);
            this.txtSaldo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(3, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(9, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "l";
            // 
            // txtSaldoResultado
            // 
            this.txtSaldoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSaldoResultado.Location = new System.Drawing.Point(130, 346);
            this.txtSaldoResultado.Name = "txtSaldoResultado";
            this.txtSaldoResultado.Size = new System.Drawing.Size(199, 35);
            this.txtSaldoResultado.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "SALDO:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(17, 403);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 31);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "DEPOSITO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(17, 449);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 31);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "SAQUE";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDeposito.Location = new System.Drawing.Point(183, 399);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(199, 35);
            this.txtDeposito.TabIndex = 13;
            // 
            // txtSaque
            // 
            this.txtSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSaque.Location = new System.Drawing.Point(141, 440);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(199, 35);
            this.txtSaque.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 595);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtSaldoResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.txtNomeTitula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CONTA BANCARIA ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeTitula;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSaldoResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtSaque;
    }
}


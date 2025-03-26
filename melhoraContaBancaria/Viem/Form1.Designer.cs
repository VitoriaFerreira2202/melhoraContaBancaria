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
            this.lblNomeTitula = new System.Windows.Forms.Label();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNomeTitula = new System.Windows.Forms.TextBox();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSaldoResultado = new System.Windows.Forms.TextBox();
            this.lblSaldoPart2 = new System.Windows.Forms.Label();
            this.checkBoxDepo = new System.Windows.Forms.CheckBox();
            this.checkBoxSaque = new System.Windows.Forms.CheckBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(422, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 38);
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
            // lblNomeTitula
            // 
            this.lblNomeTitula.AutoSize = true;
            this.lblNomeTitula.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTitula.Location = new System.Drawing.Point(12, 54);
            this.lblNomeTitula.Name = "lblNomeTitula";
            this.lblNomeTitula.Size = new System.Drawing.Size(245, 27);
            this.lblNomeTitula.TabIndex = 2;
            this.lblNomeTitula.Text = "NOME DO TITULA:";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConta.Location = new System.Drawing.Point(12, 108);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(279, 27);
            this.lblNumConta.TabIndex = 3;
            this.lblNumConta.Text = "NUMERO DA CONTA:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(12, 163);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(103, 27);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "SALDO:";
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            this.lblResultado.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(20, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 0;
            // 
            // txtSaldoResultado
            // 
            this.txtSaldoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSaldoResultado.Location = new System.Drawing.Point(130, 346);
            this.txtSaldoResultado.Name = "txtSaldoResultado";
            this.txtSaldoResultado.Size = new System.Drawing.Size(199, 35);
            this.txtSaldoResultado.TabIndex = 10;
            // 
            // lblSaldoPart2
            // 
            this.lblSaldoPart2.AutoSize = true;
            this.lblSaldoPart2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPart2.Location = new System.Drawing.Point(12, 350);
            this.lblSaldoPart2.Name = "lblSaldoPart2";
            this.lblSaldoPart2.Size = new System.Drawing.Size(103, 27);
            this.lblSaldoPart2.TabIndex = 9;
            this.lblSaldoPart2.Text = "SALDO:";
            // 
            // checkBoxDepo
            // 
            this.checkBoxDepo.AutoSize = true;
            this.checkBoxDepo.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.checkBoxDepo.Location = new System.Drawing.Point(17, 403);
            this.checkBoxDepo.Name = "checkBoxDepo";
            this.checkBoxDepo.Size = new System.Drawing.Size(160, 31);
            this.checkBoxDepo.TabIndex = 11;
            this.checkBoxDepo.Text = "DEPOSITO";
            this.checkBoxDepo.UseVisualStyleBackColor = true;
            this.checkBoxDepo.CheckedChanged += new System.EventHandler(this.checkBoxDepo_CheckedChanged);
            // 
            // checkBoxSaque
            // 
            this.checkBoxSaque.AutoSize = true;
            this.checkBoxSaque.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.checkBoxSaque.Location = new System.Drawing.Point(17, 449);
            this.checkBoxSaque.Name = "checkBoxSaque";
            this.checkBoxSaque.Size = new System.Drawing.Size(118, 31);
            this.checkBoxSaque.TabIndex = 12;
            this.checkBoxSaque.Text = "SAQUE";
            this.checkBoxSaque.UseVisualStyleBackColor = true;
            this.checkBoxSaque.CheckedChanged += new System.EventHandler(this.checkBoxSaque_CheckedChanged);
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
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalc.Location = new System.Drawing.Point(436, 446);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(149, 40);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 595);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.checkBoxSaque);
            this.Controls.Add(this.checkBoxDepo);
            this.Controls.Add(this.txtSaldoResultado);
            this.Controls.Add(this.lblSaldoPart2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.txtNomeTitula);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNumConta);
            this.Controls.Add(this.lblNomeTitula);
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
        private System.Windows.Forms.Label lblNomeTitula;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNomeTitula;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSaldoResultado;
        private System.Windows.Forms.Label lblSaldoPart2;
        private System.Windows.Forms.CheckBox checkBoxDepo;
        private System.Windows.Forms.CheckBox checkBoxSaque;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Button btnCalc;
    }
}


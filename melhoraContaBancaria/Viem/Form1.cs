using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melhoraContaBancaria
{
    public partial class Form1 : Form
    {
        ControleConta controleconta;
        public Form1()
        {
            InitializeComponent();
            Desabilita();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controleconta = new ControleConta(txtNomeTitula.Text,txtNumConta.Text,txtSaldo.Text);
                lblResultado.Text = PreparaResul(txtSaldo.Text);
                txtSaldoResultado.Text = txtSaldo.Text;
                Abilita();
            }
             
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            
            return;
              }
            
        }
        private string PreparaResul(string saldo) 
        {
            return $"NOME: {txtNomeTitula.Text}\nNUMERO DA CONTA: {txtNumConta.Text}\nSALDO: R${saldo:C2}";
        }
        private void checkBoxDepo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDepo.Checked)
            {
                checkBoxSaque.Checked = false;
            }
        }

        private void checkBoxSaque_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaque.Checked)
            {
                checkBoxDepo.Checked = false;
            }
        }

        
        public void Desabilita() 
        { 
            txtSaldoResultado.Enabled = false;
            txtSaque.Enabled = false;
            txtDeposito.Enabled = false;
            checkBoxDepo.Enabled = false;
            checkBoxSaque.Enabled = false;
            btnCalc.Enabled = false;
        }

        public void Abilita() 
        {
            txtSaldoResultado.Enabled = true;
            txtSaque.Enabled = true;
            txtDeposito.Enabled = true;
            checkBoxDepo.Enabled = true;
            checkBoxSaque.Enabled = true;
            btnCalc.Enabled = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxDepo.Checked)
                {
                    txtSaldoResultado.Text = controleconta.CalcDepo(txtDeposito.Text); 


                }
                else 
                {
                    txtSaldoResultado.Text = controleconta.CalcSaque(txtSaque.Text);
                }

                txtDeposito.Text = "";
                txtSaque.Text = "";
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

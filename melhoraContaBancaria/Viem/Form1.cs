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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controleconta = new ControleConta(txtNOme...); 
            }
             catch 
              {
                MessageBox.Show("OS VALOR DE QUE VCOCE INSERIU","ERROU" );
                return;
              }
        }
    }
}

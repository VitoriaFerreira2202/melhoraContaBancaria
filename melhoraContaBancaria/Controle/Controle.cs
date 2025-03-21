using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using melhoraContaBancaria.Model;


internal class ControleConta
{
    public  ControleConta(string Nome, string NumConta, string Saldo) 
    {
         
         ModelConta modelConta = new ModelConta(Nome,NumConta,Saldo); 

        
    }
}

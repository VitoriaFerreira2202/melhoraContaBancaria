using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using melhoraContaBancaria.Model;



internal class ControleConta
{
    ModelConta modelConta1;
    public  ControleConta(string Nome, string NumConta, string Saldo) 
    {
         
         modelConta1 = new ModelConta(Nome,NumConta,Saldo); 

        
    }
    public string CalcSaque(string saque) 
    {
        return modelConta1.Saque(saque);
    }

    public string CalcDepo(string Deposito) 
    { 
        return modelConta1.Deposito(Deposito);
    }
}

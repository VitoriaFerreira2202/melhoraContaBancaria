using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using melhoraContaBancaria.Util;


namespace melhoraContaBancaria.Model
{
    internal class ModelConta
    {
        private string Nome { get; set; }
        private double NumConta { get; set; }
        private double Saldo {  get; set; }


        public ModelConta(string Nome, string NumConta, string Saldo)//ATRIBUTO
        {
             this.Nome = Nome;
             this.Saldo = UtilClasse.ChecaoValorDouble(Saldo);
             this.NumConta = UtilClasse.ChecaoValorDouble(NumConta);
                       
        }

        public  double Deposito(double ValorDep) 
        {
            return Math.Abs(this.Saldo + ValorDep);
        }
        public double Saque(double ValorSaque) 
        {             
            return Math.Abs(Saldo - ValorSaque);
        }
    }
}

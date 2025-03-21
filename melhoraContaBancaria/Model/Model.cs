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

        public  string Deposito(string ValorDep) 
        {
            var Valorconve = UtilClasse.ChecaoValorDouble(ValorDep);
            return Math.Abs(this.Saldo + Valorconve).ToString();
        }
        public string Saque(string ValorSaque) 
        {
            var Valorconve = UtilClasse.ChecaoValorDouble(ValorSaque);
            return Math.Abs(this.Saldo - Valorconve).ToString();
        }
    }
}

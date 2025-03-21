using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melhoraContaBancaria.Util
{
    internal class UtilClasse

    {
        public static double  ChecaoValorDouble(string Valor) 
        {
            if (Double.TryParse(Valor, out double ValorConta))
            {
             
                return ValorConta;
            }

            else
            {
                throw new ArgumentException("O VALOR ESTA INCORRETO");
            }

            
        }



    }
}

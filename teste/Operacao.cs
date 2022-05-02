using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesImc
{
    public class Operacao
    {
        public static double Calcular(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            return imc;
        }

    }
}

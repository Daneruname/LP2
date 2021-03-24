using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado
    {
        //private double salarioMensal;
        public double SalarioMensal { get; set; }

        //sobreescrevendo o método

        public Mensalista()
        {

        }

        public Mensalista(int matx, string nomex, DateTime datax, double Salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = Salariox;
        }


        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}

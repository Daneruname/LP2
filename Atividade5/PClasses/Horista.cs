﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado
        //nao posso herdar mais de uma classe, não existe herança multipla
    {
        //prop e aperta 2x tab - aparece a estrutura da propriedade
        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }

        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
           return (SalarioHora * NumeroHora);
        }

        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days) - DiasFalta); ;

        }
    }
}

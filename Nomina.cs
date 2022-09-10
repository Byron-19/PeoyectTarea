using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForms_proycto_del_video
{
    public class Nomina
    {
        private int diaslaborados;

        public int Diaslaborados { get; set; }

        public decimal CalcularNomina (int diasLab, decimal valorDia)
        {
            decimal totalsalario = diasLab * valorDia;
            return totalsalario;
           
        }

    }
}

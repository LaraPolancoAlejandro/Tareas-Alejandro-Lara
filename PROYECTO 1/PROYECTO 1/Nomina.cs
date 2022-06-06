using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_1
{
    public class Sueldo
    {
        public decimal SueldoBruto;
        public decimal SueldoNeto;
        public decimal AFP;
        public decimal IRS;
        public decimal SFS;

        public decimal sueldoBruto { get; set; }
        public decimal sueldoNeto { get; set; }
        public decimal afp { get; set; }
        public decimal irs { get; set; }
        public decimal sfs { get; set; }

        public decimal aFp(decimal SueldoBruto)
        {
            AFP = SueldoBruto * 0.07M;
            return AFP;
        }
        public decimal IRs(decimal SueldoBruto)
        {
            IRS = SueldoBruto * 0.09M;
            return IRS;
        }
        public decimal SfS(decimal SueldoBruto)
        {
            SFS = SueldoBruto * 0.1M;
            return SFS;
        }
        public decimal sueldoneto(decimal SueldoBruto, decimal AFP, decimal IRS, decimal SFS)
        {
            SueldoNeto=SueldoBruto-AFP-IRS-SFS;
            return SueldoNeto;
        }

        
    }
}

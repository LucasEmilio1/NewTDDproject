using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

        public class FatorialCalculator
        {
            public int CalcFato(int n)
            {
                int fatorial = 1;
                for (int f = 1; f <= n; f++)
                {
                    fatorial = fatorial * f;
                }
                return fatorial;
            }
        }
    
}

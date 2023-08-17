using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSmallExample
{
    public class CalculatorService : ICalculatorService
    {
        public int Modulus(int a, int b)
        {
            return a % b;
        }
    }
}

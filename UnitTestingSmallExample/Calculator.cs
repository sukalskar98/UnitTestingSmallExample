using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSmallExample
{
    public class Calculator
    {
        private readonly ICalculatorService service;

        public Calculator(ICalculatorService service)
        {
            this.service = service;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a > b ? a - b : b - a;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Modulus(int a, int b)
        {
            return service.Modulus(a, b);
        }
    }
}

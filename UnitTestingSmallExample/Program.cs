using UnitTestingSmallExample;
ICalculatorService calculatorService = new CalculatorService();
Calculator obj = new Calculator(calculatorService);

Console.WriteLine(obj.Add(20, 10));
Console.WriteLine(obj.Subtract(20, 10));
Console.WriteLine(obj.Multiply(20, 10));
Console.WriteLine(obj.Divide(20, 10));
Console.WriteLine(obj.Modulus(20, 10));
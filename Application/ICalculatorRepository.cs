namespace CalculatorWebApi.Application;

public interface ICalculatorRepository
{
    double Add(CalculatorParameter calcParam);
    double Subtract(CalculatorParameter calcParam);
    double Multiply(CalculatorParameter calcParam);
    double DivideBy(CalculatorParameter calcParam);
}
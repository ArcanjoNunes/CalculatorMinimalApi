namespace CalculatorWebApi.Infra;

public class CalculatorRepository : ICalculatorRepository
{
    public double Add(CalculatorParameter calcParam)
    {
        return calcParam.v1 + calcParam.v2;
    }

    public double DivideBy(CalculatorParameter calcParam)
    {
        if (calcParam.v2 == 0) { throw new DivideByZeroException(); }
        return calcParam.v1 / calcParam.v2;
    }

    public double Multiply(CalculatorParameter calcParam)
    {
        return calcParam.v1 * calcParam.v2;
    }

    public double Subtract(CalculatorParameter calcParam)
    {
        return calcParam.v1 - calcParam.v2;
    }
}
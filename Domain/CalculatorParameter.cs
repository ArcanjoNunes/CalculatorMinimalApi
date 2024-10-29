namespace CalculatorWebApi.Domain;

public class CalculatorParameter
{
    public double v1 { get; set; } = 0;
    public double v2 { get; set; } = 0;

    public CalculatorParameter(double v1, double v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
}
namespace CalculatorMinimalApi.WebApi;

public class CalculatorEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var calculatorGroup = app.MapGroup("api");
        calculatorGroup.MapPost("/Add", Add);
        calculatorGroup.MapPost("/Subtract", Subtract);
        calculatorGroup.MapPost("/Multiply", Multiply);
        calculatorGroup.MapPost("/DivideBy", DivideBy);
    }

    public async Task<IResult>
        Add([FromBody] CalculatorParameter callParam, ICalculatorRepository calculator)
    {
        return await Task.FromResult(TypedResults.Ok(calculator.Add(callParam)));
    }

    public async Task<IResult>
        Subtract([FromBody] CalculatorParameter callParam, ICalculatorRepository calculator)
    {
        return await Task.FromResult(TypedResults.Ok(calculator.Subtract(callParam)));
    }

    public async Task<IResult>
        Multiply([FromBody] CalculatorParameter callParam, ICalculatorRepository calculator)
    {
        return await Task.FromResult(TypedResults.Ok(calculator.Multiply(callParam)));
    }

    public async Task<IResult>
        DivideBy([FromBody] CalculatorParameter callParam, ICalculatorRepository calculator)
    {
        if (callParam.v2 == 0)
        {
            return TypedResults.BadRequest(new DivideByZeroException());
        }
        return await Task.FromResult(TypedResults.Ok(calculator.DivideBy(callParam)));
    }

}

using FactorialLibrary;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (Func<string>)(() =>
{
    var factorialCalculator = new FactorialCalculator();
    int number = 5; // Change this to test different numbers
    var result = factorialCalculator.Calculate(number);
    return $"Factorial of {number} is {result}";
}));

app.Run();
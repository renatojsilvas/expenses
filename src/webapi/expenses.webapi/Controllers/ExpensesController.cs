using Microsoft.AspNetCore.Mvc;

namespace expenses.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExpensesController : ControllerBase
{
    private static Guid? Id = null;

    [HttpGet]
    public string GetId()
    {
        if (Id is null)
        {
            Id = Guid.NewGuid();
        }

        return $"Teste {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")} {Id}";
    }
}

using Expenses.Webapi.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace expenses.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddExpense([FromBody] NewExpenseInput newExpenseInput)
    {
		await Task.Delay(1);

        return Ok();
    }
}

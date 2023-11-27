using System.Net;

namespace Expenses.Webapi.Contracts.Base
{
    public class OutputBase
    {
        public HttpStatusCode StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();
    }
}
using System.Collections.Generic;

namespace ServiceStarter.Contracts
{
    public class ErrorResponse
    {
        public IList<string> Errors { get; set; }
    }
}

using System.Collections.Generic;

namespace PlaylistManager.Contracts
{
    public class ErrorResponse
    {
        public IList<string> Errors { get; set; }
    }
}

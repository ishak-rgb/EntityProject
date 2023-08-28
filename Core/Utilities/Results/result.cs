using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.results
{
    public class result : IResult
    {


        public result(bool success, string message) : this(success)
        {
            Message = message;

        }

        public result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

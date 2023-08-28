using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.results
{
    // temel voidler için başlnagıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }



    }
}

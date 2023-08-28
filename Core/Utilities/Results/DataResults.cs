using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.results
{
    public class DataResults<T> : result, IDataResult<T>
    {
        public DataResults(T data, bool Success, string message) : base(Success, message)
        {
            Data = data;
        }
        public DataResults(T data, bool Success) : base(Success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidleri için başlangış
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

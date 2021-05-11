using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)// işlem başarılı
        {

        }
        public SuccessResult() : base(true)// True defaul verdik
        {
        }
        
    }
}

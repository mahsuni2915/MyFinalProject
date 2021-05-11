using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult Run(params IResult [] locigs)//params virgülle istediğmiz kadar ıresult alabiliyorz

        {
            foreach (var logic in locigs)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}

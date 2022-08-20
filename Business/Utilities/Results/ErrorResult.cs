﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Utilities.Results
{
    //This will stand for the fail result of the "Result" class.
    public class ErrorResult:Result
    {
        //Since this class is for successful result, "success" property should be false as default.
        //All the possible versions of constructors are considered below.
        public ErrorResult(string message) : base(false, message)
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}

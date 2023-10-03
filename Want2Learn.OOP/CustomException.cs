using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    class CustomException : Exception
    {
        public string AdditionalProperty { get; set; }
        public CustomException(string additionalProp)
        {
            AdditionalProperty = additionalProp;
        }
        public CustomException(string additionalProp, string exceptionMessage) : base(exceptionMessage)
        {
            AdditionalProperty = additionalProp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class MyDivideByZeroException : Exception
    {
        public MyDivideByZeroException(string text)
            : base(text)
        {

        }
    }
}

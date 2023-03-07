using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class InputException: Exception
    {

        public InputException(string message) : base(message : message)
        {

        }

    }
}

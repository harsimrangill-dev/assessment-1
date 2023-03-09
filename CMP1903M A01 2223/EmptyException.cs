using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    //this is a custom exception class that inherits from exception
    //its is to catch exceptions created specifically in this code
    internal class EmptyPackException: Exception
    {

        //this is a custom exception if the list is empty

        //constructor

        public EmptyPackException(string message) : base(message: message)
        {

        }

    }
}

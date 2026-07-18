using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsInConsoleApp
{
    //Example for Customized Exception
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException():base($": ErrorInConsoleApp.InvalidAgeException")
        {
           
           
        }
        public InvalidAgeException(string message):base(message) 
        {

        }
    }
}

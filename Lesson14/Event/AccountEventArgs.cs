using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class AccountEventArgs
    {
        public string Message { get; set; }
        public double Sum { get; set; }

        public AccountEventArgs(string message, double sum)
        {
            Message = message;
            Sum = sum;
        }

    }
}

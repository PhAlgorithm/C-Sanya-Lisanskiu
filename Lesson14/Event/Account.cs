using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Account
    {
        public delegate void AccountSteteHendler (AccountEventArgs e);

        //Вывод денег
        public event AccountSteteHendler WithDrowed;

        //Прием денег
        public event AccountSteteHendler Added;

        private double _sum;

        public double CurrentSum => _sum;

        public Account(double sum)
        {
            _sum = sum;
        }

        public void Put(double sum)
        {
            _sum += sum;
            Added?.Invoke(new AccountEventArgs($"You account add {sum}. you  bill {_sum}", sum));
        }

        public void WithDrowe(double sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                WithDrowed?.Invoke(new AccountEventArgs($"You account took {sum}. you  bill {_sum} ", sum));
            }
            else
            {
                WithDrowed?.Invoke(new AccountEventArgs($"You Have not maney", 0));
            }
        }

    }
}

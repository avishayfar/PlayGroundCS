using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundCS
{
    public class Calc
    {
        private int _sum;

        public Calc()
        {
            _sum = 0;
        }

        public Calc Add(int num)
        {
            _sum += num;
            return this;
        }

        public Calc mul(int num)
        {
            _sum *= num;
            return this;
        }

        public int GetSum()
        {
            return _sum;
        }
    }
}

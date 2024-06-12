using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class PTBac1
    {
        private double a, b;

        public PTBac1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Giai()
        {
            if (a == 0)
            {
                throw new InvalidOperationException("Phương trình vô nghiệm");
            }
            return -b / a;
        }
    }
}

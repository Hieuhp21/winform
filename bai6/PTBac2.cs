using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{

    public class PTBac2
    {
        private double a, b, c;

        public PTBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Giai()
        {
            if (a == 0)
            {
                PTBac1 pt1 = new PTBac1(b, c);
                return pt1.Giai().ToString();
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "PT vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return "PT có nghiệm kép x = " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"PT có hai nghiệm x1 = {x1}, x2 = {x2}";
            }
        }
    }
}

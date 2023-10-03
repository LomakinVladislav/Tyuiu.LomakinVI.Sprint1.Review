using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LomakinVI.Sprint1.TaskReview.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double chisl = Math.Pow(Math.Log(Math.Sin(x)), x);
            double znam = Math.Log(1 + x * x);
            double dop = y - Math.Sqrt(Math.Abs(x));
            double z = chisl / znam + dop;
            return Math.Round(z, 3);
        }
    }
}

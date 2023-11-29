using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baskara {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c, x1, x2, delta;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine(), CI);

            delta = (b * b) - 4 * a * c;
            x1 = (- b + Math.Sqrt(delta)) / (2 * a);
            x2 = (- b - Math.Sqrt(delta)) / (2 * a);

            if (x1 > 0 || x2 > 0) {
                Console.WriteLine("X1 = " + x1.ToString("F4", CI));
                Console.WriteLine("X2 = " + x2.ToString("F4", CI));
            }
            else {
                Console.WriteLine("Esta equaçao nao possui raizes reais.");
            }

        }
    }
}

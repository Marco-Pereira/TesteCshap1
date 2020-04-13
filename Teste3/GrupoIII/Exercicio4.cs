using System;

namespace GrupoIII
{
    public class Exercicio4
    {
        
        private static void ValidarInput(int a, int b, string opt)
        {
            var op = opt[0];
            if(op != '+' && op != '-' && op != '*' && op != '/' && op != '%' ) throw new InvalidOperationException();
            if (op == '/'  && b == 0) throw new DivideByZeroException();
            if(a<0 || a > 100 || b<0 || b >100) throw new ArgumentOutOfRangeException();
            if(a%5==0 || b%3==0) throw new ArithmeticException();
        }

        private static void ValidarInput(int a, int b, char op)
        {
           
            if (op != '+' || op != '-' || op != '*' || op != '/' || op != '%') throw new InvalidOperationException();
            if (b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }
    }
}

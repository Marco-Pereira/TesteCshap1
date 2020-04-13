using System;

namespace GrupoIII
{
    public class Exercicio3
    {
        public static void Operacoes()


        {

            var op = "";

            Console.WriteLine("nr 1?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nr 2?");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o operador? +?-?*?/?%?");
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
            }
        }
      
    }
}

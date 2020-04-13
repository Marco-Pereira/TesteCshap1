using System;

namespace GrupoIII
{
    public class Exercicio2
    {
        #region QuantasPatas
        public static int QuantasPatas()
        {
            Console.WriteLine("Quantas vacas?");
            int vacas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos porcos?");
            int porcos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas galinhas?");
            int galinhas = int.Parse(Console.ReadLine());

            int total = 0;
            total += (vacas *4 );
            total += (porcos * 4);
            total += (galinhas * 4);

            Console.WriteLine(vacas + "vacas, " + porcos + " porcos, " + galinhas + 
                                        " galinhas " + " têm " + total + " patas");

            return total;
            
        }

        #endregion

        #region SolicitarNome
        public static void SoliNome()
        {
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);
        }
        #endregion

        #region ParOuImpar

        public static void ParOuImpar()
        {
            Console.WriteLine("Introduza um nr");
            var num = int.Parse(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine("O numero é par!");
            }
            else
            {
                Console.WriteLine("O numero não é par!");
            }
        }

        #endregion

        #region SomaDoisNumInt

        public static void SomaDoisNumInt(int num1, int num2)
        {
            Console.WriteLine("Introduza nr 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza nr 2");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                int result = num1 * num2 * 3;

                Console.WriteLine(result);
            }
            else
            {
                int result = num1 * num2;
                Console.WriteLine(result);
            }

            
        }


        #endregion

        #region PotenciaNum

        public static void PotenciaNum()
        {
            Console.WriteLine("Qual o numero?");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a potencia?");
            var potencia = int.Parse(Console.ReadLine());
            int resultado = 0;
            int count = 1;

            for (var i = 1; i < potencia; i++)
            {
                count += count * num;
                
                resultado = count;

            }
            Console.WriteLine(resultado);

        }

        #endregion

    }
}

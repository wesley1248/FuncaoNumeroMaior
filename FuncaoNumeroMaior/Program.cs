using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace FuncaoNumeroMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Apresentaçao.

            Console.WriteLine("Ola, digite abaixo tres numeros para compararmos");

            //Armazenagem dos numeros
            string[] numeros = Console.ReadLine().Split(',');
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);
            int num3 = int.Parse(numeros[2]);

            //Funçao.
            int maior(int a, int b, int c)
            {

                if (a > b && a > c)
                {
                    return a;

                }
                else if (b > a && b > c)
                {

                    return b;
                }
                else
                {
                    return c;
                }
            }
            //Exibiçao do resultado
            int resultado = maior(num1, num2, num3);
            Console.WriteLine("O numero maior é " + resultado);
            Console.ReadKey();
        }
    }
}


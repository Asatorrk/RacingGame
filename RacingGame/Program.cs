using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingGame
{
     class Program
    {
        static void Main(string[] args)
        {

            Boolean ganhou = false;
            string resp = "s";
            int aposta = 0;
            int ganhador = 0;
            while (resp == "s")
            {
                Pista pista1 = new Pista(100, new Corredor("d"));
                Pista pista2 = new Pista(100, new Corredor("f"));
                Pista pista3 = new Pista(100, new Corredor("g"));
                
                

                Console.Clear();
                Console.WriteLine("$#@ - Corrida Maluca - @#$");
                Console.WriteLine("Corredores \n1 - Danilo (d)\n2 - Fábio (f)\n3 - Gustavo (g)\n");
                Console.Write("Em qual corredor você aposta (1, 2 ou 3): ");
                 aposta = Convert.ToInt32(Console.ReadLine());
                 ganhador = 0;
                 ganhou = false;
                while (ganhou == false)
                {
                    Console.Clear();
                    if (pista1.AtualizarCorrida())
                    {
                        ganhou = true;
                        ganhador = 1;
                    }
                    else if (pista2.AtualizarCorrida())
                    {
                        ganhou = true;
                        ganhador = 2;
                    }
                    else if (pista3.AtualizarCorrida())
                    {
                        ganhou = true;
                        ganhador = 3;
                    }
                    pista1.ExibirPista();
                    pista2.ExibirPista();
                    pista3.ExibirPista();
                    //Console.ReadKey();
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine("$#@ - Corrida Maluca - @#$");
                Console.WriteLine($"O ganhador foi o corredor de número:  {ganhador} ");
                switch (ganhador)
                {
                    case 1:
                        Console.WriteLine("Danilo");
                        break;

                    case 2:
                        Console.WriteLine("Fábio");
                        break;

                    case 3:
                        Console.WriteLine("Gustavo");
                        break;
                }
                if (ganhador == aposta)
                {
                    Console.WriteLine("Parabéns!!! Você ganhou!!!");
                }
                else
                {
                    Console.WriteLine("Que pena você perdeu!!!");
                }
               Console.Write("Jogar novamente S ou N: ");
                resp = Console.ReadLine().ToLower();
            }
        }
    }
}

using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual é a dimensão do tabuleiro de jogo?");
            
            Console.Write("  Dimensão Horizontal = ");
            var horizontal = 0;
            try
            {
                horizontal = int.Parse(Console.ReadLine()) + 2;
            }
            catch
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Console.Write("  Dimensão Vertical = ");
            var vertical = 0;
            try
            {
                vertical = int.Parse(Console.ReadLine()) + 2;
            }
            catch
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            // Loading variables
            var attempt = 1;
            var random = new Random();
            var treasureX = random.Next(1, horizontal - 3);
            var treasureY = random.Next(1, vertical - 3);

            while (true)
            {

                Console.WriteLine("Tentativa #1");
                Console.Write("  X = ");
                var inputX = int.Parse(Console.ReadLine());

                Console.Write("  Y = ");
                var inputY = int.Parse(Console.ReadLine());

                if (inputX + 1 >= horizontal && inputY + 1 >= vertical)
                {
                    Console.WriteLine("Não podes fazer isso.");
                    continue;
                }
                
                if (inputX == treasureX && inputY == treasureY)
                {
                    Console.WriteLine("Acertaste em cheio à " + attempt);
                    break;
                }

                if (inputY > treasureY)
                {
                    Console.WriteLine("Tente para Norte");
                }
                else if (inputY < treasureY)
                {
                    Console.WriteLine("Tente para Sul");
                } 
                else if (inputX > treasureX)
                {
                    Console.WriteLine("Tente para Oeste");
                }
                else if (inputX < treasureX)
                {
                    Console.WriteLine("Tente para Este");
                }
                
                Console.WriteLine("Tabuleiro Atual");

                for (var y = 0; y < vertical; y++)
                {
                    for (var x = 0; x < horizontal; x++)
                    {

                        if (y == 0 || y == vertical - 1)
                        {
                            Console.Write("#");
                            continue;
                        }
                        
                        if (x == 0 || x == horizontal - 1)
                        {
                            Console.Write("#");
                            continue;
                        }


                        Console.Write((inputX == x && inputY == y) ? "P" : "~");
                    }
                    Console.WriteLine("");
                }

                attempt += 1;
            }
        }
    }
}
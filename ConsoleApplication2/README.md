# Exercicio 1

```csharp
int a = aleatorios.Next(2);
Console.WriteLine(a);
```

Este código vai dar um resultado entre 0 e 1

# Exercicio 2 

```csharp
int a = aleatorios.Next(2, 2);
Console.WriteLine(a);
```

Este código vai dar sempre dois porque o valor mínimo é 2 e o máximo é 2

# Exercicio 3

```csharp
Console.WriteLine(Int32.MaxValue);
```

Ele vai dar o maior numero inteiro de 32 bits

# Exercicio 4

```csharp
Random aleatorios = new Random();
for (int i = 0; i < 5; i++) {
    Console.WriteLine( aleatorios.Next(1, 51));
}
```

Este código vai gerar 5 numeros aleatórios de 1 a 50

# Exercicio 5

```csharp
Random aleatorios = new Random();
for (int i = 1; i <= 5; i++) {
    Console.WriteLine( aleatorios.Next(1, 51));
}
```

Este código vai fazer a mesma coisa que o antrior, Só que em vez de i ser igual a = 0 é igual a 1 e o limite do exercicio antrior é < 5 e neste é <= 5.
# Exercicio 6

```csharp
Random aleatorios = new Random();
int x = 0, c = 0;
while (x != 50) {
    x = aleatorios.Next(101);
    c = c + 1;
}
Console.WriteLine(c);
```

Este código vai repetir até o numero aleatório for igual a 50, e vai mostrar o numero de vezes que teve de repetir para chegar a esse resultado

# Exercicio 7

```csharp
Random random = new Random();
var x = random.Next(1, 9);
```

# Exercicio 8

```csharp
Random random = new Random();
var x = random.Next(0, 10);
```

# Exercicio 9

```csharp
Random random = new Random();
var x = random.Next(2, 9);
```

# Exercicio 10

```csharp
Random random = new Random();
var x = random.Next(0, 2);
```

# Exercicio 11

```csharp
```csharp
Random random = new Random();
var x = random.Next(7);
```

```csharp
```csharp
Random random = new Random();
var x = random.Next(0, 7);
```

# Exercicio 12

```csharp

var random = new Random();
var running = true;

while (running)
{
    Console.Write("Lançar dado (S/N) ");
    var response = Console.ReadLine().ToLower();

    switch (response)
    {
        case "s":
            Console.WriteLine(random.Next(1, 7));
            break;
        case "n":
            Console.WriteLine("Terminado.");
            running = false;
            break;
        default:
            Console.WriteLine("Comando desconhecido.");
            break;
    }

    Thread.Sleep(3000);
                
    Console.Clear();
}
```

# Exercicio 13

```csharp
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var random = new Random();
            var cache = 0;

            while (true)
            {
                Console.Write("Quantos dados quer lançar (1, 2, 3, 4, 5, 6 ou sair) ");
                var response = Console.ReadLine();

                if (response.Equals("sair", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Terminado.");
                    break;
                }
                
                try
                {

                    var value = int.Parse(response);
                    var total = 0;
                    
                    for (var i = 0; i < value; i++)
                    {
                        cache = random.Next(1, 7);
                        
                        if (i+1 == value)
                        {
                            Console.Write(cache);
                        }
                        else
                        {
                            Console.Write(cache + " + ");
                        }
                        
                        total += cache;
                    }
                    
                    Console.Write(" = " + total);

                    Thread.Sleep(3000);
                    Console.Clear();
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Terminado.");
                    break;
                }
            }
        }
    }
}
```

# Exercicio 14

Existem muitas formas de fazer uma chave para o euromilhões em que 5 números são entre 1 e 50 e 2 estrelas entre 1 e 11. <br> <br>

```csharp
using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            for (var i = 1; i < 6; i++)
            {
                Console.WriteLine(i + " número é " + random.Next(1, 51));
            }

            for (var i = 1; i < 3; i++)
            {
                Console.WriteLine(i + " estrela é " + random.Next(1, 12));
            }
        }
    }
}
```

# Exercicio 15

```csharp
using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var x = random.Next(1, 11);

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    var number = int.Parse(input);
                    Console.WriteLine(number == x ? "Você acertou." : "Você errou.");
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(input + " não é um numero");
                }
            }
        }
    }
}
```

# Exercicio 16

```csharp
using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var x = random.Next(1, 11);
            var attempts = 3;

            while (true)
            {
                
                Console.Write("Digite um numero entre 1 e 10: ");

                if (attempts == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Você perdeu.");
                    Console.WriteLine("O número correto era " + x);
                    break;
                }
                
                var input = Console.ReadLine();

                try
                {
                    var number = int.Parse(input);

                    if (number == x) {
                        Console.WriteLine("Você acertou");
                    }
                    else
                    {
                        Console.WriteLine("Você errou");
                        attempts--;
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(input + " não é um numero");
                }
            }
        }
    }
}
```

# Exercicio 17
```csharp
using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Quantas tentativas deseja ter: ");
            var attempts = int.Parse(Console.ReadLine());

            var random = new Random();
            var x = random.Next(1, 11);

            while (true)
            {
                
                Console.Write("Digite um numero entre 1 e 10: ");

                if (attempts == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Você perdeu.");
                    Console.WriteLine("O número correto era " + x);
                    break;
                }
                
                var input = Console.ReadLine();

                try
                {
                    var number = int.Parse(input);

                    if (number == x) {
                        Console.WriteLine("Você ganhou");
                        break;
                    }
                    else
                    {
                        attempts--;
                        Console.WriteLine("Você errou");
                        Console.WriteLine("Você têm " + attempts);
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(input + " não é um numero");
                }
            }
        }
    }
}
```

# Exercicio 18

```csharp
using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantas tentativas deseja ter: ");
            var attempts = int.Parse(Console.ReadLine());

            var random = new Random();
            var x = random.Next(1, 11);

            while (true)
            {
                Console.Write("Digite um numero entre 1 e 10: ");

                if (attempts == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Você perdeu.");
                    Console.WriteLine("O número correto era " + x);
                    break;
                }

                var input = Console.ReadLine();
                var number = int.Parse(input);

                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Só se pode digitar numeros entre 1 e 10");
                    return;
                }

                if (number == x)
                {
                    Console.WriteLine("Você ganhou");
                    break;
                }

                attempts--;
                Console.WriteLine("Você errou");
                Console.WriteLine("Você têm " + attempts);
            }
        }
    }
}
```

# Pequeno Projeto

```csharp
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
```

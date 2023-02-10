namespace Exercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("----------Exercício 1: Mostre os ímpares");

      System.Console.WriteLine("Informe um número inteiro");
      int numero = int.Parse(Console.ReadLine());

      for (int i = 0; i <= numero; i++)
      {
        if (i % 2 != 0)
        {
          System.Console.WriteLine(i);
        }
      }

      System.Console.WriteLine("----------Exercício 2: Calcule o fatorial");

      System.Console.WriteLine("Informe um número inteiro");
      int n = int.Parse(Console.ReadLine());
      int fatorial = 1;

      for (int i = 1; i <= n; i++)
      {
        fatorial *= i;
      }

      System.Console.WriteLine(fatorial);

      System.Console.WriteLine("----------Exercício 3: Calcule todos os divisores");

      System.Console.WriteLine("Informe um número inteiro");
      int x = int.Parse(Console.ReadLine());

      for (int i = 1; i <= x; i++)
      {
        if (x % i == 0)
        {
          System.Console.WriteLine(i);
        }
      }
    }
  }
}
using System;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main()
    {
      var soundexPtBr = Fonetico.Fonetiza("João de Deus");
      Console.WriteLine(soundexPtBr.Normalize());

      Console.WriteLine("press any key to exit:");
      Console.ReadKey();
    }
  }
}

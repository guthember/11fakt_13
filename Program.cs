using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TobbAdat
{
  class Program
  {
    static void Main(string[] args)
    {
      // "adatok.txt"-ben nevek és életkorok találhatóak
      // ;-vel tagolva!
      string[] nevek = new string[4];
      int[] eletkor = new int[4];
      int i = 0;

      StreamReader file = new StreamReader("adatok.txt");

      while (!file.EndOfStream)
      {
        string sor = file.ReadLine(); // sor = "Kiss Piroska;16"
        string[] adatok = sor.Split(';');
        // adatok[0] = "Kiss Piroska"
        // adatok[1] = "16"
        nevek[i] = adatok[0];
        eletkor[i] = Convert.ToInt32(adatok[1]);
        Console.WriteLine("Név: "+nevek[i]+" Életkor: "+eletkor[i]);
        Console.WriteLine("Két év múlva:");
        Console.WriteLine("Név: " + nevek[i] + " Életkor: " + (eletkor[i]+2));
        i++;
      }

      file.Close();

      Console.ReadKey();









    }
  }
}

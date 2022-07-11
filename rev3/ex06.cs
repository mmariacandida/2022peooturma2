using System;
class Program{
  public static void Main(){
    int x = 1;
    while (x <= 30) {
      Console.WriteLine(x);
      if (x % 3 == 0) Console.WriteLine(x + (x - 1) + (x -      2));
      x++;
    }
  }
}
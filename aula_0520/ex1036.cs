using System;
class Program{
  public static void Main(){
   // Console.WriteLine("Digite agora");
      string[] X = Console.ReadLine().Split();
    
      double a = double.Parse(X[0]);
      double b = double.Parse(X[1]);
      double c = double.Parse(X[2]);
    
      double delta = Math.Sqrt((b * b) - 4 * a * c);
      if (delta < 0 || a == 0) Console.WriteLine("Impossivel calcular");
      else {
    
      double R1 = (-b + delta) / (2 * a);
      double R2 = (-b - delta) / (2 * a);

      Console.WriteLine($"R1 = {R1:f5}");
      Console.WriteLine($"R2 = {R2:f5}");
    
      }
    }
    
}
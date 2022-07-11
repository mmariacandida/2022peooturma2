using System;
class Program{
  public static void Main(){
    
    for (int i =1; i<=10 ; i++){
      Console.WriteLine($"Tabuada de {i}");
      for (int j=1; j<=10 ; j++){
          Console.WriteLine($"{i} x {j} = {i*j}");
        }
      }
    }
    }

/*
Saida
Tabuada de 1
  1 x 1 = 1
  1 x 2 = 2
  ....
  1 x 10 = 10
*/
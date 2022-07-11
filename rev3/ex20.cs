using System;
class Program{
  public static void Main(){
    
    for (int i =1; i<=10 ; i++){
      Console.Write($"{i} ");
      for (int j=1; j<=i ; j++){
        if (j%2==0){//verificar se o numero é par
          Console.Write($"{j} ");
        }
      }
      Console.WriteLine();//Dar uma quebra de linha
    }
    }
  }

/*
Saida
20. Mostrar a sequência de números abaixo.
Resultado: 
1
2 2
3 2
4 2 4
5 2 4
6 2 4 6
...
10 2 4 6 8 10
Obs: Primeira coluna: números de 1 a 10, demais colunas: números pares menores/iguais ao valor da 1a coluna.
*/
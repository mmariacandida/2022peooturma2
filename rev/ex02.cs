using System;

public class Program {
  public static void Main(string[] args) {
    Compra h = new Compra();
    Console.WriteLine("digite o valor total:");
    h.SetTotal(double.Parse(Console.ReadLine()));
    Console.WriteLine("digite o número de prestações:");
    h.SetNumPrestacoes(int.Parse(Console.ReadLine()));
    Console.WriteLine($"Valor das prestações = {h.GetValorPrestacao()}");
    Console.WriteLine($"Valor do desconto = {h.GetValorDesconto()}");   
  }
}

public class Compra {
  private double total;
  private int numPrestacoes;
  public void SetTotal(double x){
    if (x>0) total = x;
  }
  public void SetNumPrestacoes(int y){
    if (y>0) numPrestacoes = y;
  }
  public double GetValorPrestacao(){
    double x = total/numPrestacoes;
    return x;
  }
  public double GetValorDesconto(){
    double x = total - (total * 0.15);
    return x;
  }
  
}
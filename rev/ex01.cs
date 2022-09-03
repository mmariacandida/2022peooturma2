using System;

public class Program {
  public static void Main(string[] args) {
    IMC x = new IMC();
    Console.WriteLine("Digite um peso:");
    x.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite uma altura:");
    x.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine($"o imc é: {x.CalcIMC()}");
  }
}

public class IMC {
  private double peso;
  private double altura;
  public void SetPeso(double p){
    if (p>0) peso = p;
  }
  public void SetAltura(double a){
    if (a>0) altura = a;
  }
  public double GetPeso(){
    return peso;
  }
  public double GetAltura(){
    return altura;
  }
  public double CalcIMC(){
    double imc = peso/altura;
    return imc;
  }
}
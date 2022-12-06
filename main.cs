using System;

class Program {
  public static void Main (string[] args) {
//Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo):

  String entrada;
  Double F, C;
    Console.WriteLine ("Digite a temperatura em Fahrenheit");
    entrada = Console.ReadLine();
   F = Double.Parse(entrada);
    C= 5.0/9.0*(F-32.0);
       Console.WriteLine ("Celsius " + C );
  }
}
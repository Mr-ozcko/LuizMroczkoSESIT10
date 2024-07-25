using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine ("Escolha uma operação: + Adicao // - Subtracao // * Multiplicacao // / Divisao");
    string op = Console.ReadLine();
    Console.WriteLine("Digite o primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor: ");
    float num2 = float.Parse(Console.ReadLine());

    if(op == "+"){
      Console.WriteLine($"Resultado da soma de {num1} e {num2} eh {num1 + num2}");
    } else if(op == "-"){
      Console.WriteLine($"Resultado da subtracao de {num1} e {num2} eh {num1 - num2}");
    } else if(op == "*"){
      Console.WriteLine($"Resultado da multiplicacao de {num1} e {num2} eh {num1 * num2}");
    } else if(op == "/"){
      Console.WriteLine($"Resultado da divisao de {num1} e {num2} eh {num1 / num2}");
    } else {
      Console.WriteLine($"O operador {op} eh invalido");
    }
    }
}
using System;
class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Digite o valor para ver se eh par ou impar: ");
    float num = float.Parse(Console.ReadLine());

    if (num % 2 == 0){
      Console.WriteLine($"O numero {num} eh par");
    } else {
      Console.WriteLine($"O numero {num} eh impar");
    }
  }
}

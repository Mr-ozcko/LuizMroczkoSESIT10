using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Digite o dia da semana para ver seu cronograma: \n seg - segunda \n ter - terça \n qua - quarta \n qui - quinta \n sex - sexta");
        string dia = Console.ReadLine();

        switch (dia) {
            case "seg":
                Console.WriteLine("Livre \n Port \n Senai \n Hist \n Intervalo \n Ing \n Senai");
                break;
            case "ter":
                Console.WriteLine("Trilha \n Mat \n Senai \n Quim \n Intervalo \n Hist \n Senai");
                break;
            case "qua":
                Console.WriteLine("Livre \n Senai \n Senai \n Senai \n Senai \n Geo");
                break;
            case "qui":
                Console.WriteLine("Bio \n Port \n Work \n Senai \n Intervalo \n Senai \n Mat");
                break;
            case "sex":
                Console.WriteLine("Senai \n Senai \n Ed Fis \n Ed Fis \n Fis \n Livre");
                break;
            default:
                Console.WriteLine("Dia inválido.");
                break;
        }
    }
}

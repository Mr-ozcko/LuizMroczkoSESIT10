﻿

class HelloWorld
{
    public static void Escreve()
    {
        Console.WriteLine("_|                  _|  _|                                                              _|        _|  _|\r\n_|_|_|      _|_|    _|  _|    _|_|              _|      _|      _|    _|_|    _|  _|_|  _|    _|_|_|  _|\r\n_|    _|  _|_|_|_|  _|  _|  _|    _|            _|      _|      _|  _|    _|  _|_|      _|  _|    _|  _|\r\n_|    _|  _|        _|  _|  _|    _|              _|  _|  _|  _|    _|    _|  _|        _|  _|    _|\r\n_|    _|    _|_|_|  _|  _|    _|_|      _|          _|      _|        _|_|    _|        _|    _|_|_|  _|\r\n                                      _|\r\n\r\n");
    }
}

class Calculadora
{
    public static void Inicia()
    {
        Console.WriteLine("Selecione a Operação:\n" +
            "1) Soma\n" +
            "2) Subtração\n" +
            "3) Multiplicação\n" +
            "4) Divisão");

        Console.Write(">");
        string op = Console.ReadLine();

        Console.Write("Numero 1:");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Numero 2:");
        float num2 = float.Parse(Console.ReadLine());

        float? resultado = Calcula(op, num1, num2);

        if (resultado == null)
        {
            Console.WriteLine("Operação Inválida");
            return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }

    public static float? Calcula(string op, float num1, float num2)
    {
        switch(op)
        {
            case "1":
                return num1 + num2;
            case "2":
                return num1 - num2;
            case "3":
                return num1 * num2;
            case "4":
                return num1 / num2;
            default:
                return null;
        }
    }
}

class ParImpar
{
    public static void Inicia()
    {
        Console.Write("Digite um Número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Par!");
        } else
        {
            Console.WriteLine("Ímpar");
        }
    }
}

class Program
{
    public static bool deve_sair = false;

    public static void Main(string[] args)
    {
        while (!deve_sair)
        {
            Console.WriteLine("Escolha um Programa:\n" +
                "1) Hello World\n" +
                "2) Calculadora\n" +
                "3) Par ou Ímpar\n" +
                "4) Sair");

            Console.Write(">");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    HelloWorld.Escreve();
                    break;
                case "2":
                    Calculadora.Inicia();
                    break;
                case "3":
                    ParImpar.Inicia();
                    break;
                case "4":
                    deve_sair = true;
                    break;
            }
        }
    }

}
class Program
{
    static void Main()
    {
        double numero1, numero2, resultado;
        int opcao;

        Console.WriteLine(" CALCULADORA ");

        Console.Write("Digite o primeiro número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.Write("Digite sua opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado da soma: " + resultado);
                break;

            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado da subtração: " + resultado);
                break;

            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado da multiplicação: " + resultado);
                break;

            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado da divisão: " + resultado);
                }
                else
                {
                    Console.WriteLine("Erro! Não é possível dividir por zero.");
                }
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
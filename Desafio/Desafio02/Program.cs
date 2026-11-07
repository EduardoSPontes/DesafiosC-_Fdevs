class Program
{
    static void Main()
    {
        double peso, altura, imc;

        Console.Write("Digite seu peso em kg: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Classificação: Obesidade grau I");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Classificação: Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade grau III");
        }
    }
}
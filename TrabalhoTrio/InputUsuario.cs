

using Classes;
using System.Linq.Expressions;
using TrabalhoTrio;

Console.WriteLine("Bem vindo ao programa de testes:");
bool continua = true;
do 
{
    Console.WriteLine("Digite 0 para sair\nDigite 1 para somar dois numeros\nDigite 2 para converter metro em milimetro\nDigite 3 para calcular o fatorial\n");
    int resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 0:
            continua = false;
            break;
        case 1:
            Console.WriteLine("\nVocê escolheu somar dois números");
            Console.WriteLine("Entre com o 1º número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o 2º número");
            int b = int.Parse(Console.ReadLine());
            Calcula calcula = new Calcula();
            Console.WriteLine($"O resultado da soma de {a} + {b} é {calcula.Soma(a, b)}\n");
            break;
        case 2:
            Console.WriteLine("\nVocê escolheu Converter metros para milimetros");
            Console.WriteLine("Entre com a quantidade em metros");
            decimal metro = decimal.Parse(Console.ReadLine());
            Converte converte = new Converte();
            Console.WriteLine($"{metro} metros(s) convertido(s) em milimetros é {converte.MetroParaMilimetro(metro)}\n");
            break;
        case 3:
            Console.WriteLine("\nVocê escolheu contar fatoriais");
            Console.WriteLine("Entre com limite de fatorial");
            int limite = int.Parse(Console.ReadLine());

            FatorialCalculator fatorial = new FatorialCalculator();
            Console.WriteLine($"{fatorial.CalcFato(limite)}");
            break;

    }

} while(continua == true);

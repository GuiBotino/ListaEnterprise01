//LISTA DE EXERCÍCIOS
//1-A

Console.Write("Insira o valor da base do triângulo: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Insira o valor da altura do triângulo: ");
float c = float.Parse(Console.ReadLine());

float area = (a * c) / 2;
Console.WriteLine($"Área do triângulo: {area}");

//1-B
Console.Write("Insira o valor do raio do círculo: ");
float c2 = float.Parse(Console.ReadLine());

float area2 = (float)((3.14) * (c2 * c2));
Console.WriteLine($"Área do círculo: {area2}");

//1-C
Console.Write("Insira o valor da primeira base do trapezio: ");
float a2 = float.Parse(Console.ReadLine());

Console.Write("Insira o valor da segunda base do trapezio: ");
float b = float.Parse(Console.ReadLine());

Console.Write("Insira o valor da altura do trapezio: ");
float c3 = float.Parse(Console.ReadLine());

float area3 = (a2 * b) * c3 / 2;    

Console.WriteLine($"A área do trapézio é : {area3}");

//1-D
Console.Write("Informe o valor da base do quadrado: ");
float b2 = float.Parse(Console.ReadLine());

float area4 = b2 * b2;

Console.WriteLine($"A área do quadrado é : {area4}");

//1-E
Console.Write("Informe o valor da base do retângulo: ");
float a3 = float.Parse(Console.ReadLine());

Console.Write("Informe o valor da altura do retângulo: ");
float b3 = float.Parse(Console.ReadLine());

float area5 = a3 * b3;

Console.WriteLine($"A área do retângulo é : {area5}");

//2
Console.Write("Informe o primeiro valor: ");
int a4 = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo valor: ");
int b4 = int.Parse(Console.ReadLine());

if (a4 % b4 == 0)
{
    Console.WriteLine($"{a4} e {b4} são múltiplos");
}
else
{
    Console.WriteLine($"{a4} e {b4} não são múltiplos");
}

//3
Console.Write("Informe em horas a estimativa mais otimista: ");
float otimista = float.Parse(Console.ReadLine());

Console.Write("Informe em horas a estimativa mais pessimista: ");
float pessimista = float.Parse(Console.ReadLine());

Console.Write("Informe em horas a estimativa mais provável: ");
float provavel = float.Parse(Console.ReadLine());

float estimativa = (otimista + pessimista + (4 * provavel)) / 6;

Console.WriteLine($"Valor da PERT: {Math.Round(estimativa, 2)}");

//4
Console.Write("Insira a nota do aluno: ");
float nota = float.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aluno aprovado");
}
else if (nota < 7 && nota >= 4)
{
    Console.WriteLine("Aluno em recuperação");
}
else if (nota < 4)
{
    Console.WriteLine("Aluno reprovado");
}

//5
Console.WriteLine("1 - Bom dia");
Console.WriteLine("2 - Boa tarde");
Console.WriteLine("3 - Boa noite");
Console.Write("Escolha um número: ");
int escolha = int.Parse(Console.ReadLine());    

switch (escolha)
{
    case 1:
        Console.WriteLine("Bom dia");
        break;
    case 2:
        Console.WriteLine("Boa tarde");
        break;
    case 3:
        Console.WriteLine("Boa noite");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

//6
Console.Write("Informe um número: ");
int fatorial = int.Parse(Console.ReadLine());

for (int i = fatorial - 1; i > 0; i--)
{
    fatorial *= i;
    Console.WriteLine("fatorial: " + fatorial);
}

//7
Console.Write("Informe um número: ");
int valor = int.Parse(Console.ReadLine());

for (int i = 1; i <= valor; i++)
{
    Console.WriteLine($"{i} {i * i} {i * i * i}");
}

//8
int chaves = 0;
int chiquinha = 0;
int quico = 0;
int nulo = 0;
int branco = 0;
int total = 0;
double porcNulo = (nulo / total) * 100;
double porcBranco = (branco / total) * 100;
do
{
    Console.Write("1.Candidato Chaves\n" +
    "2.Candidata Chiquinha\n" +
    "3.Candidato Quico\n" +
    "4.Nulo\n" +
    "5.Branco\n" +
    "6.Encerrar a votação\n" +
    "Entre com o seu voto: ");
    int escolha2 = int.Parse(Console.ReadLine());

    if (escolha2 == 1)
    {
        chaves++;
        total++;
    }
    else if (escolha2 == 2)
    {
        chiquinha++;
        total++;
    }
    else if (escolha2 == 3)
    {
        quico++;
        total++;
    }
    else if (escolha2 == 4)
    {
        nulo++;
        total++;
    }
    else if (escolha2 == 5)
    {
        branco++;
        total++;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }

} while (escolha2 != 6);
Console.WriteLine($"Votos: Chaves - {chaves}, Chiquinha - {chiquinha}, Quico: {quico}, Nulo: {nulo}, Branco: {branco}");
Console.WriteLine($"Porcentagem de votos nulos: {porcNulo}%");
Console.WriteLine($"Porcentagem de votos em branco: {porcBranco}%");
if (chaves > chiquinha && chaves > quico)
{
    Console.WriteLine("Chaves Vencedor!");
}
else if (chiquinha > chaves && chiquinha > quico)
{
    Console.WriteLine("Chiquinha Vencedora!");
}
else if (quico > chaves && quico > chiquinha)
{
    Console.WriteLine("Quico Vencedor!");
}

using System;
using System.Data.SqlTypes;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosCursoCSharp
{
    class Program

    // Aplicação simples para execução dos primeiros exercícios do curso, com estrutura simples
    // Após a conclusão de cada exercídio, deixarei o código do mesmo comentado, para prosseguir com o curso usando esta mesma aplicação.


    {
        static void Main(string[] args)


        {

            #region Seção 1

            #region Atividade 1

            #region Questão 1

            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
            // o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago


            //string codItem1, codItem2, cont = "S";
            //int qtdItem1, qtdItem2;
            //double valorUnitItem1, valorUnitItem2, valorTotalItem1, valorTotalItem2, valorTotal;


            //while (cont.ToString() == "S" || cont.ToString() == "SIM")

            //{
            //    Console.WriteLine("Digite o código da primeiro item:");
            //    codItem1 = Console.ReadLine();
            //    Console.WriteLine("Digite a quantidade a ser vendida desta primeiro item:");
            //    qtdItem1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor unitário do primeiro item:");
            //    valorUnitItem1 = double.Parse(Console.ReadLine());


            //    Console.WriteLine("Digite o código da segundo item:");
            //    codItem2 = Console.ReadLine();
            //    Console.WriteLine("Digite a quantidade a ser vendida desta segundo item:");
            //    qtdItem2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor unitário do segundo item:");
            //    valorUnitItem2 = double.Parse(Console.ReadLine());


            //    valorTotalItem1 = qtdItem1 * valorUnitItem1;
            //    valorTotalItem2 = qtdItem2 * valorUnitItem2;
            //    valorTotal = valorTotalItem1 + valorTotalItem2;


            //    Console.WriteLine($"O valor total do primeiro item é R${valorTotalItem1:F2} e o valor total do segundo item é R${valorTotalItem2:F2}, totalizando R${valorTotal:F2})");

            //    Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}



            #endregion

            #region Questão 2

            // Faça um programa para ler o valor do raio de um círculo, 
            // e depois mostrar o valor da área deste círculo com quatro
            // casas decimais conforme exemplos.
            // Fórmula: area = π.raio²
            // Considere o valor de π = 3.14159

            //double pi = 3.14159, area = 0, raio = 0;
            //string cont = "S";

            //while (cont.ToString() == "S" || cont.ToString() == "SIM")

            //{

            //    Console.WriteLine("Digite o valor do raio do círculo que deseja calcular a área:");
            //    raio = double.Parse(Console.ReadLine());

            //    area = pi * Math.Pow(raio, 2);

            //    Console.WriteLine($"A área calculada para o raio digitado é: {area:F4}");


            //    Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}
            #endregion

            #region Questão 3

            // Com base na tabela de preços ao lado (abaixo), faça
            // um programa que leia o código de um item e a
            // quantidade deste item. A seguir, calcule e
            // mostre o valor da conta a pagar.

            //CÓDIGO / ESPECIFICAÇÃO / PREÇO

            // 1   Cachorro Quente     R$4,00
            // 2   X - Salada          R$4,50
            // 3   X - Bacon           R$5,00
            // 4   Torrada Simples     R$2,00
            // 5   Refrigerante        R$1,50



            //int cod = 0;
            //int qtd = 0;
            //double total = 0;
            //string cont = "S";

            //while (cont.ToString() == "S" || cont.ToString() == "SIM")
            //{



            //    string[,] Produtos = new string[5, 3];

            //    Produtos[0, 0] = "1";
            //    Produtos[0, 1] = "Cachorro Quente";
            //    Produtos[0, 2] = "4,00";

            //    Produtos[1, 0] = "2";
            //    Produtos[1, 1] = "X - Salada";
            //    Produtos[1, 2] = "4,50";

            //    Produtos[2, 0] = "3";
            //    Produtos[2, 1] = "X- Bacon";
            //    Produtos[2, 2] = "5,00";

            //    Produtos[3, 0] = "4";
            //    Produtos[3, 1] = "Torrada Simples";
            //    Produtos[3, 2] = "2,00";

            //    Produtos[4, 0] = "5";
            //    Produtos[4, 1] = "Refrigerante";
            //    Produtos[4, 2] = "1,50 ";

            //    Console.WriteLine("Digite o código do produto que deseja realizar a venda:");
            //    cod = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digita a quantidade que deseja vender:");
            //    qtd = int.Parse(Console.ReadLine());


            //    switch (cod)
            //    {
            //        case 1:

            //            total = double.Parse(Produtos[0, 2]) * qtd;
            //            Console.WriteLine($"O valor total é: R${total:F2}");

            //            Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //            cont = Console.ReadLine().ToUpper();

            //            break;

            //        case 2:

            //            total = double.Parse(Produtos[1, 2]) * qtd;
            //            Console.WriteLine($"O valor total é: R${total:F2}");

            //            Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //            cont = Console.ReadLine().ToUpper();

            //            break;

            //        case 3:

            //            total = double.Parse(Produtos[2, 2]) * qtd;
            //            Console.WriteLine($"O valor total é: R${total:F2}");

            //            Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //            cont = Console.ReadLine().ToUpper();

            //            break;

            //        case 4:

            //            total = double.Parse(Produtos[3, 2]) * qtd;
            //            Console.WriteLine($"O valor total é: R${total:F2}");

            //            Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //            cont = Console.ReadLine().ToUpper();

            //            break;

            //        case 5:

            //            total = double.Parse(Produtos[4, 2]) * qtd;
            //            Console.WriteLine($"O valor total é: R${total:F2}");

            //            Console.WriteLine("Deseja calcular outro caso? (Sim/Não)");
            //            cont = Console.ReadLine().ToUpper();

            //            break;


            //    }
            //}




            #endregion

            #region Questão 4

            // Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau(ax²+bx + c = 0)
            // Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara(veja
            // abaixo).Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
            // negativo), mostrar uma mensagem "Impossivel calcular".
            // Fórmula:  = x = – b ± √Δ
            //                   2·a
            // Onde Δ(Delta) = b² -4ac

            //double delta, a, b, c, baskara, x1, x2;
            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Console.WriteLine("Vamos calcular uma equação de 2º Grau.");
            //    Console.WriteLine("Digite o valor de A:");
            //    a = Double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de B:");
            //    b = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de C:");
            //    c = double.Parse(Console.ReadLine());

            //    delta = Math.Pow(b, 2) - 4 * a * c;

            //    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //    if (delta >= 0 && a != 0)
            //    {

            //        Console.WriteLine($"O valor de X1 é igual à: {x1:F5} e o valor de X2 é: {x2:F5}");

            //        Console.WriteLine("Deseja calcular outro caso?(Sim/Não)");

            //    }

            //    else
            //    {
            //        Console.WriteLine("Impossível calcular!");

            //        Console.WriteLine("Deseja calcular outro caso?(Sim/Não)");
            //        cont = Console.ReadLine().ToUpper();

            //    }


            //}

            #endregion

            #region Questão 5

            // Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            // incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.




            //int senha = 0;

            //while (senha != 2002)

            //{


            //    Console.WriteLine("Digte a senha:");
            //    senha = int.Parse(Console.ReadLine());

            //    if (senha == 2002)
            //    {
            //        Console.WriteLine("Acesso Permitido!");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Senha Invalida!");

            //    }

            //}

            #endregion

            #region Questão 6

            // Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            //string cont = "S";
            //int n = 0, numero = 0, contArray = 0;

            //while (cont == "S" || cont == "SIM")
            //{
            //    int dentro = 0, fora = 0;
            //    Console.WriteLine("Digite a quantidade de números que será digitada:");
            //    n = int.Parse(Console.ReadLine());

            //    if (n > 0)
            //    {
            //        for (int i = 1; i <= n; i++)

            //        {

            //            Console.WriteLine($"Digite o {i}º número:");
            //            numero = int.Parse(Console.ReadLine());
            //            int[] numeros = new int[n];
            //            numeros[contArray] = numero;

            //            if (numero >= 10 && numero <= 20)
            //            {
            //                dentro++;
            //            }

            //            else
            //            {
            //                fora++;
            //            }

            //        }


            //    }

            //    else
            //    {
            //        Console.WriteLine("Digite um número maior que 0!");
            //    }

            //    Console.WriteLine($"Há {dentro} número(s) dentro do intervalo determinado e {fora} fora deste intervalo.");

            //    Console.WriteLine("Deseja realizar um novo calculo?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}



            #endregion

            #endregion

            #endregion

            #region Seção 2

            //Não houve exercídio nesta seção

            #endregion

            #region Seção 3

            #region Atividade 1

            #region Questão 1

            // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            // mensagem explicativa, conforme exemplos.

            //int n1, n2, soma;
            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o valor do primeiro número:");
            //    n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor do segundo número:");
            //    n2 = int.Parse(Console.ReadLine());
            //    soma = n1 + n2;

            //    Console.WriteLine($"A somas dos números {n1} e {n2} é {soma}.");

            //    Console.WriteLine("Deseja realizar outro calculo?(Sim/Nã0)");
            //    cont = Console.ReadLine();

            //}

            #endregion

            #region Questão 2

            // Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            //int a, b, c, d, dif;
            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o valor de A:");
            //    a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de B:");
            //    b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de C:");
            //    c = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de D:");
            //    d = int.Parse(Console.ReadLine());

            //    dif = (a * b) - (c * d);

            //    Console.WriteLine($"A diferença dos produtos é igual a:{dif}");

            //    Console.WriteLine("Deseja realizar outro calculo?(Sim/Não)");
            //    cont = Console.ReadLine();

            //}


            #endregion

            #region Questão 3

            // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            // hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            // decimais.

            //double[] funcionario = new double[4];
            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o código do funcionário:");
            //    funcionario[0] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o número de horas trabalhadas:");
            //    funcionario[1] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor que ele recebe por hora:");
            //    funcionario[2] = double.Parse(Console.ReadLine());
            //    funcionario[3] = funcionario[1] * funcionario[2];

            //    Console.WriteLine($"O código digitado para o funcionário é: {funcionario[0]} e ele irá ganhar R${funcionario[3]:F2} de salário.");

            //    Console.WriteLine("Deseja digitar informações de outro funcionário?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}


            #endregion

            #region Questão 4

            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            //double[,] pecas = new double[2, 3];
            //double totalPedido;
            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o código da primeira peça:");
            //    pecas[0, 0] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite a quantidade de peças a serem vendidas:");
            //    pecas[0, 1] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor da peça a ser vendidas:");
            //    pecas[0, 2] = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o código da segunda peça:");
            //    pecas[1, 0] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite a quantidade de peças a serem vendidas:");
            //    pecas[1, 1] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor da peça a ser vendidas:");
            //    pecas[1, 2] = double.Parse(Console.ReadLine());

            //    totalPedido = (pecas[0,1] * pecas[0, 2]) + (pecas[1, 1] * pecas[1, 2]);

            //    Console.WriteLine($"O total do pedido é: {totalPedido:F2}");

            //    Console.WriteLine("Deseja calcular um novo pedido?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}

            #endregion

            #region Questão 5

            // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
            // mostre:
            // a) a área do triângulo retângulo que tem A por base e C por altura.
            // b) a área do círculo de raio C. (pi = 3.14159)
            // c) a área do trapézio que tem A e B por bases e C por altura.
            // d) a área do quadrado que tem lado B.
            // e) a área do retângulo que tem lados A e B.

            //double a, b, c;
            //string[] numeros = new string[3];

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o valor de A, B e C, serpados por um espaço em branco:");
            //    numeros = Console.ReadLine().Split(" ");

            //    a = double.Parse(numeros[0]);
            //    b = double.Parse(numeros[1]);
            //    c = double.Parse(numeros[2]);

            //    Console.WriteLine(a.ToString(), b.ToString(), c.ToString());

            //    // Para encontrar a área de um triângulo retângulo, 
            //    // basta dividir por 2 o resultado da multiplicação da base(b) pela altura(h).  

            //    double areaTrianguloRet = (a * c) / 2;

            //    Console.WriteLine($"O valor da área do triangulo levando em consideração os valores {a} e {c} é: {areaTrianguloRet:F3}");

            //    // Fórmula: area = π.raio²
            //    // Considere o valor de π = 3.14159

            //    double pi = 3.14159, areaCirculo = 0, raio = c;
            //    areaCirculo = pi * Math.Pow(raio, 2);

            //    Console.WriteLine($"O valor da área do cirulo, considerando {c} como raio é: {areaCirculo:F3}");

            //    //  A = h(B + b)
            //    //         2

            //    // h = altura
            //    // B = base maior do trapézio
            //    // b = base menor do trapézio

            //    double areaTrapezio = c * (a + b) / 2;

            //    Console.WriteLine($"O valor da área do trapézio, considerando {a} e {b} por bases e {c} por altura é: {areaTrapezio:F3}");

            //    // Como o quadrado tem lados iguais, basta pegar a medida de um dos lados e elevar ao quadrado.

            //    double areaQuadrado = Math.Pow(b, 2);

            //    Console.WriteLine($"A área do quadrado levando {b} como tamanho do lado é igual a: {areaQuadrado:F3}");


            //    // Para calcular a superfície ou área do retângulo basta multiplicar o valor da base com o da altura

            //    double areaRetangulo = a * b;

            //    Console.WriteLine($"A área do retangulo considerando {a} e {b} como lados é: {areaRetangulo:F3}");


            //    Console.WriteLine("Deseja inserir novos dados para um novo caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();


            //}


            #endregion

            #endregion

            #region Ativdade 2

            #region Questão 1

            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o número a ser verificado:");
            //    int a = int.Parse(Console.ReadLine());

            //    if (a == 0)
            //    {

            //        Console.WriteLine("Este número é neutro!");

            //    }

            //    else if(a > 0)
            //    {

            //        Console.WriteLine("Este número é positivo!");

            //    }

            //    else
            //    {
            //        Console.WriteLine("Este número é negativo!");
            //    }

            //    Console.WriteLine("Deseja verificar outro número?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}




            #endregion

            #region Questão 2

            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            //string cont = "S";

            //while (cont == "S")
            //{
            //    Console.WriteLine("Digite o número que deseja verificar:");
            //    int numero = int.Parse(Console.ReadLine());

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("Este é um número par!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Este número é impar");
            //    }

            //    Console.WriteLine("Deseja veriricar outro número?(Sim/Nâo)");
            //    cont = Console.ReadLine().ToUpper();
            //}

            #endregion

            #region Questão 3

            // Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            // ordem crescente ou decrescente.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Console.WriteLine("Digite o valor de A:");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de B:");
            //    int b = int.Parse(Console.ReadLine());

            //    if (a % b == 0 || b % a == 0)
            //    {

            //        Console.WriteLine($"{a} e {b} são mutiplos!");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a} e {b} não são multimplos!");
            //    }
            //    Console.WriteLine("Deseja verificar outro caso?(Sim/Não)");
            //    cont = Console.ReadLine();

            //}



            #endregion

            #region Questão 4

            // Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
            // começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Console.WriteLine("Digite o horário de início, seguido do horário final separados por um espaço em branco:");

            //    string[] valores = Console.ReadLine().Split(' ');
            //    int horaInicial = int.Parse(valores[0]);
            //    int horaFinal = int.Parse(valores[1]);

            //    int duracao;
            //    if (horaInicial < horaFinal)
            //    {
            //        duracao = horaFinal - horaInicial;
            //    }
            //    else
            //    {
            //        duracao = 24 - horaInicial + horaFinal;
            //    }

            //    Console.WriteLine($"O jogo durou {duracao} hora(s)");

            //    Console.WriteLine("Deseja calcalar outro caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}

            #endregion

            #region Questão 5

            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            // seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o valor a ser verificado");
            //    double numero = double.Parse(Console.ReadLine());

            //    if (numero >= 0 && numero <= 25)
            //    {
            //        Console.WriteLine("Este núemero faz parte da primeira faixa(0, 25)");
            //    }
            //    else if (numero >= 25 && numero <= 50)
            //    {
            //        Console.WriteLine("Este núemero faz parte da segunda faixa(25, 50)");
            //    }
            //    else if (numero >= 50 && numero <= 75)
            //    {
            //        Console.WriteLine("Este núemero faz parte da terceira faixa(50, 75)");
            //    }
            //    else if (numero >= 75 && numero <= 100)
            //    {
            //        Console.WriteLine("Este núemero faz parte da quarta faixa(75, 100)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Este número está fora dos intervalos determinados!");
            //    }

            //    Console.WriteLine("Deseja verificar outro caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}


            #endregion

            #region Questão 6

            // Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            // ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            // Se o ponto estiver na origem, escreva a mensagem “Origem”.
            // Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            // situação.

            //String cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Console.WriteLine("Digite o valor dos eixos X e Y separados por um espaço em branco:");

            //    string[] valores = Console.ReadLine().Split(' ');
            //    double x = double.Parse(valores[0]);
            //    double y = double.Parse(valores[1]);

            //    if (x == 0.0 && y == 0.0)
            //    {
            //        Console.WriteLine("Origem");
            //    }
            //    else if (x == 0.0)
            //    {
            //        Console.WriteLine("Eixo Y");
            //    }
            //    else if (y == 0.0)
            //    {
            //        Console.WriteLine("Eixo X");
            //    }
            //    else if (x > 0.0 && y > 0.0)
            //    {
            //        Console.WriteLine("Q1");
            //    }
            //    else if (x < 0.0 && y > 0.0)
            //    {
            //        Console.WriteLine("Q2");
            //    }
            //    else if (x < 0.0 && y < 0.0)
            //    {
            //        Console.WriteLine("Q3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Q4");
            //    }

            //    Console.WriteLine("Deseja verificar um novo caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}

            #endregion

            #region Questão 7

            // Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            // que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            // qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            // Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            // mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

            // De 0,00 a R$2.000,00         =   Isento
            // De R$2.000,01 até R$3.000,00 =    8 %
            // De R$3.000,01 até R$4.500.00 =   18 %
            // Acima de R$4.500,00          =   28 %


            // Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            // salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            // de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
            // duas casas decimais.

            //string cont = "S";
            //double imposto = 0;


            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o valor do salário a ser verificado:");
            //    double salario = double.Parse(Console.ReadLine());

            //    if (salario <= 2000)
            //    {
            //        imposto = 0;
            //    }
            //    else if (salario <= 3000)
            //    {
            //        imposto = (salario - 2000) * 0.08;

            //    }
            //    else if (salario <= 4500)
            //    {
            //        imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            //    }
            //    else if (salario > 4500)
            //    {
            //        imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            //    }

            //    if (imposto == 0)
            //    {
            //        Console.WriteLine("Salário isento de imposto!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"O valor calculado de imposto sobre o salário digitado (R${salario:F2}) é: R${imposto:F2}!");
            //    }

            //    Console.WriteLine("Deseja verificar outro caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}

            #endregion

            #endregion

            #region Atividade 3

            #region Questão 1

            // Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            // incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            //int senha = 2002, senhaDig = 0;

            //while (senhaDig != senha)
            //{
            //    Console.WriteLine("Digite a senha:");
            //    senhaDig = int.Parse(Console.ReadLine());

            //    if (senhaDig != senha)
            //    {
            //        Console.WriteLine("Senha Inválida!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Acesso concedido!");
            //    }

            //}

            #endregion

            #region Questão 2

            // Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            // um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            // 4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            // que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            // mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            // exemplo.

            //string cont = "S";

            //while(cont == "S" || cont == "SIM")
            //{
            //    int cod = 0, alcool = 0, gasolina = 0, diesel = 0;

            //    while (cod != 4)
            //    {
            //        Console.WriteLine("Digite o código do produto que deseja realizar a venda (1.Álcool 2.Gasolina 3.Diesel) ou 4 para encerrar e calcular:");
            //        cod = int.Parse(Console.ReadLine());

            //        if (cod == 1)
            //        {
            //            alcool++;
            //        }
            //        else if (cod == 2)
            //        {
            //            gasolina++;
            //        }
            //        else if (cod == 3)
            //        {
            //            diesel++;
            //        }

            //    }

            //    Console.WriteLine($"OBRIGADO! {alcool} cliente(s) comprou(aram) álcool, {gasolina} comprou(aram) gasolina e {diesel} comprou(aram) diesel.");

            //    Console.WriteLine("Deseja zerar os valores e voltar a somar vendas?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}



            #endregion


            #endregion

            #region Atividade 4

            #region Questão 1

            // Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            // se for o caso.

            //string cont = "S";

            //while(cont == "S" || cont == "SIM")
            //{

            //    int x = 0;

            //    Console.WriteLine("Digite o valor final:");
            //    x = int.Parse(Console.ReadLine());



            //    for (int i = 1; i <= x; i++)
            //    {

            //        if (i % 2 != 0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }

            //    Console.WriteLine("Deseja verificar outro caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}


            #endregion

            #region Questão 2

            // Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    int dentro = 0, fora = 0;

            //    Console.WriteLine("Digite a quantidade de números que será digitada:");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] numeros = new int[n];

            //    for (int i = 1; i <= n; i++)
            //    {
            //        int x = 1 - 1;
            //        Console.WriteLine($"Digite o {i}º número:");
            //        numeros[x] = int.Parse(Console.ReadLine());

            //        if (numeros[x] >= 10 && numeros[x] <= 20)
            //        {

            //            dentro++;

            //        }
            //        else
            //        {
            //            fora++;
            //        }
            //    }

            //    Console.WriteLine($"Foi(ram) digitado(s) {dentro} números dentro do intervalo definido (entre 10 e 20) e {fora} fora do intervalo");

            //    Console.WriteLine("Deseja verificar outros números?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();


            //}


            #endregion

            #region Questão 3

            // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            // de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            // peso 5.

            //Console.WriteLine("Digite a quantidade de casos que deseja calcular:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Digite os 3 números do primeiro caso a ser verificado:");
            //    string[] numeros = Console.ReadLine().Split(" ");
            //    double a = double.Parse(numeros[0]);
            //    double b = double.Parse(numeros[1]);
            //    double c = double.Parse(numeros[2]);

            //    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            //    Console.WriteLine($"A média ponderada (primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5), segundo os números digitado ({a:F1},{b:F1} e {c:F1} respectivamente) é: {media:F1}");

            //}

            #endregion

            #region Questão 4

            // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            // segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            //Console.WriteLine("Digite o número de pares que irá calcular as divisões:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Digite o {i}º par de números para a divisão:");
            //    string[] numeros = Console.ReadLine().Split(" ");
            //    double a = double.Parse(numeros[0]);
            //    double b = double.Parse(numeros[1]);

            //    if (b == 0)
            //    {
            //        Console.WriteLine("Impossível realizar a divisão! (Denominador igual a 0)");
            //    }
            //    else
            //    {
            //        double divisao = a / b;

            //        Console.WriteLine($"O resultado da divisão de {a} por {b} é igual a: {divisao}");
            //    }

            //}

            #endregion

            #region Questão 5

            // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            // Lembrando que, por definição, fatorial de 0 é 1.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.Write("Digite o valor à calcular o valor do fatorial:");
            //    int n = int.Parse(Console.ReadLine());

            //    int fatorial = 1;


            //    for (int i = 1; i <= n; i++)
            //    {
            //        fatorial *= i;

            //    }
            //    Console.WriteLine($"O valor fatorial de {n} fatorial, é igual a {fatorial}");



            //    Console.WriteLine("Deseja calcular novamente para um novo número?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}




            #endregion

            #region Questão 6

            // Ler um número inteiro N e calcular todos os seus divisores.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Console.Write("Digite o valor para calcular seus divisores:");
            //    int n = int.Parse(Console.ReadLine());


            //    for (int i = 1; i <= n; i++)
            //    {
            //        int x = i - 1;
            //        int[] divisores = new int[n];

            //        if (n % i == 0)
            //        {
            //            int divisor = i;
            //            divisores[x] = divisor;

            //            Console.WriteLine($"Os divisores são: {divisores[x]} ");

            //        }

            //    }

            //    Console.WriteLine("Deseja calcular os divisores de outro número?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}





            #endregion

            #region Questão 7

            // Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            // começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            // exemplo.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Console.Write("Digite o valor desejado:");
            //    int n = int.Parse(Console.ReadLine());

            //    double quad, cub;


            //    for (int i = 1; i <= n; i++)
            //    {
            //        quad = Math.Pow(i, 2);
            //        cub = Math.Pow(i, 3);

            //        Console.WriteLine($"Linha {i}. Quadrado igual à {quad} e cubo igual à {cub}");

            //    }

            //    Console.WriteLine("Deseja realizar um novo cálculo?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();


            //}



            #endregion

            #endregion

            #endregion

            #region Seção 4

            #region atividade 1

            #region Questão 1

            // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            // velha (utilizando classes).

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{
            //    Pessoas p1 = new Pessoas();
            //    Pessoas p2 = new Pessoas();

            //    Console.WriteLine("Digite o nome da primeira pessoa:");
            //    p1.Nome = Console.ReadLine();
            //    Console.WriteLine("Digite a idade da primeira pessoa:");
            //    p1.Idade = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o nome da segunda pessoa:");
            //    p2.Nome = Console.ReadLine();
            //    Console.WriteLine("Digite a idade da segunda pessoa:");
            //    p2.Idade = int.Parse(Console.ReadLine());

            //    if (p1.Idade > p2.Idade)
            //    {
            //        Console.WriteLine($"A pessoa mais velha é {p1.Nome} com {p1.Idade}!");
            //    }
            //    else if (p1.Idade == p2.Idade)
            //    {
            //        Console.WriteLine("Os dois possuem a mesma idade!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"A pessoa mais velha é {p2.Nome} com {p2.Idade}!");
            //    }
            //    Console.WriteLine("Deseja verificar mais um caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();
            //}

            #endregion

            #region Questão 2

            // Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
            // médio dos funcionários.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Funcionario func1 = new Funcionario();
            //    Funcionario func2 = new Funcionario();

            //    Console.WriteLine("Digite o nome do primeiro funcionário:");
            //    func1.Nome = Console.ReadLine();
            //    Console.WriteLine("Digite o salário do primeiro funcionáro:");
            //    func1.Salario = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o nome do segundo funcionário:");
            //    func2.Nome = Console.ReadLine();
            //    Console.WriteLine("Digite o salário do segudno funcionáro:");
            //    func2.Salario = double.Parse(Console.ReadLine());

            //    double media = (func1.Salario + func2.Salario) / 2;

            //    Console.WriteLine($"A média de salário entre {func1.Salario} e {func2.Salario} é {media}");

            //    Console.WriteLine("Deseja calcular um novo caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();
            //}

            #endregion

            #endregion

            #region Atividade 2

            #region Questão 1

            //Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
            //como mostrado no projeto ao lado.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")
            //{

            //    Console.WriteLine("Digite o valor da largura do retângulo:");
            //    double larg = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor da altura do retângulo:");
            //    double alt = double.Parse(Console.ReadLine());

            //    Retangulo ret = new Retangulo();
            //    ret.Largura = larg;
            //    ret.Altura = alt;

            //    Console.WriteLine(ret);

            //    Console.WriteLine("Deseja realiar os cálculos para um novo caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}

            #endregion

            #region Questão 2

            // Fazer um programa para ler os dados de um funcionário(nome,
            // salário bruto e imposto). Em seguida, mostrar os dados do
            // funcionário(nome e salário líquido).Em seguida, aumentar o salário
            // do funcionário com base em uma porcentagem dada(somente o
            // salário bruto é afetado pela porcentagem) e mostrar novamente os
            // dados do funcionário.Use a classe projetada abaixo.

            //string cont = "S";

            //while(cont == "S" || cont == "SIM")
            //{
            //    Console.WriteLine("Digite o nome do funcionário:");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Digite o salário bruto do funcionário:");
            //    double salario = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de imposto a ser descontado:");
            //    double imposto = double.Parse(Console.ReadLine());

            //    Funcionario func = new Funcionario();
            //    func.Nome = nome;
            //    func.SalarioBruto = salario;
            //    func.Imposto = imposto;

            //    Console.WriteLine(func);

            //    Console.WriteLine("Digite a porcentagem para realizar o aumento do salário:");
            //    double porcentagem = double.Parse(Console.ReadLine());

            //    func.AumentarSalario(porcentagem);

            //    Console.WriteLine(func);

            //    Console.WriteLine("Deseja calcular outro caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}




            #endregion

            #region Questão 3

            // Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            // (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no
            // ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            // para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
            // este problema.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")

            //{
            //    Aluno aluno = new Aluno();

            //    Console.WriteLine("Digite o nome do aluno:");
            //    aluno.Nome = Console.ReadLine();
            //    Console.WriteLine("Digite a primeira nota do aluno:");
            //    aluno.Nota1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite a segunda nota do aluno:");
            //    aluno.Nota2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite a terceira nota do aluno:");
            //    aluno.Nota3 = double.Parse(Console.ReadLine());

            //    Console.WriteLine(aluno);

            //    Console.WriteLine("Você deseja calcular um novo caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();

            //}      

            #endregion

            #endregion

            #region Atividade 3

            // Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
            // Infomrar quantos reais a pessoa vai pagar pelos dólares, condireando ainda que a pessoa terá de pagar 6 % de IOF sobre o valor em dólar. 
            // Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.

            //string cont = "S";

            //while (cont == "S" || cont == "SIM")

            //{
            //    Console.WriteLine("Digite a cotação atual do dolar:");
            //    double cotacao = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite quantos dolares gostaria de comprar");
            //    double compra = double.Parse(Console.ReadLine());

            //    double valorCompraComIof = ConversorDeMoeda.ConversaoDolar(cotacao, compra);

            //    Console.WriteLine($"Você irá pagar R${valorCompraComIof:F2} em US${compra:F2}");

            //    Console.WriteLine("Deseja calcular um novo caso?(Sim/Não)");
            //    cont = Console.ReadLine().ToUpper();
            //}            

            #endregion

            #endregion

            #region Seção 5

            #region Atividade Única

            // Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, 
            // e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito inicial, entretando, é opcional,
            // ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, 
            // naturalmente, zero.
            // Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado.
            // Já o nome do titular pode ser alterado(pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
            // Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos,
            // e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de R$5,00.Nota: 
            // a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e / ou pagar a taxa.
            // Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial.
            // Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.

            string cont = "SIM";

            while (cont == "SIM" || cont == "S")
            {

               
                Console.WriteLine("Digite o número da conta:");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do titular da conta:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o depósito inicial (opcional):");
                double depositoInicial = double.Parse(Console.ReadLine());

                ContaBancaria contaBancaria = new ContaBancaria(nome, numeroConta, depositoInicial);

                Console.WriteLine(contaBancaria);

                Console.WriteLine("Digite um valor para depósito:");
                double valorDeposito = double.Parse(Console.ReadLine());
                contaBancaria.DepositoConta(valorDeposito);

                Console.WriteLine(contaBancaria);

                Console.WriteLine("Digite um valor para saque:");
                double valorSaque = double.Parse(Console.ReadLine());
                contaBancaria.SaqueConta(valorSaque);

                Console.WriteLine(contaBancaria);

                Console.WriteLine("Deseja refazer o processo?(Sim/Não)");
                cont = Console.ReadLine().ToUpper();

            }
                       


            #endregion

            #endregion




        }


    }










}







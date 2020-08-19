using System;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Threading;

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



            #endregion

            #endregion

            #endregion

        }


    }


}

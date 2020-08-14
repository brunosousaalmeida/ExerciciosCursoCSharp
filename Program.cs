using System;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.CompilerServices;

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

            #region Atividade 2

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

            #region Atividade 3

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

            #region Atividade 4

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

            #region Atividade 5

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

            #region Atividade 6

            // Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).





            #endregion

            #endregion

            #region Seção 2

            //Não houve exercídio nesta seção

            #endregion

            #region Seção 3

            #region Atividade 1




            #endregion


            #region Ativdade 2


            #endregion

            #endregion

        }


    }


}

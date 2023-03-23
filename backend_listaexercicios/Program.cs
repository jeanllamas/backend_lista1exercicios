using System;
using System.Linq;

namespace backend_listaexercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            int resposta = 0;
            do
            {
                Console.Clear();
                resposta = 0;
                int escolha;

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} - Exercício {i}");
                }
                Console.WriteLine("Sair - Encerrar programa");
                Console.WriteLine(Environment.NewLine + "Selecione um número para ver o exercício (Ex.: '4' para exercício 4):");
                string verifica = Console.ReadLine();

                if (verifica == "Sair")
                {
                    continue;
                }
                else if ((verifica.All(Char.IsLetter))) //Verifica se a string contém letra
                {
                    goto inicio; //Volta para o começo, sem crashar o programa
                }
                else if (!(int.Parse(verifica) >= 1 && int.Parse(verifica) <= 10)) //Verifica se é menor que 1 e maior que 10
                {
                    goto inicio; //Volta para o começo, sem crashar o programa
                }
                else
                {
                    escolha = int.Parse(verifica);
                }
                Console.Clear();

                //Exercício 1
                if (escolha == 1)
                {
                    Exercicio1();
                }

                //Exercício 2
                else if (escolha == 2)
                {
                    Exercicio2();
                }

                //Exercício 3
                else if (escolha == 3)
                {
                    Exercicio3();
                }

                //Exercício 4
                else if (escolha == 4)
                {
                    Exercicio4();
                }

                //Exercício 5
                else if (escolha == 5)
                {
                    Exercicio5();
                }

                //Exercício 6
                else if (escolha == 6)
                {
                    Exercicio6();
                }

                //Exercício 7
                else if (escolha == 7)
                {
                    Exercicio7();
                }

                //Exercício 8
                else if (escolha == 8)
                {
                    Exercicio8();
                }

                //Exercício 9
                else if (escolha == 9)
                {
                    Exercicio9();
                }

                //Exercício 10
                else if (escolha == 10)
                {
                    Exercicio10();
                }

                Console.WriteLine(Environment.NewLine + "Voltar ao início? (S/N)");
                if (Console.ReadLine() != "S")
                {
                    continue;
                }
                else { resposta = 1; }

            } while (resposta != 0);
        }

        static void Exercicio1()
        {
            Console.WriteLine("Digite um valor:");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor >= 1 && valor <= 9)
            {
                Console.WriteLine("O valor está na faixa permitida");
            }
            else { Console.WriteLine("O valor está fora da faixa permitida"); }
        }

        static void Exercicio2()
        {
            Console.Write("Digite o valor do lado A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine + "Digite o valor do lado B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine + "Digite o valor do lado C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }

        static void Exercicio3()
        {
            Console.Write("Digite o nome de uma pessoa: ");
            string nome = Console.ReadLine();

            Console.Write(Environment.NewLine + $"{nome} é masculino (M) ou feminino (F)? ");
            string sexo = Console.ReadLine();

            if (sexo == "F")
            {
                Console.WriteLine(Environment.NewLine + $"Ilma Sra. {nome}");
            }
            else if (sexo == "M")
            {
                Console.WriteLine(Environment.NewLine + $"Ilmo Sr. {nome}");
            }
            else
            {
                Console.WriteLine("Erro! Tente novamente.");
            }
        }

        static void Exercicio4()
        {
            Console.WriteLine("Qual a sua altura em metros? (ex.: 1,70)");
            float h = float.Parse(Console.ReadLine());

            Console.WriteLine("Seu sexo é masculino (M) ou feminino (F)?");
            string sexo = Console.ReadLine();

            if (sexo == "F")
            {
                Console.WriteLine(Environment.NewLine + $"O peso ideal para sua altura de {h} m é {((62.1 * h) - 44.7):0.00} kg");
            }
            else if (sexo == "M")
            {
                Console.WriteLine(Environment.NewLine + $"O peso ideal para sua altura de {h} m é {((72.7 * h) - 58):0.00} kg");
            }
            else
            {
                Console.WriteLine("Erro! Tente novamente.");
            }
        }

        static void Exercicio5()
        {
            Console.Write("Digite um valor para A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine + "Digite um valor para B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine + "Digite um valor para C: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine(Environment.NewLine + $"A soma de {a} + {b} ({a + b}) é menor que {c}");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + $"A soma de {a} + {b} ({a + b}) é maior que {c}");
            }
        }

        static void Exercicio6()
        {
            Console.WriteLine("Qual o preço de etiqueta do produto?");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "a) À vista em dinheiro ou cheque, recebe 10% de desconto;");
            Console.WriteLine("b) À vista no cartão de crédito, recebe 15% de desconto;");
            Console.WriteLine("c) Em duas vezes, preço normal de etiqueta sem juros;");
            Console.WriteLine("d) Em duas vezes, preço normal de etiqueta mais juros de 10%.");
            Console.WriteLine("Como será feito o pagamento? (Digite a letra correspondente)");
            string pagamento = Console.ReadLine();

            if (pagamento == "a")
            {
                Console.WriteLine($"O produto de R${preco:0.00} recebeu 10% de desconto. O preço a pagar será R${preco - (preco * 0.1):0.00}");
            }
            else if (pagamento == "b")
            {
                Console.WriteLine($"O produto de R${preco:0.00} recebeu 15% de desconto. O preço a pagar será R${preco - (preco * 0.15):0.00}");
            }
            else if (pagamento == "c")
            {
                Console.WriteLine($"O produto de R${preco:0.00} será parcelado sem juros. O preço a pagar será 2x de R${(preco / 2):0.00}");
            }
            else if (pagamento == "d")
            {
                Console.WriteLine($"O produto de R${preco:0.00} será parcelado com 10% juros. O preço a pagar no total será R${(preco * 1.1):0.00} em 2x de R${((preco * 1.1) / 2):0.00}");
            }
            else
            {
                Console.WriteLine("Erro! Tente novamente.");
            }
        }

        static void Exercicio7()
        {
            Console.WriteLine("Digite sua data de nascimento (DD/MM/AAAA):");
            string d_nasc = Console.ReadLine();

            string[] data = d_nasc.Split('/'); //Separa o dia, mês e ano
            d_nasc = data[2] + data[1] + data[0]; //Junta em formato ano+mes+dia

            int hoje = int.Parse(DateTime.Now.ToString("yyyyMMdd")); //Recebe a data atual

            int idade = int.Parse(Convert.ToString(hoje - int.Parse(d_nasc)).Substring(0, 2)); //Identifica a idade pelos primeiros dois digitos

            if (idade < 16)
            {
                Console.WriteLine($"Você tem {idade} anos e ainda não pode votar e nem conseguir Carteira de Habilitação.");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine($"Você tem {idade} anos e já pode votar, mas ainda não pode conseguir Carteira de Habilitação.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine($"Você tem {idade} anos e pode votar e conseguir Carteira de Habilitação.");
            }
            else
            {
                Console.WriteLine("Erro! Tente novamente");
            }
        }

        static void Exercicio8()
        {
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Digite um segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + $"Escolha uma opção de cálculo a ser feita com {valor1} e {valor2}:");
            Console.WriteLine("A - adição");
            Console.WriteLine("S - subtração");
            Console.WriteLine("M - multiplicação");
            Console.WriteLine("Q - quociente (inteiro)");
            string opcao = Console.ReadLine();

            if (opcao == "A")
            {
                Console.WriteLine(Environment.NewLine + $"A soma de {valor1} com {valor2} é {valor1 + valor2}");
            }
            else if (opcao == "S")
            {
                Console.WriteLine(Environment.NewLine + $"A subtração de {valor1} com {valor2} é {valor1 - valor2}");
            }
            else if (opcao == "M")
            {
                Console.WriteLine(Environment.NewLine + $"A multiplicação de {valor1} com {valor2} é {valor1 * valor2}");
            }
            else if (opcao == "Q")
            {
                Console.WriteLine(Environment.NewLine + $"O quociente inteiro de {valor1} com {valor2} é {valor1 / valor2}");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Erro! Tente novamente");
            }
        }

        static void Exercicio9()
        {
            Console.WriteLine("Quantas aulas o(a) primeiro(a) professor(a) leciona?");
            int aulas_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto o(a) professor(a) recebe por hora/aula? (R$)");
            float pgmnt_a = float.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Quantas aulas o(a) segundo(a) professor(a) leciona?");
            int aulas_b = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto o(a) professor(a) recebe por hora/aula? (R$)");
            float pgmnt_b = float.Parse(Console.ReadLine());

            float prof_a = aulas_a * pgmnt_a;
            float prof_b = aulas_b * pgmnt_b;

            Console.WriteLine($"Salário Professor(a) A => R${(prof_a):0.00}");
            Console.WriteLine($"Salário Professor(a) B => R${(prof_b):0.00}");

            if (prof_a > prof_b)
            {
                Console.WriteLine("O(A) primeiro(a) professor(a) recebe mais que o(a) segundo(a).");
            }
            else if (prof_a < prof_b)
            {
                Console.WriteLine("O(A) segundo(a) professor(a) recebe mais que o(a) primeiro(a).");
            }
        }

        static void Exercicio10()
        {
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            if (codigo == 1)
            {
                Console.WriteLine("Alimento Não-perecível");
            }
            else if (codigo == 2 || codigo == 3 || codigo == 4)
            {
                Console.WriteLine("Alimento Perecível");
            }
            else if (codigo == 5 || codigo == 6)
            {
                Console.WriteLine("Vestuário");
            }
            else if (codigo >= 8 && codigo <= 15)
            {
                Console.WriteLine("Higiene Pessoal");
            }
            else
            {
                Console.WriteLine("Inválido");
            }
        }

    }
}

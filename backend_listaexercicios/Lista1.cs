using System;
using System.Linq;

namespace backend_listaexercicios
{
    class Lista1
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
                
                Console.WriteLine("Jean Augusto - Lista 1" + Environment.NewLine);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} - Exercício {i}");
                }
                Console.WriteLine(Environment.NewLine + "Sair - Encerrar programa");
                Console.WriteLine(Environment.NewLine + "Selecione um número para ver o exercício (Ex.: '4' para exercício 4):");
                string verifica = Console.ReadLine();
                
                //Etapa de verificação de escolha
                if (verifica == "Sair" || verifica == "sair")
                {
                    continue; //Sai do do-while encerrando o programa
                }
                else if ((verifica.All(Char.IsLetter))) //Verifica se a string contém letra
                {
                    goto inicio; //Se houver alguma letra no lugar de um número, exceto as palavras de saída, volta para o começo
                }
                else if (!(int.Parse(verifica) >= 1 && int.Parse(verifica) <= 10)) //Verifica se não é menor que 1 e maior que 10
                {
                    goto inicio; //Se for um número que não está entre 1 a 10, volta para o começo
                }
                else
                {
                    escolha = int.Parse(verifica); //Prossegue com a opção válida escolhida
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

                //Mensagem para retornar ou encerrar
                Console.WriteLine(Environment.NewLine + "Voltar ao início? (S/N)");
                string encerrar = Console.ReadLine();
                if (encerrar != "S" && encerrar != "s")
                {
                    continue;
                }
                else { resposta = 1; }

            } while (resposta != 0);
        }

        static void Exercicio1()
        {
            Console.WriteLine("Exercício 1 - Valor na faixa de 1 a 9" + Environment.NewLine);
            Console.Write("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor >= 1 && valor <= 9)
            {
                Console.WriteLine(Environment.NewLine + "O valor está na faixa permitida");
            }
            else { Console.WriteLine(Environment.NewLine + "O valor está fora da faixa permitida"); }
        }

        static void Exercicio2()
        {
            Console.WriteLine("Exercício 2 - Três valores para lados de triângulo" + Environment.NewLine);
            Console.Write("Digite o valor do lado A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(Environment.NewLine + "Digite o valor do lado B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write(Environment.NewLine + "Digite o valor do lado C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine(Environment.NewLine + "Triângulo Equilátero");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine(Environment.NewLine + "Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Triângulo Escaleno");
            }
        }

        static void Exercicio3()
        {
            Console.WriteLine("Exercício 3 - Mensagem Ilmo Sr. ou Ilma Sra." + Environment.NewLine);
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
            Console.WriteLine("Exercício 4 - Peso ideal pela altura" + Environment.NewLine);
            Console.WriteLine("Qual a sua altura em metros? (ex.: 1,70)");
            float h = float.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Seu sexo é masculino (M) ou feminino (F)?");
            string sexo = Console.ReadLine();

            if (sexo == "F")
            {
                Console.WriteLine(Environment.NewLine + $"O peso ideal para sua altura de {h} m é {((62.1 * h) - 44.7):0.00} kg"); //":0.00" arredonda o peso para duas casas decimais
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
            Console.WriteLine("Exercício 5 - Verificar se a soma de A + B é menor que C" + Environment.NewLine);
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
            Console.WriteLine("Exercício 6 - Calcular valor a ser pago pelo produto" + Environment.NewLine);
            Console.WriteLine("Qual o preço de etiqueta do produto?");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "a) À vista em dinheiro ou cheque, recebe 10% de desconto;");
            Console.WriteLine("b) À vista no cartão de crédito, recebe 15% de desconto;");
            Console.WriteLine("c) Em duas vezes, preço normal de etiqueta sem juros;");
            Console.WriteLine("d) Em duas vezes, preço normal de etiqueta mais juros de 10%.");
            Console.WriteLine(Environment.NewLine + "Como será feito o pagamento? (Digite a letra correspondente)");
            string pagamento = Console.ReadLine();

            if (pagamento == "a")
            {
                Console.WriteLine(Environment.NewLine + $"O produto de R${preco:0.00} recebeu 10% de desconto. O preço a pagar será R${preco - (preco * 0.1):0.00}");
            }
            else if (pagamento == "b")
            {
                Console.WriteLine(Environment.NewLine + $"O produto de R${preco:0.00} recebeu 15% de desconto. O preço a pagar será R${preco - (preco * 0.15):0.00}");
            }
            else if (pagamento == "c")
            {
                Console.WriteLine(Environment.NewLine + $"O produto de R${preco:0.00} será parcelado sem juros. O preço a pagar será 2x de R${(preco / 2):0.00}");
            }
            else if (pagamento == "d")
            {
                Console.WriteLine(Environment.NewLine + $"O produto de R${preco:0.00} será parcelado com 10% juros. O preço a pagar no total será R${(preco * 1.1):0.00} em 2x de R${((preco * 1.1) / 2):0.00}");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Erro! Tente novamente.");
            }
        }

        static void Exercicio7()
        {
            Console.WriteLine("Exercício 7 - Checar se tem idade suficiente para votar e ter CNH" + Environment.NewLine);
            Console.WriteLine("Digite sua data de nascimento (DD/MM/AAAA):");
            string d_nasc = Console.ReadLine();

            string[] data = d_nasc.Split('/'); //Separa o dia, mês e ano
            d_nasc = data[2] + data[1] + data[0]; //Junta em formato ano+mes+dia

            int hoje = int.Parse(DateTime.Now.ToString("yyyyMMdd")); //Recebe a data atual e deixa o formato igual à data de nascimento

            int idade = int.Parse(Convert.ToString(hoje - int.Parse(d_nasc)).Substring(0, 2)); //Identifica a idade pelos primeiros dois digitos da diferença

            if (idade < 16) //Mais novo que 16 anos
            {
                Console.WriteLine($"Você tem {idade} anos e ainda não pode votar e nem conseguir Carteira de Habilitação.");
            }
            else if (idade >= 16 && idade < 18) //Tem 16 anos ou 17, mas não 18 ainda
            {
                Console.WriteLine($"Você tem {idade} anos e já pode votar, mas ainda não pode conseguir Carteira de Habilitação.");
            }
            else if (idade >= 18) //Tem 18 anos ou mais
            {
                Console.WriteLine($"Você tem {idade} anos, portanto pode votar e conseguir Carteira de Habilitação.");
            }
        }

        static void Exercicio8()
        {
            Console.WriteLine("Exercício 8 - Opções de operações matemáticas" + Environment.NewLine);
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Digite um segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "A - adição");
            Console.WriteLine("S - subtração");
            Console.WriteLine("M - multiplicação");
            Console.WriteLine("Q - quociente (inteiro)");
            Console.WriteLine(Environment.NewLine + $"Escolha uma das opções de cálculo acima a ser feito com {valor1} e {valor2}:");
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
            Console.WriteLine("Exercício 9 - Qual professor tem salário maior" + Environment.NewLine);
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

            Console.WriteLine(Environment.NewLine + $"Salário Professor(a) A => R${(prof_a):0.00}");
            Console.WriteLine($"Salário Professor(a) B => R${(prof_b):0.00}");

            if (prof_a > prof_b)
            {
                Console.WriteLine(Environment.NewLine + "O(A) primeiro(a) professor(a) recebe mais que o(a) segundo(a).");
            }
            else if (prof_a < prof_b)
            {
                Console.WriteLine(Environment.NewLine + "O(A) segundo(a) professor(a) recebe mais que o(a) primeiro(a).");
            }
        }

        static void Exercicio10()
        {
            Console.WriteLine("Exercício 10 - Classificação do produto pelo código conforme a tabela" + Environment.NewLine);
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

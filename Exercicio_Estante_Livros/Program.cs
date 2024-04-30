namespace Exercicio_Estante_Livros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0, num=0;

            Livro[] estante_livros = null;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\nBem vindo a estante de livros, você deseja:\n1-) Adicionar Livros\n2-) Consultar Livros");
                    op = int.Parse(Console.ReadLine());
                    if ((op < 1) || (op > 2))
                    {
                        Console.WriteLine("\nInsira uma opção válida");
                    }
                } while ((op < 1) || (op > 2));
                Console.Clear();
                switch (op)
                {
                    case 1:
                        num = 0;
                        if( estante_livros == null)
                        {
                            do
                            {
                                Console.Write("\nDigite quantos livros deseja adicionar na estante: ");
                                num = int.Parse(Console.ReadLine());
                                if (num <= 0)
                                {
                                    Console.WriteLine("\nInsira uma opção válida");
                                }
                            } while (num <= 0);
                            estante_livros = new Livro[num];
                        }
                        else
                        {
                            do
                            {
                                Console.Write("\nDigite quantos livros deseja adicionar: ");
                                num = int.Parse(Console.ReadLine());
                                if (num <= 0)
                                {
                                    Console.WriteLine("\nInsira uma opção válida");
                                }
                            }while (num <= 0);
                            Livro[] estante_atualizada = new Livro[estante_livros.Length + num];
                            estante_livros.CopyTo(estante_atualizada,0);
                            estante_livros = estante_atualizada;
                        }
                        for (int i = (estante_livros.Length - num ); i < estante_livros.Length; i++)
                        {
                            Console.Clear();
                            estante_livros[i] = new Livro();
                            estante_livros[i].Registrar_Novo_Livro();
                        }
                        break;
                    case 2:
                        Print_Estante(estante_livros);
                        break;
                }
                op = 0;
                Console.Clear();
                Console.WriteLine("\nDeseja continuar a consultar a estante?\n1-) Sim\n2-) Não");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
        }
        static void Print_Estante(Livro[] estante)
        {
            int inicio = 0, fim = 0, op = 0, n = 0;
            do
            {
                Console.Clear();
                Console.Write("\nEscolha uma opção de consulta\n1-) Imprimir estante\n2-) Selecionar livro para imprimir\n" +
                    "3-) Selecionar intervalo de livros para imprimir\n:");
                op = int.Parse(Console.ReadLine());
                if ((op < 1) || (op > 3))
                {
                    Console.WriteLine("\nInsira uma opção válida");
                }
            } while ((op < 1) || (op > 3));
            switch (op)
            {
                case 1:
                    inicio = 0;
                    fim = estante.Length;
                    for (int i = inicio; i < fim; i++)
                    {
                        estante[i].Imprimir_Livro();
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    do
                    {
                        Console.Clear();
                        Console.Write("\nInsira o índice inicial para procura: ");
                        inicio = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("\nInsira o índice final para procura: ");
                        fim = int.Parse(Console.ReadLine());
                        if (fim > estante.Length)
                        {
                            fim = estante.Length;
                        }
                        if ((inicio < 0) || (fim > estante.Length) || (inicio > fim))
                        {
                            Console.WriteLine("\nInsira uma opção válida");
                        }
                    } while ((inicio < 0) || (fim > estante.Length) || (inicio > fim));
                    for (int i = inicio; i < fim; i++)
                    {
                        estante[i].Imprimir_Livro();
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    do
                    {
                        Console.Clear();
                        Console.Write("\nInsira o índice para procura: ");
                        inicio = int.Parse(Console.ReadLine()) - 1;
                        fim = inicio + 1;
                        if ((inicio < 0) || (inicio > estante.Length))
                        {
                            Console.WriteLine("\nInsira uma opção válida");
                        }
                    } while ((inicio < 0) || (inicio > estante.Length));
                    for (int i = inicio; i < fim; i++)
                    {
                        estante[i].Imprimir_Livro();
                        Console.ReadKey();
                    }
                    break;
            }

        }
    }
}



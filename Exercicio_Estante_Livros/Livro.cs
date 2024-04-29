
public class Livro
{
    public string Titulo;
    public int N_Autores;
    public string[] Autores = new string[3];
    public DateOnly Data_Lancamento;
    public string Editora;
    public int Edicao;
    public int ISBN;
    public int Quantidade_Paginas;

    public Livro() { }
    public void Registrar_Novo_Livro()
    {
        Console.Write("\n Insira o título do livro: ");
        this.Titulo = Console.ReadLine();

        Console.WriteLine();

        Console.Write("\n Insira a quantidade de autores: ");
        N_Autores = int.Parse(Console.ReadLine())-1;

        for (int i = 0; i <= N_Autores; i++)
        {
            Console.Write($" Digite o nome do {i + 1}º Autor: ");
            this.Autores[i] = Console.ReadLine();
        }

        Console.WriteLine();

        Console.Write("\n Insira a data de lançamento do livro (DD/MM/AAAA): ");
        this.Data_Lancamento = DateOnly.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("\n Insira a Editora: ");
        this.Editora = Console.ReadLine();

        Console.WriteLine();

        Console.Write("\n Insira o número da Edição: ");
        this.Edicao = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("\n Insira o código ISBN: ");
        this.ISBN = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("\n Insira a quantidade de páginas do livro: ");
        this.Quantidade_Paginas = int.Parse(Console.ReadLine());

    }
    
    public void Imprimir_Livro()
    {
        Console.WriteLine("\nTítulo: "+ this.Titulo);
        
        Console.WriteLine("\nAutor(es): ");
        for (int i = 0; i < Autores.Length; i++)
        {
            if (this.Autores[i] != null && this.Autores[i] != "")
            {
                Console.WriteLine(this.Autores[i]);
            }
        }

        Console.WriteLine("\n Data de Lançamento: " + this.Data_Lancamento);

        Console.WriteLine("\n Editora: "+ this.Editora);

        Console.WriteLine("\n Edição: "+ this.Edicao);

        Console.WriteLine("\n Código ISBN: " + this.ISBN);

        Console.WriteLine("\n Número de páginas: " + this.Quantidade_Paginas);
    }
}


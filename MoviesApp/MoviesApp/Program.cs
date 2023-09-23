namespace MoviesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Cadastrar nome do usuário");
            Console.WriteLine("2 - Cadastrar gênero de filme");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Listar filmes cadastrados");
            Console.WriteLine("5 - Sair");

            Console.Write("\nDigite o número da opção desejada: ");
            Console.ReadLine();
        }
    }
}
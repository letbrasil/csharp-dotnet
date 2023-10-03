namespace MoviesApp
{
    internal class Program
    {
        static string option; // tipo string para evitar exception/erro de conversão
        static string userName = "";

        static List<string> moviesList = new List<string>();

        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                ShowMenu();

                if (option == "4")
                {
                    endApp = true;
                }
            }

            Console.WriteLine($"Até logo {userName}!");
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar nome do usuário");
            Console.WriteLine("2 - Cadastrar filme");
            Console.WriteLine("3 - Listar filmes cadastrados");
            Console.WriteLine("4 - Sair");

            Console.Write("\nDigite o número da opção desejada: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Nome do usuário: ");
                    userName = Console.ReadLine();
                    Console.WriteLine($"\nOlá {userName}!");
                    Console.WriteLine("\n\nPressione ENTER para retornar ao menu");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Título do filme: ");
                    string movieTitle = Console.ReadLine();
                    Console.Write("Gênero do filme: ");
                    string movieGenre = Console.ReadLine();
                    moviesList.Add($"{movieTitle} | {movieGenre}");
                    Console.WriteLine($"\nFilme '{movieTitle}' cadastrado com sucesso!");
                    Console.WriteLine("\n\nPressione ENTER para retornar ao menu");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("\n============================================================");
                    Console.WriteLine($"Lista de filmes preferidos de {userName}");
                    Console.WriteLine("============================================================\n");
                    if (moviesList.Count == 0)
                    {
                        Console.WriteLine("Nenhum filme cadastrado!");
                    }
                    else
                    {
                        for (int i = 0; i < moviesList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {moviesList[i]}");
                        }
                    }
                    Console.WriteLine("\n============================================================");
                    Console.WriteLine("\n\nPressione ENTER para retornar ao menu");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("\nSaindo...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    Console.WriteLine("\n\nPressione ENTER para retornar ao menu");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
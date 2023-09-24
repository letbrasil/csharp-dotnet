namespace MoviesApp
{
    internal class Program
    {
        static string option; // tipo string para evitar exception/erro de conversão
        static string userName = "";

        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                ShowMenu();

                if (option == "5")
                {
                    endApp = true;
                }
            }

            Console.WriteLine($"Até logo {userName}!");
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1 - Cadastrar nome do usuário");
            Console.WriteLine("2 - Cadastrar gênero de filme");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Listar filmes cadastrados");
            Console.WriteLine("5 - Sair");

            Console.Write("\nDigite o número da opção desejada: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("\nNome do usuário: ");
                    userName = Console.ReadLine();
                    Console.WriteLine("");
                    break;

                case "2":
                    Console.WriteLine("\n* Em desenvolvimento *\n");
                    break;

                case "3":
                    Console.WriteLine("\n* Em desenvolvimento *\n");
                    break;

                case "4":
                    Console.WriteLine("\n* Em desenvolvimento *\n");
                    break;

                case "5":
                    Console.WriteLine("\nSaindo...\n");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!\n");
                    break;
            }
        }
    }
}
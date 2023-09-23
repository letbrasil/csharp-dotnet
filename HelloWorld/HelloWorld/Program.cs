namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string aFriend = "Bill";
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Jacob";
            Console.WriteLine($"Hello {aFriend}! :)"); // interpolação de cadeia de caracteres

            Console.WriteLine("");


            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            Console.WriteLine("");


            string greeting = "      Hello World!       ";
            Console.WriteLine(greeting);

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.WriteLine("");


            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            Console.WriteLine("");


            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics);
            Console.WriteLine("Contém 'goodbye': " + songLyrics.Contains("goodbye"));
            Console.WriteLine("Contém 'greetings': " + songLyrics.Contains("greetings"));

            Console.WriteLine("Começa com 'you': " + songLyrics.StartsWith("you"));
            Console.WriteLine("Começa com 'You': " + songLyrics.StartsWith("You"));
            Console.WriteLine("Termina com 'hello': " + songLyrics.EndsWith("hello"));
        }
    }
}
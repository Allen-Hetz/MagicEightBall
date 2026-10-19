namespace MagicEightBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] answers = {
                "It is certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy, try again",
                "Ask again late.",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful"
            };

            Console.WriteLine("=== 🎱 Magic 8-Ball ===");
            Console.WriteLine("Ask a yes/no question (or press Enter to quit).");

            while (true)
            {
                Console.Write("Your question: ");

                string question = Console.ReadLine();

                if(question == "") break;

                string answer = answers[Random.Shared.Next(answers.Length)];

                Console.WriteLine($"🎱 {answer} 🎱");
            }

            Console.WriteLine("🎱 Been real twin ngl, see ya 🎱");
        }
    }
}

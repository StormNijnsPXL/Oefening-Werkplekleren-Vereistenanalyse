namespace VereistenAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PASSWORD = "1234!";
            const string USERNAME = "ADMIN";
            int attempt = 0;

            while (attempt < 3)
            {
                attempt++;
                Console.Write("Gebruikersnaam: ");
                string inputUsername = Console.ReadLine();
                Console.Write("Wachtwoord: ");
                string inputPassword = Console.ReadLine();

                if (!inputUsername.Equals(USERNAME) || !inputPassword.Equals(PASSWORD))
                {
                    Console.WriteLine($"Foutieve login.\n{3 - attempt} pogingen over.");
                }
                else if (inputUsername.Equals(USERNAME) && inputPassword.Equals(PASSWORD))
                {
                    Console.WriteLine($"Welkom, {inputUsername}!");
                    return;
                }
            }
            Console.WriteLine("Te veel pogingen. Toegang geweigerd.");

        }
    }
}

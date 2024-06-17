namespace AuthenticationUsingArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] username = { "username1", "username2", "username3" };
            string[] password = { "password1", "password2", "password3" };

            Console.Write("Enter Username: ");
            string usernameInput = Console.ReadLine();

            Console.Write("Enter Password: ");
            string passwordInput = Console.ReadLine();

            for (int i = 0; i < username.Length; i++)
            {
                if (usernameInput.Equals(username[i], StringComparison.InvariantCultureIgnoreCase) && passwordInput.Equals(password[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine("Welcome " + usernameInput);
                    break;
                }
                else if (i >= username.Length - 1)
                {

                    Console.WriteLine();
                    Console.WriteLine("Account Not Found!");
                    break;
                }
            }
        }
    }
}

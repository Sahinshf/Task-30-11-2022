namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Are you super admin ? ( yes or no ) : ");
            string answer = Console.ReadLine();

            if ( answer == "yes")
            {
                Console.WriteLine("Please enter your name | password | Section");
                Admin Admin = new Admin( Console.ReadLine(), Console.ReadLine(), true, Console.ReadLine() );
                Admin.Information();
                Admin.allinformation();
            }
            else
            {
                Console.WriteLine("Please enter your name | password | Section");
                Admin Admin = new Admin(Console.ReadLine(), Console.ReadLine(), false, Console.ReadLine());
                Admin.Information();
                Admin.allinformation();

            }




        }
    }
}
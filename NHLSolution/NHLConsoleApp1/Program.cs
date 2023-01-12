using NHLSystemClassLibrary;
namespace NHLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt for the team name
            Console.WriteLine("Enter the team name: ");
            string teamName = Console.ReadLine();
            try
            {
                //Create a new team Instance
                Team currentTeam = new Team(teamName);
                //Print the team name
                Console.WriteLine($"Teamname: {currentTeam.Name}");
            }
            catch(ArgumentException ex)
            {
                Console.Write(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Incorrect exception thrown");
            }
            

        }
    }
}
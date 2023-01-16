// See https://aka.ms/new-console-template for more information

using NhlSystemClassLibrary;

// Prompt and read in the team name
Console.Write("Enter the team name: ");
string teamName = Console.ReadLine();
try
{
    // Create a new Team instance
    Team currentTeam = new Team(teamName, Conference.Western, Division.Pacific);
    // Print the Team Name
    Console.WriteLine($"Team Name: {currentTeam.Name}");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);  
}
catch
{
    Console.WriteLine("Incorrect exception thrown");
}

